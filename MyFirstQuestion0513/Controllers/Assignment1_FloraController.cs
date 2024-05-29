using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc.Html;

namespace Flora_Assignment1.Controllers
{
    public class Assignment1_FloraController : ApiController
    {
        /// <summary>
        /// Receives an integer input and returns 10 more than the integer input.
        /// </summary>
        /// <param name="id">the number to input</param>
        /// <returns>input + 10</returns>
        /// <example>
        /// GET localhost/AddTen/21 -> 31
        /// GET localhost/AddTen/0 -> 10
        /// GET localhost/AddTen/-9 ->1
        /// </example>

        [HttpGet]
        [Route("api/AddTen/{id}")]
        public int Question1(int id)
        {
            int AddTen = id + 10;
            return AddTen;
        }

        /// <summary>
        /// Receives an integer input and returns its square.
        /// </summary>
        /// <param name="id">the number to input</param>
        /// <returns>the square of the integer input</returns>
        /// <example>
        /// GET localhost/Square/2 ->4
        /// GET localhost/Square/-2 ->4
        /// GET localhost/Square/10 ->100
        /// </example>
        [HttpGet]
        [Route("api/Square/{id}")]
        public int Question2(int id)
        {
            //int Square = id * id;
            int Square = (int)Math.Pow(id, 2);
            return Square;
        }

        /// <summary>
        /// Post a string
        /// </summary>
        /// <returns>curl -d "" http://localhost:58511/api/Greeting</returns>
        /// <example>
        /// POST localhost/Greeting -> Hello World!
        /// </example>
        [HttpPost]
        [Route("api/Greeting")]
        public string Question3()
            {
            return "Hello World!";
            }

        /// <summary>
        /// Receives an input id and Returns the string 'Greetings to {id} people!'
        /// </summary>
        /// <param name="id">a number to input</param>
        /// <returns>'Greetings to {id} people!'</returns>
        /// <example>
        /// GET localhost/Greeting/3 -> Greetings to 3 people!
        /// GET localhost/Greeting/6 -> Greetings to 6 people!
        /// GET localhost/Greeting/0 -> Greetings to 0 people!
        /// </example>

        [HttpGet]
        [Route("api/Greeting/{id}")]
        public string Question4(int id)
        {
            string Greeting = "Greetings to " + id + " people!";
            return Greeting;
        }

        /// <summary>
        /// Receives an input id and returns to a new number by four mathematical operations.
        /// </summary>
        /// <param name="id">a number to input</param>
        /// <returns>(id + 10) * id / (id - 1)</returns>
        /// <example>
        /// GET localhost/NumberMachine/10 ->22
        /// GET localhost/NumberMachine/-5 ->4
        /// GET localhost/NumberMachine/30 ->41
        /// </example>
        [HttpGet]
        [Route("api/NumberMachine/{id}")]
        public int Question5(int id)
        {
            int NumberMachine = (id + 10) * id / (id - 1);
            return NumberMachine;
        }

        /// <summary>
        /// Receives an input id, calculate the number of fortnights we need to charge, then get the tax fee and total price and return three formulas to show detailed hosting price.
        /// </summary>
        /// <param name="id">a number to input</param>
        /// <returns>
        /// 1. how many nights the client spent.
        /// 2. how much is the price for hosting nights.
        /// 3. how much is the tax.
        /// 4. how much is the total price.
        /// 5. return to three formula to clearly show each of those prices.
        /// </returns>
        /// <example>
        /// Get localhost/HostingCost/0 -> 
        /// 1 fortnights at $5.50/FN = $5.50 CAD
        /// HST 13% = $0.72 CAD
        /// Total = $6.22 CAD
        /// Get localhost/HostingCost/14 -> 
        /// 2 fortnights at $5.50/FN = $11.00 CAD
        /// HST 13% = $1.43 CAD
        /// Total = $12.43 CAD
        /// Get localhost/HostingCost/15 ->
        /// 2 fortnights at $5.50/FN = $11.00 CAD
        /// HST 13% = $1.43 CAD
        /// Total = $12.43 CAD
        /// Get localhost/HostingCost/21 ->
        /// 2 fortnights at $5.50/FN = $11.00 CAD
        /// HST 13% = $1.43 CAD
        /// Total = $12.43 CAD
        /// Get localhost/HostingCost/28 ->
        /// 3 fortnights at $5.50/FN = $16.50 CAD
        /// HST 13% = $2.14 CAD
        /// Total = $18.64 CAD
        /// </example>

        [HttpGet]
        [Route("api/HostingCost/{id}")]
        public IEnumerable<string> Get(int id)
        {
            //Step 1: get number of fortnight.

            int numfortnight = id / 11 + 1;
            //int Numfortnight = id / 12 + 1;
            //int Numfortnight = id / 13 + 1;
            //int Numfortnight = id / 14 + 1;

            //step 2: get tax and total value with two decimal.

            double paynight = Math.Round(numfortnight * 5.5,2);
            double paytax = Math.Round(paynight*0.13, 2);
            double paytotal = paynight + paytax;

            //step 3: change night price, tax and total price to string.

            String Price_night = String.Format("{0:0.00}", paynight);
            String Price_tax = String.Format("{0:0.00}", paytax);
            String Price_total = String.Format("{0:0.00}", paytotal);

            //step 4: return as requested.

            return new string[]{
                numfortnight + " fortnights at $5.50/FN = $"+Price_night+" CAD",
                "HST 13% = $"+Price_tax+" CAD",
                "Total = $"+Price_total+" CAD",
                };
        }

    }
}
