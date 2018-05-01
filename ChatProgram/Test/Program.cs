using DataBase;
using DataBase.dappers;
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
                DapperConfiguration.Initialize();
                ConnectionProvider provider = new ConnectionProvider();
                UserAccountDapper dapper = new UserAccountDapper();

                // UserAccountBroker userDataBroker = new UserAccountBroker(provider);
                //UserAccount user = userDataBroker.GetUserAccount("florian", "pwd");
                UserAccount user = null;
                IEnumerable<UserAccount> accounts = dapper.GetAllContact(provider.GetConnection(), 1);

                user = dapper.GetUserAccount(provider.GetConnection(), "florian", "pwd");
               
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
