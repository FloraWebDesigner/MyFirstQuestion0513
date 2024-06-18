using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstQuestion0513.Controllers
{
    public class J1Controller : ApiController
    {
        //J1 2023

        //https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2023/ccc/juniorEF.pdf
        /// <summary>
        /// Receives two inputs for package delivered and collisions and computes the total score. 
        /// </summary>
        /// <param name="deliveries">the number of package delivered</param>
        /// <param name="collisions">the number of collision with an obstacle</param>
        /// <returns>the final score at the end of a game</returns>
        /// <example>
        ///Get api/totalScore/5/2   -> 730
        ///Get api/totalScore/0/10  -> -100
        /// </example>

        [HttpGet]
        [Route("api/totalscore/{deliveries}/{collisions}")]
        public int totalScore(int deliveries, int collisions)
        {
            int deliveryScore = deliveries * 50;
            int collisionScore = collisions * 10;
            int bonus;
            if (deliveries > collisions) bonus = 500;
            else bonus = 0;
            int totalScore = deliveryScore - collisionScore + bonus;
            return totalScore;
        }
    }
}
