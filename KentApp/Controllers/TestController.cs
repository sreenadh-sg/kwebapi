using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KentApp.Controllers
{
    public class TestController : ApiController
    {
        [ActionName("message")]
        [HttpGet]
        public String getMessage()
        {
            return "Hello kent";
        }
    }
}
