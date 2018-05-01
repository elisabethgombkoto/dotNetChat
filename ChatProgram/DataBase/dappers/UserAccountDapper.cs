using Dapper;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.dappers
{
    
    public class UserAccountDapper
    {

        public UserAccount GetUserAccount(IDbConnection connection, string searchUsername, string searchPassword)
        {
            return connection.Query<UserAccount>(
            "SELECT * FROM useraccount WHERE useraccount_username = @username AND useraccount_password = @password",
            new { username = searchUsername, password = searchPassword }).FirstOrDefault();

        }

        public IEnumerable<UserAccount> GetAllUserAccount(IDbConnection connection)
        {
            return connection.Query<UserAccount>(
            "SELECT * FROM useraccount").ToList();
        }

        public IEnumerable<UserAccount> GetAllContact(IDbConnection connection, int userID)
        {
            
            return connection.Query<UserAccount>(
                "SELECT * FROM fhv_chat.contact_lists cl JOIN  useraccount uc ON cl.contact_lists_useraccount_id = uc.useraccount_id WHERE contact_lists_useraccount_owner = @ID",new { ID = userID }).ToList();
        }

    }
}
