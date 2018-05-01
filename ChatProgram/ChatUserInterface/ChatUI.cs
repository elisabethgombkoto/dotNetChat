using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUserInterface
{
    public class ChatUI
    {
        private int chatID;
        public int ChatID
        {
            get { return chatID; }
            set { chatID = value; }
        }

        private string chatTitel = "";
        public string ChatTitel
        {
            get { return chatTitel; }
            set { chatTitel = value; }
        }
    }
}
