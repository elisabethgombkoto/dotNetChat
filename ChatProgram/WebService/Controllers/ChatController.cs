using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebService.Controllers
{
    public class ChatController : ApiController
    {
        [HttpPost]
        [ActionName("Chats")]
        public IHttpActionResult GetAllChats(int userId)
        {
            IEnumerable<Chat> chats = null;
            ChatService chatService = new ChatService();
            try
            {
                chats = chatService.GetAllChats(userId);
                return Ok(chats);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [ActionName("Messages")]
        public IHttpActionResult GetAllMessagesFromGivenChatOrderdByTimeStamp(int chatID)
        {
            IEnumerable<Message> messages = null;
            ChatService chatService = new ChatService();

            try
            {
                messages = chatService.GetAllMessages(chatID);
                return Ok(messages);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
    }
}