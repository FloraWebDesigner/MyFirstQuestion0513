using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace MyFirstQuestion0513.Controllers
{
    public class AddTenController : ApiController
    {
        public int Get(int id)
        {
            int Addten = id + 10;
            return Addten;
        }
    }
}

namespace MyFirstQuestion0513.Controllers
{
    public class SquareController : ApiController
    {
        public int Get(int id)
        {
            int Square = id * id;
            return Square;
        }
    }
}

namespace MyFirstQuestion0513.Controllers
{
    public class GreetingController : ApiController
    {
        public String Post()
        {
            String Greeting = "Hello World!";
            return Greeting;
        }
    }
}