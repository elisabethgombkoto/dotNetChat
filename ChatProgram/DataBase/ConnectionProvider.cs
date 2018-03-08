using MySql.Data.MySqlClient;
using System.Data;

namespace DataBase
{
    public class ConnectionProvider
    {
        public IDbConnection  GetConnection()
        {
           IDbConnection c =  new MySqlConnection("Server = dbsrv.infeo.at;Database=fhv_chat;Uid=fhv_chat_user;Pwd=test;Ssl Mode=None");
            c.Open();
            return c;
        }
    }
}