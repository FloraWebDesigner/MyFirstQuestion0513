using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstQuestion0513.Controllers
{
    public class RouteController : ApiController
    {
        //GET: api/Route/Method1 -> "method 1"
        [HttpGet]
        [Route("api/Route/Method1")]
        public string Method1()
        {
            return "method1";
        }

        //GET: api/Route/Method2

        [HttpGet]
        [Route("api/Route/Method2")]
        public string Method2() 
        {
            return "method 2";
        }
        //GET: api/Route/Method3/{id}
        [HttpGet]
        public string Method3(int id)
        {
            string message = "Method 3 has an input of ";
            message = message + id;
                    return "method 2";
        }
        //GET: api/Route/Method4/{input1}/{input2}
        //"input 1 is {input1} and input is {input2}"

        /// <summary>
        /// Receives two inputs and outputs their value
        /// </summary>
        /// <param name="input1">the first input</param>
        /// <param name="input2">the second input</param>
        /// <returns>
        /// "input 1 is {input1} and input is {input2}"
        /// </returns>
        /// <example>
        /// GET: api/Route/Method4/2/4 -> "input..." 
        /// </example>
        /// 
        [HttpGet]
        [Route("api/Route/Method4/{input1}/{input2}")]
        public string Method4(int input1, int input2)
        {
            string output = "input 1 is " + input1;
            output = output + "and input 2 is "+input2;
            return output;
        }


        //POST: api/Route/Method5 -> "our POST request"
        [HttpPost]
        [Route("api/MyWelcome")]
        public string Method5()
        {
            return "our POST request";
        }
    }
}
