using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class UserAccountJson
    {
        private string lastname = "";
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        private string firstname = "";
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private string username = "";
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private int userID;
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
    }
}