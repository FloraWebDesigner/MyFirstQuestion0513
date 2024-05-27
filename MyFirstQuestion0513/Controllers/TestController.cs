using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MyFirstQuestion0513.Controllers
{
    public class TestController : ApiController
    {
        // GET: Test
            // Goal: Write some code which listens for a request
            // and provide a response to that response
            // localhost:xx/api/test-> "Hello 5125!"
            public int Get()
            {
                return 7;

            }
     
    }
}