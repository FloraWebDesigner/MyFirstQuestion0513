using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Flora_Assignment1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value3", "value4" };
        }

        // GET api/values/5
        //input: integer
        //output: the next four integers after the input
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id, id + 2, id / 2, id * 2 };
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}





public class ValuesController : ApiController
    {
        // GET api/values
        // This is my code.
        /*
         * This
         * is
         * a
         * mutilple
         * comment.
         */
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World!" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

