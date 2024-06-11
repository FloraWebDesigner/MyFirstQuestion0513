using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Flora_Assignment1.Controllers
{
    public class Practice0601Controller : ApiController
    {
        [HttpGet]
        [Route("api/Sum/{num1}/{num2}")]

        public int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        [HttpGet]
        [Route("api/triangle/{angle1}/{angle2}/{angle3}")]
        public Boolean Triangle(decimal angle1, decimal angle2, decimal angle3)
        {
            Boolean Triangle;
            if (angle1 <= 0 || angle2 <= 0 || angle3 <= 0)
            {
                Triangle = false;
                return Triangle;
            }
            decimal sum = angle1 + angle2 + angle3;
            if (sum == 180)
                Triangle = true;
            else Triangle = false;
            return Triangle;
        }


        [HttpGet]
        [Route("api/divide/{num1}/{num2}")]

        public Boolean divide(int num1, int num2)
        {
            int divide = num1 % num2;
            if (divide == 0) return true;
            else return false;
        }

        [HttpGet]
        [Route("api/power/{num1}/{num2}")]

        public double power(double num1, double num2)
        {
            double power = Math.Pow(num1, num2);
            return power;
        }

        [HttpGet]
        [Route("api/quadrant/{x}/{y}")]

        public int quadrant(double x, double y)
        {
            int quadrant;
            if (x > 0 && y > 0) { quadrant = 1; }
            else if (x > 0 && y < 0) { quadrant = 2; }
            else if (x < 0 && y > 0) { quadrant = 3; }
            else if (x < 0 && y < 0) { quadrant = 4; }
            else { quadrant = 0; }
            return quadrant;
        }

        [HttpGet]
        [Route("api/season/{tem}")]
        public string Season(int tem)
        {
            string Season;
            if (tem > 20) Season = "summer";
            else if (tem > 15) Season = "spring";
            else if (tem > 10) Season = "autumn";
            else Season = "winter";

            return Season;
        }

        [HttpGet]
        [Route("api/continuedString/{id}")]
        public string Sum(int id)
        {
            string sum = "";
            int i = 1;
            while (i <= id)
            {
                sum = sum + i + " , ";
                i++;
            }

            return sum;
        }

        [HttpGet]
        [Route("api/countFrom1")]
        public int Count()
        {
            int count = 0;
            int i = 0;
            while (i <= 25)
            {
                count = count + i;
                i++;
            }
            return count;
        }

        [HttpGet]
        [Route("api/countFrom-10")]
        public int Count2()
        {
            int count = 0;
            int i = -10;
            while (i <= 10)
            {
                count = count + i;
                i++;
            }
            return count;
        }


        [HttpGet]
        [Route("api/countFrom-20")]
        public int Count3()
        {
            int count = 0;
            int i = -20;
            while (i <= -10)
            {
                count = count + i;
                i += 2;
            }
            return count;
        }

        [HttpGet]
        [Route("api/movie")]
        public string movie()
        {
            string[] movie = { "movie1", "movie2", "movie3" };
            String message = "";
            int i = 0;
            while (i < movie.Length)
            {
                string end = ",";
                if (i == movie.Length - 1)
                {
                    end = "";
                }
                message = message + movie[i] + end;
                i++;
            }
            return message;
        }

        [HttpGet]
        [Route("api/reverse/{start}/{end}")]
        public string Reverse(int start, int end)
        {
            string reverse = "";
            string deliminated = ",";
            if (start < end)
            {
                while (start <= end)
                {

                    if (start == end)
                    {
                        deliminated = "";
                    }
                    reverse = reverse + start + deliminated;
                    start = start + 1;
                }
            }
            else
            {
                while (start >= end)
                {
                    if (start == end)
                    {
                        deliminated = "";
                    }
                    reverse = reverse + start + deliminated;
                    start = start - 1;

                }              
            }
            return reverse;
        }
    }
}

