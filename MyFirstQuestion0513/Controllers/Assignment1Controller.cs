using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Flora_Assignment1.Controllers
{
    public class Assignment1Controller : ApiController
    {
        /// <summary>
        /// Receives integer input {id} and Returns 10 more than the integer input {id}.
        /// </summary>
        /// <param name="id">the number to enter</param>
        /// <returns>id + 10</returns>
        /// <example>
        /// GET localhost/AddTen/{id} -> id+10
        /// GET localhost/AddTen/21 ->31
        /// GET localhost/AddTen/0 ->10
        /// GET localhost/AddTen/-9 ->1
        /// </example>
        [HttpGet]
        [Route("api/AddTen")]
        //GET http://localhost/api/AddTen/{id}
        public int Question1 (int id)
        {
            int Addten = id + 10;
            return Addten;
        }
    }
}
