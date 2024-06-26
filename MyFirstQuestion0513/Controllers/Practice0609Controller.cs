﻿using Microsoft.Ajax.Utilities;
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
                message = message + i.ToString() + ",";
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
                message = message + i.ToString() + ",";
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
            for (int i = -20; i <= -10; i = i + 2)
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
            string[] movies = { "movie1", "movie2", "movie3", "movie4", "movie5" };
            string message = "";
            int i = 0;
            while (i <= 4)
            {
                message = message + movies[i] + ",";
                i++;
            }
            return message;
        }



        [HttpGet]
        [Route("api/studyif4")]
        public string C4If()
        {
            string[] movies = { "movie1", "movie2", "movie3", "movie4", "movie5", "movie6" };
            string message = "";
            for (int i = 0; i <= movies.Length - 1; i = i + 1)
            {
                string ending = ",";
                if (i == movies.Length - 1)
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
            while (i <= movie.Count - 1)
            {
                message = message + movie[i] + ",";
            }
            return message;
        }

        [HttpGet]
        [Route("api/IEnumberable")]
        public string C6If()
        {   // read-only, no access to the array 
            IEnumerable<string> movies = new string[] { "movie2", "movie3" };
            string message = "";
            int i = 0;
            foreach (string movie in movies)
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
            for (int i = 1; i <= 10; i++)
            {
                message = message + i.ToString();
            }
            return message;
        }
        [HttpGet]
        [Route("api/w3/q3/{num1}/{num2}/{num3}")]
        public string Q2(int num1, int num2, int num3)
        {
            int sum = num1 + num2 + num3;
            int average = (int)(sum / 3);
            return "The sum of the number is " + sum + " and the average is " + average + " .";
        }

        [HttpGet]
        [Route("api/w3/q5")]
        public string Q5()
        {
            List<string> price = new List<string>() { "apple", "banana", "cherry" };
            string message = "";
            for (int i = 0; i <= (price.Count() - 1); i++)
            {
                message = message + price[i].ToString() + " ";
            }
            return message;
        }


        [HttpGet]
        [Route("api/w3/q6")]
        public string Q6()
        {
            IEnumerable<string> fruitList = new string[] { "apple", "banana", "cherry" };
            string message = "";
            int i = 0;
            foreach (string fruit in fruitList) ;
            {
                if (i == (fruitList.Count() - 1)) ;
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
                message = message + num.ToString() + " x " + i.ToString() + " = " + num * i;
            }

            return (message);

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
                    message = message + "*";
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
                if (i == start) deliminator = ".";
                message = message + i + deliminator;
            }
            // message = message.Trim(new char[] { ','});
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
            for (int i = 2; i <= num * 2; i += 2)
            {

                sum += i;
                message = message + i + " ";
            }
            return message + " total is " + sum;
        }

        //message = message.Trim(new char[] {','});

        [HttpGet]
        [Route("api/array")]
        public string Q8()
        {
            List<string> color = new List<string> { "red", "blue", "green", "black" };
            color.Add("yellow");
            color.Add("white");
            string message = "";
            string clean = ",";
            foreach (string s in color)
            {
                message += s + clean;

            }
            return message;

        }

        [HttpGet]
        [Route("api/step/{num}")]
        public string Q9(int num)
        {
            string message = "";
            for (int i = 0; i <= 20 / num; i++)
            {
                message += -10 + num * i + " ";
            }
            return message;
        }

        [HttpGet]
        [Route("api/color")]
        public string Q10()
        {
            string[] color = new string[] { "red", "blue", "green" };
            string message = "";
            foreach (string s in color)
            {
                message += s + " ";
            }
            return message;
        }

        [HttpGet]
        [Route("api/split/{message}")]
        public string Q11(string message)
        {
            string output = "";
            string ending = ",";

            foreach (char s in message)
            {
                if (s == message.Count() - 1)
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
        [Route("api/art/{x1}/{y1}/{x2}/{y2}/{x3}/{y3}/{x4}/{y4}/{x5}/{y5}")]
        public IEnumerable<string> art(int x1, int x2, int x3, int x4, int x5, int y1, int y2, int y3, int y4, int y5)
        {
            int[] x = { x1, x2, x3, x4, x5 };
            int[] y = { y1, y2, y3, y4, y5 };

            int maxX = x1;
            for (int i = 1; i < x.Length; i++)
            {
                maxX = Math.Max(maxX, x[i]);
            }
            maxX = maxX + 1;
            //   int indexMaxX = Array.IndexOf(x, maxX);

            int minX = x1;
            for (int i = 1; i < x.Length; i++)
            {
                minX = Math.Min(minX, x[i]);
            }
            //  int indexMinX = Array.IndexOf(x, minX);
            minX = minX - 1;

            int maxY = y1;
            for (int i = 1; i < y.Length; i++)
            {
                maxY = Math.Max(maxY, y[i]);
            }
            maxY = maxY + 1;
            //   int indexMaxY = Array.IndexOf(x, maxY);

            int minY = y1;
            for (int i = 1; i < y.Length; i++)
            {
                minY = Math.Min(minY, y[i]);
            }
            minY = minY - 1;
            //   int indexMinY = Array.IndexOf(x, minY);
            //string art = minX.ToString() + " , " + minY.ToString() + " ; " + maxX.ToString()+ " , " + maxY.ToString();
            return new string[] { minX.ToString() + "," + minY.ToString(), maxX.ToString() + "," + maxY.ToString() };
        }



        [HttpGet]
        [Route("api/transparent/{s}")]
        public bool result(string s)
        {
            List<int> smallOpen = new List<int>();
            List<int> smallClose = new List<int>();
            List<int> midOpen = new List<int>();
            List<int> midClose = new List<int>();
            List<int> largeOpen = new List<int>();
            List<int> largeClose = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(') smallOpen.Add(i);
                if (s[i] == ')') smallClose.Add(i);
                if (s[i] == '[') midOpen.Add(i);
                if (s[i] == ']') midClose.Add(i);
                if (s[i] == '{') largeOpen.Add(i);
                if (s[i] == '}') largeClose.Add(i);
            }
            if ((smallOpen.Count != smallClose.Count) || (midOpen.Count != midClose.Count) || (largeOpen.Count != largeClose.Count))
            { return false; }
            else
            {
                for (int i = 0; i < smallOpen.Count; i++)
                {
                    if (smallOpen[i] > smallClose[i])
                    {
                        return false;
                    }
                }
                for (int i = 0; i < largeOpen.Count; i++)
                {
                    if (largeClose[i] < largeOpen[i])
                    {
                        return false;
                    }
                }
                for (int i = 0; i < midClose.Count; i++)
                {
                    if (midOpen[i] > midClose[i])
                    {
                        return false;
                    }
                }
                return true;

            }
        }


        [HttpGet]
        [Route("api/dup/{input}")]
        public List<int> removeDup(string input)
        {
            int[]num = input.Split(',').Select(s => int.Parse(s)).ToArray(); ;
            int dup = 0;
            List<int>noDuplicate = new List<int>();
            string message = "";
            Array.Sort(num);
            for(int i = 0;i<num.Length;i++)
            {
                int tempDup = 0;
                for (int j = i + 1; j < num.Length; j++)
                {
                    
                    if (num[i] == num[j])
                    {
                        tempDup += 1;
                    }
                }
                
                    if(tempDup!=0) { dup++; }
                    else { noDuplicate.Add(num[i]); }
                    
                }
            noDuplicate.Add(dup);
            return noDuplicate;
        }

        [HttpGet]
        [Route("api/numPlusOne/{input}")]
        public int[] PlusOne(string input)
        {
            string[] digits = input.Split(',').ToArray();

            string message = "";
            for (int i = 0; i < digits.Length; i++)
            {
                message += digits[i];
            }
            int plusOne = Int32.Parse(message) + 1;
            string plusStr = plusOne.ToString();

            string[] plusArr = new string[plusStr.Length];
            int j = 0;
            while (j < plusStr.Length)
            {
                plusArr[j] = plusStr[j].ToString();
                j++;
            }
            int[] output = plusStr.Select(n => int.Parse(n.ToString())).ToArray();
            return output;
        }


    }
        
        








    }


        /*
            
            //s = s.Replace("()",string.Empty);
            //s = s.Replace("[]",string.Empty);
            //s = s.Replace("{}",string.Empty);
            int sLeft = 0;
            int sRight = 0;
            int mLeft = 0;
            int mRight = 0;
            int lLeft = 0;
            int lRight = 0;
            foreach (var c in s)
            {
                if (c == '(') sLeft++;
                if (c == ')') sRight++;
                if (c == '[') mLeft++;
                if (c == ']') mRight++;
                if (c == '{') lLeft++;
                if (c == '}') lRight++;
            }
            if ((sLeft != sRight) || (mLeft != mRight) || (lLeft != lRight)) { return s; }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if ((s[i] == '(') && (s.IndexOf(')') > i))
                    {
                        s.Replace(s[i],'d');
                        s.Replace(Convert.ToChar(s.IndexOf(')')), 'd');
                    }
                    if ((s.IndexOf('[') == i) && (s.IndexOf(']') > i))
                    {
                        s.Replace(s[i], 'd');
                        s.Replace(Convert.ToChar(s.IndexOf(']')), 'd');
                    }
                    if ((s.IndexOf('[') == i) && (s.IndexOf(']') > i))
                    {
                        s.Replace(s[i], 'd');
                        s.Replace(Convert.ToChar(s.IndexOf(']')), 'd');
                    }
                }
                s.Replace('d','a');
                return s;
            }
        }

        */

        /*

            //J4 2018
        [HttpGet]
        [Route("api/sunflower/{string}")]
        public string rotate(string input)
        {
            int[] inputArr = input.Split(',').Select(s => int.Parse(s)).ToArray();
            string message = "";
        //    string newMessage = "";
            string lastCol = "";
            int squareNum = ((int)Math.Sqrt(inputArr.Length - 1));
        //    int rotate = (inputArr[0] + 2)%4;
            for (int i = 0; i < squareNum; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < squareNum; j++)
                    {
                        message = message + inputArr[j + 1] + ",";
                    }
                }
                else if (i != squareNum - 1)
                {
                    for (int j = 1; j <= (squareNum - 2); j++)
                    {
                        message = message + inputArr[squareNum * (j + 1) + 1] + ",";
                        lastCol = message + inputArr[j * squareNum + 1] + ",";
                    }
                }
                else
                {
                    for (int j = 0; j < squareNum; j++)
                    {
                        message = message + inputArr[(squareNum - 1) * squareNum + j + 1];
                    }
                }
                for (int j = lastCol.Length - 1; j >= 0; j--)
                {
                    message = message + lastCol[j];
                }
            }
           
            return message;
        }

        */
        /*

int position = 0;
if (rotate == 0) {position=0; }
else if (rotate == 1) { position = squareNum; }
else if (rotate == 2) {  position = squareNum*2; }
else if(rotate == 3) { position = squareNum*3; }

                    List<int>flower=new List<int>();
            for (int i = 1; i < inputArr.Length;i++)
            {
                flower[i-1] = inputArr[i];
            }
*/


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






    








