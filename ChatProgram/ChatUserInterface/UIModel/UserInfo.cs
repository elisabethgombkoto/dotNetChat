using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUserInterface
{
    public class UserInfo
    {
        private string username;
        private string password;

        public UserInfo(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
