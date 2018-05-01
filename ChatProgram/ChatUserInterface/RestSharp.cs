using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUserInterface
{
    public class RestSharp
    {
        private RestClient _client;
        
        public RestSharp()
        {
            _client = RestSharpClient.Instance.Client;
        }
        public IEnumerable<ChatUI> GetChatsFromUser(int userID)
        {
            var request = new RestRequest("http://localhost:13555/api/Chat/Chats", Method.POST);
            request.AddParameter("userID", "userID");
            IEnumerable<ChatUI> chats = new List<ChatUI>();
            var asyncHandler = _client.ExecuteAsync(request, response => 
            {
                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    try
                    {
                        chats = SimpleJson.SimpleJson.DeserializeObject<IEnumerable<ChatUI>>(response.Content);
                    }
                    catch (Exception e)
                    {

                        throw new Exception(e.Message);
                    }
                }
                else
                {
                    throw new Exception(response.Content);
                }
            });
            return chats;
        }


        public IEnumerable<MessageUI> GetMessages(int chatID)
        {
            var request = new RestRequest("http://localhost:13555/api/Chat/Messages", Method.POST);
            //request.RequestFormat = DataFormat.Json;
            //var value = new Object();
            //value = chatID;
            //or add Object???
            //request.AddBody(value);
            request.AddParameter("chatID", "chatID");
            IEnumerable<MessageUI> messages = new List<MessageUI>();
            var asyncHandler = _client.ExecuteAsync(request, response => 
            {
                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    try
                    {
                        messages = SimpleJson.SimpleJson.DeserializeObject<IEnumerable<MessageUI>>(response.Content);
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }
                else
                {
                    var exception = response.Content;
                    throw new Exception(exception);
                }
            });
            return messages;
        }


        //RestClient must be a singelton, set Cookie
        public UserAccountUI LogIn(string username, string password)
        {
            
            var request = new RestRequest("http://localhost:13555/api/User/Login", Method.POST);
            //request.RequestFormat = DataFormat.Json;
            UserInfo userInfo = new UserInfo(username, password);
            request.AddBody(userInfo);
            UserAccountUI user = null;
            var asyncHandler = _client.ExecuteAsync(request, r =>
            {
                if (r.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    try
                    {
                        user = SimpleJson.SimpleJson.DeserializeObject<UserAccountUI>(r.Content);
                        //client.CookieContainer = new System.Net.CookieContainer();
                        
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }
                else
                {
                    var exception = r.Content;
                    throw new Exception(exception);
                }

            });
            return user;
        }


    //    public UserAccountUI Login(string username, string password)
    //    {
    //        try
    //        {
    //            
    //            var request = new RestRequest("http://localhost:13555/api/User/Login", Method.POST);
    //            UserInfo userInfo = new UserInfo(username, password);
    //            request.AddBody(userInfo);
    //            IRestResponse result = client.Execute(request);
    //            UserAccountUI user = null;
    //            if (result.StatusCode == System.Net.HttpStatusCode.OK)
    //            {
    //                try
    //                {
    //                    user = SimpleJson.SimpleJson.DeserializeObject<UserAccountUI>(result.Content);
    //                }
    //                catch (Exception e)
    //                {

    //                    throw new Exception(e.Message);
    //                }

    //            }
    //            else
    //            {
    //                var exception = result.Content;
    //                throw new Exception(exception);

    //            }
    //            return user;
    //        }

    //        catch (Exception e)
    //        {

    //            throw new Exception(e.Message);
    //        }
    //    }
    //}
}
