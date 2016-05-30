using NHibernate;
using NHibernate.SqlCommand;
using System;
using System.Diagnostics;

namespace SeenTechnology.Repository.Infrastructure
{
    public class SqlStatementInterceptor : EmptyInterceptor
    {
        public override SqlString OnPrepareStatement(SqlString sqlCommand)
        {
            Trace.WriteLine(Convert.ToString(sqlCommand));
            return sqlCommand;
        }
    }
}
