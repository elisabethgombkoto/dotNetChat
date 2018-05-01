
using DataBase;
using DataBase.dappers;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebService
{
    public class ChatService
    {
        private IDbConnection _dbConnection;
        private ChatDapper _chatDapper;
        private DataBase.ConnectionProvider _cp;

        public ChatService()
        {
            _cp = new ConnectionProvider();
            _dbConnection = _cp.GetConnection();
            _chatDapper = new ChatDapper();
        }

        public IEnumerable<Chat> GetAllChats(int userID)
        {
            
            IEnumerable<Chat> chats = _chatDapper.GetAllChats(_dbConnection, userID);
            if(chats != null && chats.Any())
            {
                return chats;
            }
            else
            {
                throw new Exception("User is not involved in any chat.");
            }
        }

        public IEnumerable<Message> GetAllMessages( int chatID)
        {
            IEnumerable<Message> messages = _chatDapper.GetAllMessegesOrderedByTime(_dbConnection, chatID);
            if(messages != null && messages.Any())
            {
                return messages;
            }
            else
            {
                throw new Exception("The conversation contains no messages");
            }
        }
    }
}