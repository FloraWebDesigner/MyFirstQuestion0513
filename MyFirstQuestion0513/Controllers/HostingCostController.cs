using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Flora_Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Receives an input id, calculate the number of fortnights we need to charge, then get the tax fee and total price and return three formulas to show detailed hosting price.
        /// </summary>
        /// <param name="id">a number to input</param>
        /// <returns>
        /// 1. how many forty nights the client spent.
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


        public IEnumerable<string> Get(int id)
        {
            //Step 1: get number of fortnight.

            int numFortNight = id / 14 + 1;

            //step 2: get tax and total value with two decimal.

            decimal fortNight = 5.50m;
            decimal HSTRate = 0.13m;

            decimal payNight = numFortNight * fortNight;
            decimal payTax = payNight * HSTRate;
            decimal payTotal = payNight + payTax;

            //step 3: change night price, tax and total price to string.

            String Price_night = payNight.ToString();
            String Price_tax = payTax.ToString();
            String Price_total = payTotal.ToString();

            //step 4: return as requested.

            return new string[]{
                numFortNight + " fortnights at $5.50/FN = $"+Price_night+" CAD",
                "HST 13% = $"+Price_tax+" CAD",
                "Total = $"+Price_total+" CAD",
                };
        }

    }
}

