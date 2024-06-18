using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstQuestion0513.Controllers
{
    public class J2Controller : ApiController
    {
        //J2 from CSHARP

        /// <summary>
        /// Receives two inputs of sides of two dices and return to a string showing how many ways to toll the total value of 10.
        /// </summary>
        /// <param name="m">the sides of m</param>
        /// <param name="n">the sides of n</param>
        /// <returns>
        /// How many ways to roll the total value of 10.
        /// </returns>
        /// <example>
        /// GET ../api/diceGame/6/8 -> There are 5 total ways to get the sum 10.
        /// GET ../api/diceGame/12/4 -> There are 4 total ways to get the sum 10.
        /// GET ../api/diceGame/3/3 -> There are 0 total ways to get the sum 10.
        /// GET ../api/diceGame/5/5 -> There are 1 total ways to get the sum 10.
        /// </example>
        [HttpGet]
        [Route("api/diceGame/{m}/{n}")]
        public string RolltheDice(int m, int n)
        {
            int rolls = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if ((i + j) == 10) rolls++;
                }
            }
            return ("There are " + rolls + " ways to get the sum 10.");
        }


        //J2 2018 --------------------------------------------- Question ------------------------------------------------------------

        // Hi Christine, this is what I mentioned in our earlier email, there's a special character "." in the input, and I have made it POST method as you suggested. But it still does not work.

        //https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2018/stage%201/juniorEF.pdf
        /// <summary>
        /// receives a {num} containing the integer, {yesterday} contains {num} of characters, only "C" means occupied.
        /// </summary>
        /// <param name="num">the number of the car space</param>
        /// <param name="yesterday">a string of occupied and empty car space yesterday</param>
        /// <param name="today">a string of occupied and empty car space yesterday</param>
        /// <returns>the number of parking spaces which were occupied yesterday and today.</returns>
        /// <example>
        /// POST api/J2/parkingSpace/5/CCAAC/ACCAA(using A to replace "." that was undefined with the server) ->1
        /// POST api/J2/parkingSpace/7/CCCCCCC/CACACAC  ->4
        /// </example>
        [HttpPost]
        [Route("api/parkingSpace/{num}/{yesterday}/{today}")]
        public int parkingSpace(int num, string yesterday, string today)
        {
            int parkingSpace = 0;
            for (int i = 0; i < num; i++)
            {
                if (yesterday[i] == today[i] && today[i] == 'C')
                {
                    parkingSpace++;
                }
            }
            return parkingSpace;
        }


    }
}
