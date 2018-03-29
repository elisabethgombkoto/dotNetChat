using Dapper.FluentMap.Mapping;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.mappers
{
    public class UserAccountMapper : EntityMap<UserAccount>
    {
        public UserAccountMapper()
        {
            Map(x => x.UserID).ToColumn("useraccount_id");
            Map(x => x.Firstname).ToColumn("useraccount_firstname");
            Map(x => x.Lastname).ToColumn("useraccount_lastname");
            Map(x => x.Username).ToColumn("useraccount_username");
            Map(x => x.Password).ToColumn("useraccount_password");

        }
    }
}
