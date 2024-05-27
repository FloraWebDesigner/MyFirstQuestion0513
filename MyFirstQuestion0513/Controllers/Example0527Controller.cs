using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstQuestion0513.Controllers
{
    public class Example0527Controller : ApiController
    {
        // we have ability to listen for http requests
        // and provide responses to these requests


        //GET: localhost:xx/api/Example0527
        /*public string Get()
        {
            return "My http response!";
        }
        */

        public string Get()
        {
            string response = "Welcome to HTTP5125";
            
            response = "A response to a get welcome";

            return response;
        }


        //post: localhost:xx/api/Example0527 -> "A response to a post request"
        public string Get(int id)
        {
            string message =  "You entered a number";
            message = message + id;
            return message;
        }
        /// <summary>
        /// Receives a number and returns...
        /// </summary>
        /// <param name="id">the number to enter</param>
        /// <returns>
        /// "You entered the number {id}";
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/Example0527/2 -> "You entered the number2"
        ///</example>



        /// <summary>
        /// This method listens for a post request and provides a string response.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// "A request to a POST request"
        /// </returns>
        /// <example>
        /// POST: localhost:xx/api/Example0527/2 -> "A Response to a POST request"
        /// curl 
        /// </example>
        public string Post(int id)
        {
        
        string response = "A Response to a POST request";

        response = "A response to a POST welcome";

        return response;
        }
    }
}
