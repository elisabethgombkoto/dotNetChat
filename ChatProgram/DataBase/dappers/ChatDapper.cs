using Dapper;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.dappers
{
    public class ChatDapper
    {
        public IEnumerable<Chat> GetAllChats(IDbConnection connection, int userID)
        {
            return connection.Query<Chat>(
                "SELECT chat_id FROM chat_member member JOIN  chat ch ON member.chat_member_chat_id = ch.chat_id WHERE chat_member_user_id =  @ID", new { ID = userID }).ToList();   
        }

        public IEnumerable<Message> GetAllMessegesOrderedByTime(IDbConnection connection, int chatMessageID)
        {
            return connection.Query<Message>(
                "SELECT * FROM chat_messages  WHERE chat_messages_chat_id = @ID  order by chat_messages_timestamp DESC", new { ID = chatMessageID }).ToList();
        }

    }
}
