using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace MyFirstQuestion0513.Controllers
{
    public class Practice0609Controller : ApiController
    {
        //print 1-25 counting by ls
        [HttpGet]
        [Route("api/studywhile1")]
        public string C1While()
        {
            string message = "";
            int i = 1;
            while (i <= 25)
            {
                message=message+i.ToString()+",";
                i++;
            }
            return message; 
        }



        [HttpGet]
        [Route("api/studyif1")]
        public string C1If()
        {
            string message = "";
            for (int i = 1; i <= 25; i++)
            {
                message=message+i.ToString()+",";
            }
            return message;
        }


        //print -10-10 counting by ls
        [HttpGet]
        [Route("api/studywhile2")]
        public string C2While()
        {
            string message = "";
            int i = -10;
            while (i <= 10)
            {
                message = message + i.ToString() + ",";
                i++;
            }
            return message;
        }



        [HttpGet]
        [Route("api/studyif2")]
        public string C2If()
        {
            string message = "";
            for (int i = -10; i <= 10; i++)
            {
                message = message + i.ToString() + ",";
            }
            return message;
        }

        //print -20~-10 counting by ls
        [HttpGet]
        [Route("api/studywhile3")]
        public string C3While()
        {
            string message = "";
            int i = -20;
            while (i <= -10)
            {
                message = message + i.ToString() + ",";
                i++;
            }
            return message;
        }



        [HttpGet]
        [Route("api/studyif3")]
        public string C3If()
        {
            string message = "";
            for (int i = -20; i <= -10; i=i+2)
            {
                message = message + i.ToString() + ",";
            }
            return message;
        }

        //print each movie counting by ls
        [HttpGet]
        [Route("api/studywhile4")]
        public string C4While()
        {
            string[] movies = {"movie1", "movie2", "movie3", "movie4", "movie5"};
            string message = "";
            int i = 0;
            while (i <=4)
            {
                message = message + movies[i]+",";
                i++;
            }
            return message;
        }



        [HttpGet]
        [Route("api/studyif4")]
        public string C4If()
        {
            string[] movies = { "movie1", "movie2", "movie3", "movie4", "movie5","movie6"};
            string message = "";
            for (int i = 0; i <= movies.Length-1; i = i + 1)
            {
                string ending = ",";
                if (i == movies.Length-1)
                {
                    ending = ".";
                }
                message = message + movies[i] + ending;
            }
            return message;
        }

        [HttpGet]
        [Route("api/list")]
        public string C5While()
        {
            List<string> movie = new List<string>() { "movie4", "movie3", "movie2", "movie1" };
            string message = "";
            int i = 0;
            while (i<= movie.Count-1)
            {
                message = message + movie[i]+",";
            }
            return message;
        }

        [HttpGet]
        [Route("api/IEnumberable")]
        public string C6If()
        {   // read-only, no access to the array 
            IEnumerable<string> movies = new string[] { "movie2", "movie3" };
            string message="";
            int i = 0;
            foreach(string movie in movies)
            {
                if (i == (movies.Count() - 1)) ;
                message = message + movie;
            }
            return message;
        }


        /// <summary>
        /// https://www.w3resource.com/csharp-exercises/for-loop/index.php
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/w3/q1")]
        public string Q1()
        { 
            string message = "";
            for(int i = 1; i<=10; i++)
            {
                message = message+i.ToString();
            }
            return message;
        }
        [HttpGet]
        [Route("api/w3/q3/{num1}/{num2}/{num3}")]
        public string Q2(int num1,int num2, int num3)
        {
            int sum = num1+num2+num3;
            int average = (int)(sum/3);
            return "The sum of the number is "+sum+" and the average is "+average+" .";
        }

        [HttpGet]
        [Route("api/w3/q5")]
        public string Q5()
        {
            List<string>price = new List<string>() {"apple","banana","cherry"};
            string message = "";
            for(int i = 0;i<=(price.Count()-1); i++)
            {
                message = message + price[i].ToString()+" ";
            }
            return message;
        }


        [HttpGet]
        [Route("api/w3/q6")]
        public string Q6()
        {
            IEnumerable<string>fruitList =new string[]{ "apple", "banana", "cherry" };
            string message = "";
            int i = 0;
            foreach (string fruit in fruitList) ;
            {
                if (i == (fruitList.Count() - 1));
                    message = message + fruitList;
            }
            return message;
        }


        [HttpGet]
        [Route("api/w3/q61/{num}")]
        public string Q61(int num)
        {
            int i;
            string message = "";
            for (i = 0; i < 10; i++)
            {
                message = message + num.ToString() + " x " + i.ToString() +" = "+num*i ;
            }

            return(message); 

        }

        [HttpGet]
        [Route("api/w3/q7/{num}")]
        public string Q62(int num)
        {
            int i;
            string message = "";
            for (i = 0; i < 10; i++)
            {
                message = message + num.ToString() + " x " + i.ToString() + " = " + num * i;
                Console.WriteLine("/n");

            }
            return message;
           

        }


        [HttpGet]
        [Route("api/w3/q63/{num}")]
        public string Q63(int num)
        {
            string message = "";
            int i;
            for (i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    message = message+"*";
                }
                message = message + "/";
            }
            return message;

        }

        [HttpGet]
        [Route("api/LoopPractice/ValueToValue/{start}/{end}")]
        public string Q64(int start, int end)
        {

            string message = "";
            string deliminator = ",";
            for (int i = end; i >= start; i--)
            {
                if (i == end) deliminator = ".";
                message = message + i+deliminator;
            }
            message = message.Trim(new char[] { ','});
            message = message.Trim(new char[] { '.' });
            return message;
        }




        //message = message.Trim(new char[] {','});

        [HttpGet]
        [Route("api/even/{num}")]
        public string Q7(int num)
        {
            int sum = 0;
            string message = "";
            for (int i = 2; i <=num*2; i+=2)
            {
                
                sum += i;
                message = message + i+" ";
            }
            return message+" total is "+sum;
        }

        //message = message.Trim(new char[] {','});

        [HttpGet]
        [Route("api/array")]
        public string Q8() {
            List<string> color = new List<string> { "red", "blue", "green", "black" };
            color.Add("yellow");
            color.Add("white");
            string message = "";
            string clean = ",";
            foreach(string s in color)
            {
                message += s + clean;

            }
            return message;
                
                }

        [HttpGet]
        [Route("api/step/{num}")]
        public string Q9(int num) {
            string message = "";
            for (int i = 0; i <= 20/num; i++) { 
            message += -10+num*i+" ";
            }
            return message;
        }

        [HttpGet]
        [Route("api/color")]
        public string Q10() {
            string[] color = new string[] { "red", "blue", "green" };
            string message = "";
            foreach(string s in color)
            {
                message+= s + " ";
            }
            return message;
                }

        [HttpGet]
        [Route("api/split/{message}")]
        public string Q11(string message) {
            string output = "";
            string ending = ",";

            foreach(char s in message)
            {
                if (s == message.Count()-1) 
                {
                    ending = ".";
                }
                output += s + ending;
            }

            return output;
        }




        //J3 2024

        /// <summary>
        /// receives a string with a list of score split by "," and return to the third biggest value and how many of third value in the list.
        /// </summary>
        /// <param name="input">a list of scores that are each between 0 and 75 (inclusive) and there will be at least three distinct scores in the list.</param>
        /// <returns>the third score and the number of the third score</returns>
        /// <example>
        /// GET api/2024J3/70,62,68,73  ->  62 1
        /// GET api/2024J3/75,70,60,70,70,60,75,70  ->  60 2
        /// </example>

        [HttpGet]
        [Route("api/2024J3/{input}")] //split by ","
        //https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2024/index.html
        public string getScore(string input)
        {
            int[] score = input.Split(',').Select(s => int.Parse(s)).ToArray();
            //int[] score = new int[] { 75, 70, 60, 70, 70, 60, 75, 70 };
            Array.Sort(score);
            int[] descScore = score.Reverse().ToArray();
            string message = "";
            int howManyThird = 0;
            List<int> noDuplicate = new List<int>();
            if (descScore.Length < 3) message = "NOT VALID";
            else
            {
                for (int i = 0; i < descScore.Length; i++)
                {
                    if (i == 0)
                    {
                        noDuplicate.Add(descScore[i]);
                    }
                    else if (descScore[i] != descScore[i - 1])
                    {
                        noDuplicate.Add(descScore[i]);
                    }

                }
                if (noDuplicate.Count < 3) message = "INVALID";
                else
                {
                    for (int i = 0; i < score.Length; i++)
                    {
                        if (score[i] == noDuplicate[2])
                        { howManyThird++; }
                    }
                    message = noDuplicate[2] + " " + howManyThird;
                }


            }
            return message;
        }


        //J2 2020

        //https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2020/ccc/juniorEF.pdf
        [HttpGet]
        [Route("api/virus/{people}/{patient}/{infection}")]
        public int inflection(int people, int patient, int infection)
        {
            int num = patient; //Day0
            int i;
            for (i = 1; num <= people; i++) //From Day1
            {
                num = (int)(num + patient * Math.Pow(infection, i));
            }
            return i - 1;
        }


        //J3 2020

        //https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2020/ccc/juniorEF.pdf

        [HttpGet]
        [Route("api/art/5/{x1,y1}/{x2,y2}/{x3,y3}/{x4,y4}/{x5,y5}")]
        public string art(int x1, int x2, int x3, int x4, int x5, int y1, int y2, int y3, int y4, int y5)
        {
            int[] x = { x1, x2, x3, x4, x5 };
            int[] y = { y1, y2, y3, y4, y5 };

            int maxX = 0;
            for (int i = 0; i < x.Length; i++)
            {
                maxX = Math.Max(maxX, x[i]);
            }
            int indexMaxX = Array.IndexOf(x, maxX);

            int minX = 0;
            for (int i = 0; i < x.Length; i++)
            {
                minX = Math.Min(minX, x[i]);
            }
            int indexMinX = Array.IndexOf(x, minX);

            int maxY = 0;
            for (int i = 0; i < x.Length; i++)
            {
                maxY = Math.Max(maxY, y[i]);
            }
            int indexMaxY = Array.IndexOf(x, maxY);

            int minY = 0;
            for (int i = 0; i < x.Length; i++)
            {
                maxY = Math.Min(minY, y[i]);
            }
            int indexMinY = Array.IndexOf(x, minY);
            string art = minX + " , " + minY + " ; " + maxX + " , " + maxY;
            return art;



            /*
            int maxX = Math.Max(Math.Max(x1, x2), Math.Max(x3, x4));
            maxX = Math.Max(maxX, x5);
            int minX = Math.Min(Math.Min(x1, x2), Math.Min(x3, x4));
            minX = Math.Min(minX, x5);
            int maxY = Math.Max(Math.Max(y1, y2), Math.Max(y3, y4));
            maxY = Math.Max(maxY, y5);
            int minY = Math.Min(Math.Min(y1, y2), Math.Min(y3, y4));
            minY = Math.Min(minY, y5);
            */

        }
    }


}

        /*
         * 
         *  IEnumerable<string> movies = new string[] { "movie2", "movie3" };
            string message="";
            int i = 0;
            foreach(string movie in movies)
            {
                if (i == (movies.Count() - 1)) ;
                message = message + movie;
            }
            return message;

                [HttpGet]
                [Route("api/w3/q4")]
                public static void main()        
                {
                    int ctr;
                    Console.WriteLine("Input number of terms: ");
                    ctr = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.Write("numer is {0} and the cube of {1} is {2}", i, i, i * i * i);
                    }
                }

        */



