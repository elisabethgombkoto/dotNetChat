using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public static class ModelConverter
    {
        public static UserAccountJson UserAccountJosonFromUserAccount(UserAccount userAccount)
        {
            UserAccountJson json = new UserAccountJson();
            json.Firstname = userAccount.Firstname;
            json.Lastname = userAccount.Lastname;
            json.UserID = userAccount.UserID;
            json.Username = userAccount.Username;

            return json;
        }
    }
}