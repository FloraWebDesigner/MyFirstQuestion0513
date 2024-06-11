using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstQuestion0513.Controllers
{
    public class Week5Controller : ApiController
    {
        [HttpGet]
        [Route("api/Hello")]
        public string Hello()
        {
            return "Greeting";
        }



        [HttpGet]
        [Route("api/Review/GetCookies/{numCookies}/{numDrinks}")]
        ///<summary>
        ///Receives the number of cookies and drinks
        ///</summary>
        ///<param name="numCookies">
        ///the number of cookies
        ///</param>
        ///<param name="numDrinks">
        ///the number of drinks
        ///</param>
        ///<returns>
        ///</returns>
        public string Review(int numCookies, int numDrinks)
        {
            string message = "You ordered" + numCookies + " cookies and " + numDrinks + "drinks";
            return message;
        }

        /// <summary>
        /// receives two inputs for friends heights and return who is taller
        /// </summary>
        /// <param name="JoeHeight">
        /// the height of Joe
        /// </param>
        /// <param name="SamHeight">
        /// the height of Sam
        /// </param>
        /// <returns>
        /// who is taller</returns>
        /// <example>
        /// Get aip/compare/160/165  -> Sam is taller.
        /// </example>
        
        [HttpGet]
        [Route("api/compare/{JoeHeight}/{SamHeight}")]
        public string Compare(int JoeHeight, int SamHeight)
        {
            string JoeTaller = "Joe is taller.";
            string SamTaller = "Sam is taller.";
            string SameTall = "Joe and Sam is of the same height.";

            if(JoeHeight > SamHeight)
            {
                return JoeTaller;
            }
            else if(SamHeight > JoeHeight)
            {
                return SamTaller;
            }
            else {
                return SameTall;
                    }

        }

        [HttpGet]
        [Route("api/TryOuts/{MileRun}/{HighJump}/{ShotPut}")]
        public string TryOuts(int MileRun, int HighJump, int ShotPut)
        {
            // if the HighJump is  more than 100 and the mile run is less than 360 seconds
            //eligible
            //else if
            //the shotPut is more than or equal to 15
            //eligible
            //else
            //ineligible
            if ((ShotPut >= 15) || (HighJump >= 100 && MileRun <= 3))
            {
                return "ELIGIBLE";
            } else
            {
                return "INELIGIBLE";
            }

            /*
            if (HighJump > 100 && MileRun < 360)
            {
                return "ELIGIBLE";
            }
            else if (ShotPut >= 15)
            {
                return "ELIGIBLE";
            } else
            { 
                return "INELIGIBLE";
            }

            //return "Run is " + MileRun + " Jump is " + HighJump + " Shot is " + ShotPut;
            */
        }
    }
}
