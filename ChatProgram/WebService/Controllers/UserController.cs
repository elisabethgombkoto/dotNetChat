
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebService.Models;

namespace WebService.Controllers
{

    public class UserController : ApiController
    {
        [HttpPost]
        [ActionName("Login")]
        public IHttpActionResult Login(string username, string password)
        {

            UserService service = new UserService();
            UserAccount account = null;
            try
            {
                account = service.LogIn(username, password);
                var json = ModelConverter.UserAccountJosonFromUserAccount(account);
                return Ok(json);

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        [HttpPost]
        [ActionName("Contacts")]
        public IHttpActionResult GetAllContacts(int userID)
        {
            IEnumerable<UserAccount> contacts = null;
            UserService userService = new UserService();
            List<UserAccountJson> accountJsons = new List<UserAccountJson>();
            try
            {
                contacts = userService.GetAllContactFromUser(userID);

                foreach (UserAccount a in contacts)
                {
                    var json = ModelConverter.UserAccountJosonFromUserAccount(a);
                    accountJsons.Add(json);
                }
                return Ok(accountJsons);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpPost]
        [ActionName("Register")]
        public IHttpActionResult Register([FromBody]UserAccount newAccount)
        {
            UserAccount newUser = null;
            UserService userService = new UserService();
            try
            {
                newUser = userService.Register(newAccount.Username, newAccount.Password, newAccount.Firstname, newAccount.Lastname);
                var json = ModelConverter.UserAccountJosonFromUserAccount(newUser);
                return Ok(json);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

    }   
}