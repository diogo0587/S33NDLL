using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeenTechnology.Domain.Interfaces;
using SeenTechnology.CoreUnitTest.Util;
using System.Collections.Generic;
using SeenTechnology.Domain.Entities;
using SeenTechnology.Domain.Util;
using System.Web.Mvc;
using SeenTechnology.Repository.Infrastructure.Entities;

namespace SeenTechnology.CoreUnitTest
{
    [TestClass]
    public class StartPointControllerTest : IDisposable
    {
        private readonly IUnitOfWork _unitOfWork;

        public StartPointControllerTest()
        {
            _unitOfWork = IoCContainer.Get<IUnitOfWork>();
            AuditLogEntry.InitAuditLogEntry += InitializeAuditLogEntry;
        }

        public static void InitializeAuditLogEntry(AuditLogEntry auditLogEntry)
        {
            auditLogEntry.UserId = AppDomain.CurrentDomain.Id;
            auditLogEntry.UserName = AppDomain.CurrentDomain.FriendlyName;
            auditLogEntry.UserSession = AppDomain.CurrentDomain.Id.ToString();
        }

        [TestMethod]
        public void SearchTest()
        {
            long startPointId = 58;
            string description = string.Empty;
            string auxiliary1 = string.Empty;
            long customerId = 0;
            int pageNumber = 1;

            dynamic json = Search(startPointId, description, auxiliary1, customerId, pageNumber).Data;
            bool hasError = (bool)json.hasError;

            Assert.IsFalse(hasError);
        }
        public JsonResult Search(long startPointId = 0, string description = null, string auxiliary1 = null, long customerId = 0, int page = 1)
        {
            try
            {
                using (IRepository repository = _unitOfWork.GetRepository())
                {
                    int numberOfRows = 0;
                    int numberOfPages = 0;

                    IEnumerable<dynamic> startPoints = (from s in repository.NoTrackingQuery<StartPoint>()
                                                        where (startPointId.Equals(0) || startPointId.Equals(s.Id))
                                                           && (string.IsNullOrEmpty(description) || description.Equals(s.Description))
                                                           && (string.IsNullOrEmpty(auxiliary1) || auxiliary1.Equals(s.Auxiliary1))
                                                           && (customerId.Equals(0) || customerId.Equals(s.Customer.Id))
                                                        select new
                                                        {
                                                            id = s.Id,
                                                            description = s.Description,
                                                            customerName = s.Customer.Name,
                                                            auxiliary1 = s.Auxiliary1
                                                        })
                                                        .Paginate(page, 10, _ => _.id, true, out numberOfRows, out numberOfPages)
                                                        .ToList();
                    var json = new JsonResult
                    {
                        Data = new { hasError = false, response = new { pages = numberOfPages, returnValue = startPoints } },
                        JsonRequestBehavior = JsonRequestBehavior.AllowGet
                    };

                    return json;
                }
            }
            catch (Exception e)
            {
                var json = new JsonResult
                {
                    Data = new { hasError = true, response = e.InnerException },
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };

                return json;
            }
        }

        [TestMethod]
        public void InsertTest()
        {
            var startPoint = new StartPoint
            {
                Description = "SEEN_SPO"
            };

            startPoint.ExportToJson(startPoint.Description, @"D:\\");

            dynamic json = Insert(startPoint).Data;
            bool hasError = (bool)json.hasError;

            Assert.IsFalse(hasError);
        }
        public JsonResult Insert(StartPoint startPoint)
        {
            try
            {
                using (IRepository repository = _unitOfWork.GetRepository())
                {
                    _unitOfWork.BeginTransaction();
                    repository.Insert(startPoint);
                    _unitOfWork.Commit();
                }

                var json = new JsonResult
                {
                    Data = new { hasError = false, response = "Cadastro realizado com sucesso." },
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };

                return json;
            }
            catch (Exception e)
            {
                _unitOfWork.RollbackTransaction();

                var json = new JsonResult
                {
                    Data = new { hasError = true, response = e.Message },
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };

                return json;
            }
        }

        [TestMethod]
        public void UpdateTest()
        {
            var startPoint = new StartPoint
            {
                Id = 71,
                Description = "ANDREY_SPO",
                Auxiliary1 = "007",
                Address = new Address
                {
                    City = new City { Id = 7 },
                    Street = "Av. Paraguaçu Paulista",
                    Number = "287",
                    ZipCode = "06364-550",
                    Level = 10
                },
                Customer = new Customer { Id = 6 }
            };

            Update(startPoint);

        }
        public JsonResult Update(StartPoint startPoint)
        {
            try
            {
                using (IRepository repository = _unitOfWork.GetRepository())
                {
                    StartPoint startPointDb = (from start in repository.NoTrackingQuery<StartPoint>()
                                               where start.Id.Equals(startPoint.Id)
                                               select start).FirstOrDefault();

                    startPointDb.Description = startPoint.Description;
                    startPointDb.Customer = startPoint.Customer;
                    startPointDb.Auxiliary1 = startPoint.Auxiliary1;

                    _unitOfWork.BeginTransaction();

                    if (!Equals(startPoint.Address, null))
                    {
                        repository.Insert(startPoint.Address);
                        startPointDb.Address = new Address { Id = startPoint.Address.Id };
                    }

                    repository.Update(startPoint);
                    _unitOfWork.Commit();

                    var json = new JsonResult
                    {
                        Data = new { hasError = false, response = "Cadastro realizado com sucesso." },
                        JsonRequestBehavior = JsonRequestBehavior.AllowGet
                    };

                    return json;
                }
            }
            catch (Exception e)
            {
                _unitOfWork.RollbackTransaction();

                var json = new JsonResult
                {
                    Data = new { hasError = true, response = e.Message },
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };

                return json;
            }
        }
        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
