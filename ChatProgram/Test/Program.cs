using DataBase;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ConnectionProvider provider = new ConnectionProvider();
                UserAccountBroker userDataBroker = new UserAccountBroker(provider);
                UserAccount user = userDataBroker.GetUserAccount("florian", "pwd");

                if (user != null)
                {
                    Console.WriteLine(user.Firstname);
                    Console.WriteLine(user.Lastname);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            Console.Read();
        }
    }
}
