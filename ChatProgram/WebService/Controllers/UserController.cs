
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
        [HttpGet]
        public IHttpActionResult Test()
        {
            UserAccount demo = new UserAccount();
            demo.Firstname = "Reischer";
            demo.Lastname = "Florian";
            demo.Password = "test";
            return Ok(demo);
        }

        [HttpPost]
        public IHttpActionResult Login(string username, string password)
        {
            return Ok();
        }

        [HttpPost]
        [ActionName("register")]
        public IHttpActionResult Register([FromBody]UserAccount newAccount)
        {
            UserAccount newUser = null;
            UserService userService = new UserService();
            newUser = userService.Register(newAccount.Username, newAccount.Password, newAccount.Firstname, newAccount.Lastname);
                return Ok();
        }
    }
}