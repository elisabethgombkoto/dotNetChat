using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUserInterface
{
    public class RestSharpClient
    {
        public RestClient Client { get; }
        private static RestSharpClient instance;

        private RestSharpClient()
        {
            Client = new RestClient();
        }

        public static RestSharpClient Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RestSharpClient();
                }
                return instance;
            }
        }
    }
}
