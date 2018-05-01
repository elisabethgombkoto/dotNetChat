using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUserInterface
{
    public class MessageUI
    {
        private int chatMessageID;
        public int ChatMessageID
        {
            get { return chatMessageID; }
            set { chatMessageID = value; }
        }

        private string chatMessage;
        public string ChatMessage
        {
            get { return chatMessage; }
            set { chatMessage = value; }
        }

        private int chatMessageSenderID;
        public int ChatMessageSenderID
        {
            get { return chatMessageSenderID; }
            set { chatMessageSenderID = value; }
        }

        private DateTime messageTimeStamp;
        public DateTime MessageTimeStamp
        {
            get { return messageTimeStamp; }
            set { messageTimeStamp = value; }
        }
    }
}
