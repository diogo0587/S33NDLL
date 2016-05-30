using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate.Linq;
using SeenTechnology.CoreUnitTest.Util;
using SeenTechnology.Domain.Entities;
using SeenTechnology.Domain.Interfaces;
using SeenTechnology.Domain.Util;
using SeenTechnology.Repository.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeenTechnology.CoreUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly IRepository _repository;

        public UnitTest1()
        {
            _repository = IoCContainer.Get<IRepository>();
            AuditLogEntry.InitAuditLogEntry += InitializeAuditLogEntry;
        }

        public static void InitializeAuditLogEntry(AuditLogEntry auditLogEntry)
        {
            auditLogEntry.UserId = AppDomain.CurrentDomain.Id;
            auditLogEntry.UserName = AppDomain.CurrentDomain.FriendlyName;
            auditLogEntry.UserSession = AppDomain.CurrentDomain.Id.ToString();
        }

        [TestMethod]
        public void PadraoDePersistencia()
        {
            using (IUnitOfWork unitOfWork = IoCContainer.Get<IUnitOfWork>())
            {
                unitOfWork.BeginTransaction(isNoTracking: true);

                IRepository repository = unitOfWork.GetRepository();
                IList<City> cities = repository.NoTrackingQuery<City>(_ => _.State.Equals("SP")).Take(1).ToList();

                foreach (City city in cities)
                {
                    city.Name = city.Name.ToUpper();
                    repository.Update(city);
                }

                IList<Segment> segments = repository.NoTrackingQuery<Segment>(_ => _.Description.Equals("BANCÁRIO")).Take(1).ToList();

                foreach (Segment segment in segments)
                {
                    segment.Description = segment.Description.ToLower();
                    repository.Update(segment);
                }

                unitOfWork.Commit();
            }
        }

        [TestMethod]
        public void ValidateLazyLoad()
        {
            using (IUnitOfWork unitOfWork = IoCContainer.Get<IUnitOfWork>())
            {
                IRepository repository = unitOfWork.GetRepository();
                IList<StartPoint> startPoints = repository
                    .NoTrackingQuery<StartPoint>(_ => _.Description.Equals("POLO_SAO"))
                    .Fetch(_ => _.Address)
                    .ThenFetch(_ => _.City)
                    .ToList();

                IList<StartPoint> startPointsSession = repository
                    .Query<StartPoint>(_ => _.Description.Equals("POLO_SAO"))
                    .Fetch(_ => _.Address)
                    .ThenFetch(_ => _.City)
                    .ToList();

                unitOfWork.BeginTransaction(isNoTracking: true);

                foreach (StartPoint startPoint in startPoints)
                {
                    City city = startPoint.Address.City;
                    city.Id = 0;

                    repository.Insert(city);

                    var cityObj = repository.Query<City>(_ => _.Id.Equals(city.Id)).FirstOrDefault();
                    cityObj.Name = cityObj.Name.ToUpper();

                    repository.Update(cityObj);
                }

                unitOfWork.Commit();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ImpedirPersistenciaSemUnitOfWork()
        {
            using (IRepository repository = IoCContainer.Get<IRepository>())
            {
                IList<City> cities = repository.NoTrackingQuery<City>(_ => _.State.Equals("SP")).Take(1).ToList();

                foreach (City city in cities)
                {
                    city.Name = city.Name.ToLower();
                    repository.Update(city);
                }
            }
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidarDataAnnotations()
        {
            Technician technician = new Technician
            {
                Name = "Andrey Frazatti Alves",
                ExternalId = new string('#', 10),
                CPF =  "38226546800"
            };

            using (IUnitOfWork uow = IoCContainer.Get<IUnitOfWork>())
            {
                uow.BeginTransaction();
                uow.GetRepository().Insert(technician);
                uow.Commit();
            }

        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ValidarLazyLoadHasMany()
        {
            using (IRepository repository = IoCContainer.Get<IRepository>())
            {
                var account = repository.NoTrackingQuery<Account>()
                                               .FetchMany(_ => _.OrderServiceTrackings)
                                               .Where(_ => _.User == "AFALVES")
                                               .ToList()
                                               .Select(_ => new
                                               {
                                                   Name = _.Name,
                                                   PendingTrackings = _.OrderServiceTrackings ?? null
                                               })
                                               .FirstOrDefault();

                Assert.IsNotNull(account);
            }
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ObterTodosAtendimentosSincronizados()
        {
            using (IRepository repository = IoCContainer.Get<IRepository>())
            {
                DateTime dateInitial = new DateTime(2016, 3, 31);
                DateTime dateFinal = DateTime.Now;

                int numberOfRows = 0;
                int numberOfPages = 0;

                IEnumerable<ObjDto> objDtos = (from osAttendance in repository.NoTrackingQuery<OrderServiceAttendance>()
                                               where osAttendance.DateTimeCompleted >= dateInitial
                                                  && osAttendance.DateTimeCompleted <= dateFinal
                                                  && osAttendance.OrderService.StartPointOperation.Operation.Id == 18
                                               select new ObjDto
                                               {
                                                   orderServiceAttendanceId = osAttendance.Id,
                                                   orderServiceId = osAttendance.OrderService.Id,
                                                   externalId = osAttendance.OrderService.ExternalId,
                                                   serviceEvent = osAttendance.ServiceEvent.DescriptionAfter,
                                                   dateCompleted = osAttendance.DateTimeCompleted.Value.ToString("dd'/'MM'/'yyyy HH:mm:ss"),
                                                   technician = osAttendance.Technician.Name,
                                                   protocol = osAttendance.OrderService.Protocol,
                                                   dateTimeScheduling = osAttendance.OrderService.DateTimeScheduling.Value.ToString("dd'/'MM'/'yyyy HH:mm:ss"),
                                                   isSyncronized = false,
                                                   operationId = osAttendance.OrderService.StartPointOperation.Operation.Id
                                               })
                                 .Paginate(1, 50, _ => _.dateCompleted, true, out numberOfRows, out numberOfPages);


                IEnumerable<long> attendancesId = objDtos.Select(_ => _.orderServiceAttendanceId);

                var finalQuery = repository
                    .NoTrackingQuery<OrderServiceTracking>(_ => attendancesId.Contains(_.OrderServiceAttendance.Id) && _.RecordStatus.Id == 16)
                    .Select(_ => _.OrderServiceAttendance.Id)
                    .ToArray();

                foreach (var item in objDtos)
                {
                    if (finalQuery.Contains(item.orderServiceAttendanceId))
                        item.isSyncronized = true;
                }

                Assert.IsNotNull(objDtos.ToList());
                Assert.IsTrue(numberOfRows > 0);
                Assert.IsTrue(numberOfPages > 0);
            }
        }

        [TestMethod]
        public void GetRouteTest()
        {
            IList<RouteConfigurationHelper> helperCollection;

            helperCollection = (from s in _repository.Query<RouteStretch>()
                                from d in s.RouteDetails
                                where DateTime.Now.Date.Equals(s.Route.Received.Value.Date)
                                   && s.Route.RecordStatus.Id.Equals(9)
                                   && s.Route.Technician.Id == 41
                                select new RouteConfigurationHelper
                                {
                                    OrderService = d.OrderService,
                                    ClusteredWorkflow = false,
                                    RecStatusId = d.RecordStatus.Id,
                                    Sequence = s.Seq
                                }).ToList();

            Assert.IsNotNull(helperCollection);

            foreach (var helper in helperCollection)
            {
                IEnumerable<OrderServiceDetail> orderServiceDetails = helper.OrderService.OrderServiceDetails;

                foreach (var detail in orderServiceDetails)
                {
                    Assert.IsNotNull(detail.Id);
                }
            }

        }

        [TestCleanup]
        public void DisposeTest()
        {
            _repository.Dispose();
        }
    }

    public class RouteConfigurationHelper
    {
        public OrderService OrderService { get; set; }
        public int Sequence { get; set; }
        public bool ClusteredWorkflow { get; set; }
        public long RecStatusId { get; set; }
    }

    public class ObjDto
    {
        public long orderServiceAttendanceId;
        public long orderServiceId;
        public string externalId;
        public string serviceEvent;
        public string dateCompleted;
        public string technician;
        public string protocol;
        public string dateTimeScheduling;
        public bool isSyncronized;
        public long operationId;
    }
}
