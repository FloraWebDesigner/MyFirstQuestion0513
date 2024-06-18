using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstQuestion0513.Controllers
{
    public class J3Controller : ApiController
    {
        //J3 2018
        //https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2018/stage%201/juniorEF.pdf
        [HttpGet]
        [Route("api/J3/Distance/{city1}/{city2}/{city3}/{city4}")]

        //------------------------------------------------Question----------------------------------------------------------------
        //It works on the browser, but in CMD, it shows the below.
        //'http:' is not recognized as an internal or external command,operable program or batch file.

        ///<summary>
        ///receives 4 positive integers less than 1000, each representing the distances between consecutive pairs of consecutive cities and output 5 lines, with the ith line (1 <= i <= 5) containing the distance from city i to cities 1, 2, ... 5 in order, separated by one space.
        /// </summary>
        /// <param1 name=city1>the distances between city1 and its consecutive pairs of consecutive cities</param1>
        /// <param2 name=city2>the distances between city2 and its consecutive pairs of consecutive cities</param2>
        /// <param3 name=city3>the distances between city3 and its consecutive pairs of consecutive cities</param3>
        /// <param3 name=city4>the distances between city4 and its consecutive pairs of consecutive cities</param4>
        /// <returns>a 5*5 array containing the distance from city i to cities 1, 2, ... 5 in order, separated by one space.
        /// </returns>
        /// <example>
        /// GET api/J3/Distance/3/10/12/5  
        /// ->
        /// 0 3 13 25 30
        /// 3 0 10 22 27
        /// 13 10 0 12 17
        /// 25 22 12 0 5
        /// 30 27 17 5 0
        /// </example>
        public IEnumerable<string> route5(int city1, int city2, int city3, int city4)
        {
            int[] city = new int[] { 0, city1, city2, city3, city4 };
            string[] layout = new string[5];

            for (int i = 0; i < 5; i++)
            {
                string message = "";
                for (int j = 0; j < 5; j++)
                {
                    if (j - i == 0) message += "0" + " ";
                    else if (j > i)
                    {
                        if (j - i == 1) message += (city[j]).ToString() + " ";
                        else if (j - i == 2) message += (city[j] + city[j - 1]).ToString() + " ";
                        else if (j - i == 3) message += (city[j] + city[j - 1] + city[j - 2]).ToString() + " ";
                        else message += (city1 + city2 + city3 + city4).ToString() + " ";
                    }
                    else
                    {
                        if (i - j == 1) message += (city[i]).ToString() + " ";
                        else if (i - j == 2) message += (city[i] + city[i - 1]).ToString() + " ";
                        else if (i - j == 3) message += (city[i] + city[i - 1] + city[i - 2]).ToString() + " ";
                        else message += (city1 + city2 + city3 + city4).ToString() + " ";
                    }

                }
                layout[i] = message;

            }
            return layout;
        }

    }
}
