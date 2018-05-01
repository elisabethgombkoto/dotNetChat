using DataBase;
using DataBase.dappers;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace WebService.Models
{
    public class UserService
    {
        private IDbConnection _dbConnection;
        private UserAccountDapper _userAccountDapper;
        private ConnectionProvider _cp;
        public UserService()
        {
            _cp = new ConnectionProvider();
            _dbConnection = _cp.GetConnection();
            _userAccountDapper = new UserAccountDapper();
        }

        public UserAccount Register(string username, string password, string firstname, string lastname)
        {
           
            UserAccount  userAccount = _userAccountDapper.GetUserAccount(_dbConnection, username, password);
            if((userAccount.Username != null) && (userAccount.Password != null))
            {
                throw new Exception("User exist already!");
            }else if(userAccount.Username != null)
            {
                throw new Exception("Username is already used, pleas choose anotherone");
            }else if(userAccount.Password != null)
            {
                throw new Exception("Please enter a valide password!");
            }
            else
            {
              
                return null;
            }
            
        }

        public UserAccount LogIn(string username, string password)
        {
           
            UserAccount userAccount = _userAccountDapper.GetUserAccount(_dbConnection, username, password);
            if(userAccount != null)
            {
                return userAccount;
            }
            else
            {
                throw new Exception("Username or password is not found.");
            }
        }

        public IEnumerable<UserAccount> GetAllContactFromUser( int userID)
        {
            IEnumerable <UserAccount> contacts = _userAccountDapper.GetAllContact(_dbConnection, userID);
            if(contacts != null && contacts.Any())
            {
                return contacts;
            }
            else
            {
                throw new Exception("User have no contacts.");
            }
        }

        public void LogOut(string username)
        {
            throw new NotImplementedException();
        }
    }
}