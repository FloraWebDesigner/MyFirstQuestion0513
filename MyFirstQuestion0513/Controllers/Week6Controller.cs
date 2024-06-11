using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.WebPages;

namespace MyFirstQuestion0513.Controllers
{
    public class Week6Controller : ApiController
    {

        //GET api/Loop/Test -> "Hello"
        // "1234567891011121314151617181920"
        [HttpGet]
        [Route("api/Loop/WhileTest")]
        public string While()
        {
            string message = "";

            int counter = 1;
            string space = ",";
            // condition is an expression that evaluates to true or false
            while (counter <= 20)
            {

                if (counter == 20) { space = "."; }
                //continue within the loop while counter < 20
                message += counter.ToString() + space;
                counter = counter + 1;
            }
            return message;
        }

        [HttpGet]
        [Route("api/even33/{ceiling}/{step}")]
        /// <summary>
        /// count from start to end
        /// </summary>
        /// <returns>
        /// a sequence of digital starting from 0 and ending at {ceiling} at {step}
        /// </returns>
        /// <example>
        /// GET api/even33/10/1 -> "12345678910"
        /// GET api/even33/-10/2 -> ""
        /// GET api/even33/10/-1 -> NOT VALID
        /// </example>
        public string While2(int ceiling, int step)
        {
            string message = "";
            int counter = 0;
            string space = ",";
            if (ceiling > 0 && step <= 0)
            {
                return "NOT VALID";
            }

            while (counter <= ceiling)
            {
                if (counter == ceiling) { space = "."; }
                message += counter.ToString() + space;
                counter = counter + step;
            }
            return message;
        }


        /// <summary>
        /// count from 0 to input number
        /// </summary>
        /// <returns>
        /// a comma separated list of numbers starting from  0
        /// </returns>
        /// <parameter name = "floor"> the number to count from
        /// </parameter>
        /// <example>
        /// GET api/Loop/forTest/-10 ->
        /// 0,-1,-2,-3,-4,-5,-6,-7,-8,-9,-10.
        /// </example>


        [HttpGet]
        [Route("api/Loop/forTest/{floor}")]
        public string forTest(int floor)
        {
            string message = "";
            string delimiter = "";
            // for loop needs 3 pieces of information;
            // iterating variable(i)
            // loop condition
            // iterative step: i-=1, i=i-1,i--;

            for (int i = 0; i >= floor; i--)
            {
                if (i == floor)
                {
                    delimiter = ".";
                }
                message = message + i.ToString() + delimiter;

                
            }
            return message;

        }


        /// <summary>
        /// Output a list of favorite TV shows
        /// </summary>
        /// <returns>
        /// A comma separated list of TV shows
        /// <returns>
        /// 
        /// </returns>
        [HttpGet]
        [Route("api/Loop/foreachtest")]
        public string TVShows()
        {
            //string TVShows = "Breaking Bad, GOT Friends, Naruto, Brooklyn99, Sopranos";
            // List<string> TVShows = new List<string> { "Breaking Bad", "GOT", "Friends", "Naruto", "Brooklyn99", "Sopranos" };

            List<string> TVShows = new List<string>();
            // analagous to var TVShhows =[]; in js

            TVShows.Add("Breaking Bad");//0
            TVShows.Add("GOT");//1
            TVShows.Add("Friends");//2

            // loop through the list
            // on each item, add to the message

            string message = "";

            foreach (string show in TVShows)
            {
                message += show + '\n';
            }


            return message;
        }


        //--------------------------------------------------------------------------------------------in class practice-----------
        /// <summary>
        /// GET a list of Integers {start} to {limit} counting by {step}
        /// </summary>
        /// <param name="start">the first number is {start}</param>
        /// <param name="limit">the last number is {limit}</param>
        /// <param name="step">split by {step}</param>
        /// <returns>a list of Integers</returns>
        /// <example>
        /// api/LoopPractice/Counter/0/4/1		->	[0,1,2,3,4]
        /// api/LoopPractice/Counter/-10/30/10		->	[-10,0,10,20,30]
        /// api/LoopPractice/Counter/-10/-17/2		->	[0]
        /// api/LoopPractice/Counter/-10/-17/-2		->	[-10,-12,-14,-16]
        /// </example>
        /// 

