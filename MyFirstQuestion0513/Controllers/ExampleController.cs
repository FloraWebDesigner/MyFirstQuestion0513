using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Flora_Assignment1.Controllers
{
    public class ExampleController : ApiController
    {
        //what kind of request would we work with?

        // GET localhost: xx/api/example/20 -> 20
        public int Get(int id)
        {
            int sum = id + 1;
            return sum;
        }
    }
}
