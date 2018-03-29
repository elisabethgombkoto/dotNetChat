using Dapper.FluentMap.Mapping;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.mappers
{
    public class ChatMapper : EntityMap<Chat>
    {
        public ChatMapper()
        {
            Map(x => x.ChatID).ToColumn("chat_id");
            Map(x => x.ChatTitel).ToColumn("chat_titel");
            Map(x => x.ChatHost).ToColumn("chat_host");
        }
    }
}
