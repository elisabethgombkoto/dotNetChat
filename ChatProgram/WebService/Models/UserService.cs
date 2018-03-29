using DataBase;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    public class UserService
    {
        private IDbConnection _dbConnection;
        private UserAccountDapper _udapper;
        public UserService()
        {
            ConnectionProvider cp = new ConnectionProvider();
            _dbConnection = cp.GetConnection();
            UserAccountDapper _udapper = new UserAccountDapper();
        }

        public UserAccount Register(string username, string password, string firstname, string lastname)
        {
            // check if username exists, calls databaseservice
            // create new user
            // use broker to insert user to database
            UserAccountDapper userAccountDapper = new UserAccountDapper();
            UserAccount  userAccount = userAccountDapper.GetUserAccount(_dbConnection, username, password);
            if((userAccount.Username != null) && (userAccount.Password != null))
            {
                throw new Exception("User exist already!");
            }else if(userAccount.Username != null)
            {
                throw new Exception("Username is already used, pleas choose anotheróne");
            }else if(userAccount.Password != null)
            {
                throw new Exception("Please enter a valide password!");
            }
            else
            {
              
                return null;
            }
            
        }

        public bool LogIn(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void LogOut(string username)
        {
            throw new NotImplementedException();
        }
    }
}