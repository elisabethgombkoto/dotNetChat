using Dapper.FluentMap.Mapping;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.mappers
{
    public class MessageMapper : EntityMap<Message>
    {
        public MessageMapper()
        {
            Map(x => x.ChatMessageID).ToColumn("chat_messages_chat_id");
            Map(x => x.ChatMessage).ToColumn("chat_messages_message");
            Map(x => x.ChatMessageSenderID).ToColumn("chat_messages_sender_id");
            Map(x => x.MessageTimeStamp).ToColumn("chat_messages_timestamp");
        }
    }
}
