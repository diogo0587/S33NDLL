using NHibernate;
using NHibernate.Collection;
using NHibernate.Engine;
using NHibernate.Event;
using SeenTechnology.Repository.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeenTechnology.Repository.Infrastructure
{
    public class AuditUpdateListener : IPostInsertEventListener, IPostUpdateEventListener,
        IPostDeleteEventListener
    {
        public void OnPostInsert(PostInsertEvent @event)
        {
            if ((@event.Entity is AuditLogEntry) || (@event.Entity is AuditLogEntryField))
            {
                return;
            }

            LogEntity(@event, @event.State, null, "Insert", true);
        }
        public void OnPostUpdate(PostUpdateEvent @event)
        {
            if ((@event.Entity is AuditLogEntry) || (@event.Entity is AuditLogEntryField))
            {
                return;
            }

            EntityEntry oldEntry = GetEntityEntry(@event);
            LogEntity(@event, @event.State, oldEntry, "Update", false);
        }
        public void OnPostDelete(PostDeleteEvent @event)
        {
            if ((@event.Entity is AuditLogEntry) || (@event.Entity is AuditLogEntryField))
            {
                return;
            }

            EntityEntry oldEntry = GetEntityEntry(@event);
            LogEntity(@event, oldEntry.LoadedState, oldEntry, "Delete", true);
        }

        private EntityEntry GetEntityEntry(AbstractPostDatabaseOperationEvent @onPostEvent)
        {
            ISession session = @onPostEvent.Session.GetSession(EntityMode.Poco);

            object oldStateObj = session.Get(
                @onPostEvent.Entity.GetType().FullName,
                Convert.ToInt64(@onPostEvent.Entity.GetType().GetProperty("Id").GetValue(@onPostEvent.Entity)));

            return session.GetSessionImplementation().PersistenceContext.GetEntry(oldStateObj);
        }

        private void LogEntity(AbstractPostDatabaseOperationEvent onPostEvent, object[] state, EntityEntry oldEntry, string action, bool forceSave)
        {
            AuditLogEntry auditLogEntry = new AuditLogEntry().CreateAuditLogEntry(onPostEvent.Session, onPostEvent.Entity, action);

            for (int i = 0; i < state.Length; i++)
            {
                AuditLogEntryField auditLogEntryField = new AuditLogEntryField
                {
                    AuditLogEntry = auditLogEntry,
                    FieldName = onPostEvent.Persister.PropertyNames[i]
                };

                object oldValue = oldEntry != null ? oldEntry.LoadedState[i] : null;
                object newValue = state[i];

                if (onPostEvent.Persister.PropertyTypes[i].IsCollectionType)
                {
                    if (!Equals(oldValue,null))
                    {
                        var collection = ((IEnumerable<object>)((IPersistentCollection)oldValue).GetValue());
                        if (onPostEvent.Session.SessionFactory.GetClassMetadata(oldValue.GetType().GenericTypeArguments.FirstOrDefault()) != null)
                        {
                            oldValue = string.Join(";", collection.Select(_ => _.GetType().GetProperty("Id").GetValue(_).ToString()));
                        }
                        else
                        {
                            oldValue = string.Join(";", collection);
                        }
                    }

                    if (!Equals(newValue, null))
                    {
                        var collection = ((IEnumerable<object>)((IPersistentCollection)newValue).GetValue());
                        if (onPostEvent.Session.SessionFactory.GetClassMetadata(newValue.GetType().GenericTypeArguments.FirstOrDefault()) != null)
                        {
                            newValue = string.Join(";", collection.Select(_ => _.GetType().GetProperty("Id").GetValue(_).ToString()));
                        }
                        else
                        {
                            newValue = string.Join(";", collection);
                        }
                    }
                    else if (Equals(onPostEvent.Persister.PropertyCascadeStyles[i],CascadeStyle.None))
                    {
                        newValue = oldValue;
                    }
                }
                else if (onPostEvent.Persister.PropertyTypes[i].IsEntityType)
                {
                    if (!Equals(oldValue,null))
                        oldValue = Convert.ToInt64(oldValue.GetType().GetProperty("Id").GetValue(oldValue));

                    if (!Equals(newValue, null))
                    {
                        newValue = Convert.ToInt64(newValue.GetType().GetProperty("Id").GetValue(newValue));
                    }
                    else if (Equals(onPostEvent.Persister.PropertyCascadeStyles[i], CascadeStyle.None))
                    {
                        newValue = oldValue;
                    }
                }

                auditLogEntryField.OldValue = (oldValue != null) && (!string.IsNullOrWhiteSpace(oldValue.ToString())) 
                                              ? oldValue.ToString() 
                                              : null;

                auditLogEntryField.NewValue = (newValue != null) && (!string.IsNullOrWhiteSpace(newValue.ToString())) 
                                              ? newValue.ToString() 
                                              : null;

                auditLogEntryField.HasChanges = !Equals(newValue, oldValue);                

                auditLogEntry.AuditLogEntryFields.Add(auditLogEntryField);
            }

            if (forceSave || auditLogEntry.AuditLogEntryFields.Any(_ => _.HasChanges))
            {
                ISession session = onPostEvent.Session.GetSession(EntityMode.Poco);
                session.SaveOrUpdate(auditLogEntry);
            }
        }
    }
}