        [HttpGet]
        [Route("api/LoopPratice/counter/{start}/{limit}/{step}")]
        public string Counter(int start , int limit, int step)
        {
            string message = "";
            string delimiter = ",";
            if (step == 0 || limit==start) { message = "NOT VAILD"; }
            else if ((limit-start<0&&step>0)||(limit-start>0&&step<0)) { message = "0"; }
            else if (limit < start)
            {
                for (int i = start; i >= limit; i += step)
                {
                    if (i == start+((limit-start)/step)*step)
                    {
                        delimiter = "";
                    }
                    message = message + i.ToString() + delimiter;
                }

            }
            else
            {
                for (int i = start; i <= limit; i += step)
                {
                    if (i == start + ((limit - start) / step) * step)
                    {
                        delimiter = "";
                    }
                    message = message + i.ToString() + delimiter;
                }
            }
                return message;

        }
        [HttpGet]
        [Route("api/getStep/{start}/{limit}/{step}")]

        public IEnumerable<int> CounterList ( int start, int limit, int step)
        {
            bool isIncreasing = ((limit > start) && (step > 0));
            bool isDecreasing = ((limit < start) && (step < 0));
            
                List<int>steps = new List<int>();
            if (!isIncreasing && !isDecreasing) { steps.Add(0); }
            else
            {
                for (int i = start; i <= limit; i += step)
                {
                    steps.Add(i);
                }
            }
            return steps;
        }




        /// <summary>
        /// a string which counts from {start} to {limit} counting by {step}
        /// </summary>
        /// <parameter = start> get a start point
        /// </parameter>
        /// <parameter = limit>get a ending point
        /// </parameter>
        /// <parameter=step>count by step
        /// </parameter>
        /// <return>a string which counts from {start} to {limit} counting by {step}
        /// </return>
        /// <example>
        /// api/LoopPractice/FizzyBuzzy/1/25/4/3/7 ->	"1,5,Fizzy,13,17,FizzyBuzzy,25"
        /// api/LoopPractice/FizzyBuzzy/1/4/1/1/4 ->	"Fizzy, Fizzy, Fizzy, FizzyBuzzy"
        /// api/LoopPractice/FizzyBuzzy/2/15/4/3/4 ->	"2,Fizzy,10,14"
        /// api/LoopPractice/FizzyBuzzy/10/60/12/200/200 ->	"10,22,34,46,58"
        /// api/LoopPractice/FizzyBuzzy/-40/-20/3/-2/-5 ->	"FizzyBuzzy,-37,Fizzy,-31,Fizzy,Buzzy,Fizzy"
        /// </example>
        /// 

        [HttpGet]
        [Route("api/LoopPractice/FizzyBuzzy/{start}/{limit}/{step}/{Fizzy}/{Buzzy}")]
        public string FizzyBussy(int start, int limit, int step, int Fizzy, int Buzzy ) {
            string message="";
            string delimiter = ",";
            for(int i = start; i <= limit;i+= step)
            {
                if (i == start + ((limit - start) / step) * step) delimiter = "";
                if (i % Fizzy == 0 && i % Buzzy == 0) message = message + "FizzyBuzzy" + delimiter;
                else if (i % Fizzy == 0) message = message + "Fizzy" + delimiter;
                else if (i % Buzzy == 0) message = message + "Buzzy" + delimiter;
                else message = message + i.ToString() + delimiter;
            }
            return message;
        }

        [HttpGet]
        [Route("api/LoopPractice/Chess")]

        ///<summary>
        ///Get amount and return a list of strings describing the minimum number of bills and coins needed to achieve the {amount}
        /// </summary>
        /// <param name="amount">receives amount</param>
        /// <returns>
        /// A list of strings describing the minimum number of bills and coins needed to achieve the {amount}.
        /// </returns>
        /// <example>
        /// api/LoopPractice/GetChange/100.23/  ->	["Twenties : 5","Dimes : 2", "Pennies : 3"]
        /// api/LoopPractice/GetChange/13.68/	->	["Tens : 1","Toonies : 1","Loonies : 1","Quarters : 2", "Dimes : 1","Nickels : 1","Pennies : 3"]
        /// </example>
        public string chessBoard()
        {
            string chess = "ABCDEFGH";
            string color = "DLDLDLDLD";
            char getCol;
            string getColor;
            string deliminator = ",";
            string message = "";
            for(int i=0;i<=chess.Length-1; i++)
            {   

                for(int j=0;j<=chess.Length-1;j++)
                {
                    if (i % 2 == 0)
                    {
                        getCol = color[j];
                    }
                    else { getCol = color[j+1]; }
                    if (chess[j] + (i + 1).ToString() == "H8") deliminator = "";
                    if (getCol == 'D') { getColor = "Dark"; }
                    else { getColor = "Light"; }
                    message = message + "(" + chess[j]+(i+1).ToString() + ":"+getColor+")"+deliminator;
                }
            }
            return message;

        }

    }
}
    

