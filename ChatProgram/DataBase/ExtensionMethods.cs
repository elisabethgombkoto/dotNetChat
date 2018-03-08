using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public static class ExtensionMethods
    {
        public static IDbDataParameter AddParameter(this IDbCommand command, string parametertype, DbType dbType, object value)
        {
            IDbDataParameter dataParameter = command.CreateParameter();
            dataParameter.DbType = dbType;
            dataParameter.ParameterName = parametertype;
            dataParameter.Value = value;
            command.Parameters.Add(dataParameter);
            return dataParameter;
        }
    }
}
