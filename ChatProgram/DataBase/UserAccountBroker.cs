using Model;
using System.Data;

namespace DataBase
{
    public class UserAccountBroker
    {
        private ConnectionProvider connectionProvider;
       public UserAccountBroker(ConnectionProvider connectionProvider)
        {
            this.connectionProvider = connectionProvider;
        }
        
            public UserAccount GetUserAccount(string username,string password)
        {
            using (IDbConnection connection = connectionProvider.GetConnection())
           {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM useraccount WHERE useraccount_username = ?username AND useraccount_password = ?password";
                    command.AddParameter("?username", DbType.String, username);
                    command.AddParameter("?password", DbType.String, password);
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserAccount ua = new UserAccount();
                            ua.UserID = (int)reader["useraccount_id"];
                            ua.Firstname = (string)reader["useraccount_firstname"];
                            ua.Lastname = (string)reader["useraccount_lastname"];
                            ua.Username = (string)reader["useraccount_username"];
                            ua.Password = (string)reader["useraccount_password"];
                            return ua;
                        }
                        else
                        {
                            throw new System.Exception("Username or password did not match");
                        }
                    }
                }
            } 
        }
    }
}
