using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;

namespace MyFirstQuestion0513.Controllers
{

    // c# J1, J2 and J3.

    public class Assignment2_FloraController : ApiController
    {

        //J1 from CSHARP

        /// <summary>
        /// Receives 4 inputs for the choice of burger, drink, side and dessert and computes the total calories of these choices.
        /// </summary>
        /// <param name="burger">the choice of burger</param>
        /// <param name="drink">the choice of drink</param>
        /// <param name="side">the choice of side</param>
        /// <param name="dessert">the choice os dessert</param>
        /// <returns>the total calories of the above choices</returns>
        /// <example>
        /// GET ../api/J1/Menu/4/4/4/4 -> "Your total calorie count is 0"
        /// GET ../api/J1/Menu/1/2/3/4 -> "Your total calorie count is 691"
        /// </example>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Calory(int burger, int drink, int side, int dessert)
        {
            int burgerCalories;
            int drinkCalories;
            int sideCalories;
            int dessertCalories;
            int totalCalories;

            if (burger == 1) burgerCalories = 461;
            else if (burger == 2) burgerCalories = 431;
            else if (burger == 3) burgerCalories = 420;
            else burgerCalories = 0;

            if (drink == 1) drinkCalories = 130;
            else if (drink == 2) drinkCalories = 160;
            else if (drink == 3) drinkCalories = 118;
            else drinkCalories = 0;

            if (side == 1) sideCalories = 100;
            else if (side == 2) sideCalories = 57;
            else if (side == 3) sideCalories = 70;
            else sideCalories = 0;

            if (dessert == 1) dessertCalories = 167;
            else if (dessert == 2) dessertCalories = 266;
            else if (dessert == 3) dessertCalories = 75;
            else dessertCalories = 0;

            totalCalories = burgerCalories + drinkCalories + sideCalories + dessertCalories;
            return ("Your total calorie count is " + totalCalories);
        }


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
        /// GET ../api/J2/DiceGame/6/8 -> There are 5 total ways to get the sum 10.
        /// GET ../api/J2/DiceGame/12/4 -> There are 4 total ways to get the sum 10.
        /// GET ../api/J2/DiceGame/3/3 -> There are 5 total ways to get the sum 10.
        /// GET ../api/J2/DiceGame/5/5 -> There are 5 total ways to get the sum 10.
        /// </example>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
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

        //J3 2018
        //https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2018/stage%201/juniorEF.pdf
        [HttpGet]
        [Route("api/2018J3/Distance/{city1}/{city2}/{city3}/{city4}")]
        ///<summary>
        ///receives 4 positive integers less than 1000, each representing the distances between consecutive pairs of consecutive cities and output 5 lines, with the ith line (1  i  5) containing the distance from city i to cities 1, 2, ... 5 in order, separated by one space.
        /// </summary>
        /// <param1 name=city1>the distances between city1 and its consecutive pairs of consecutive cities</param1>
        /// <param2 name=city2>the distances between city2 and its consecutive pairs of consecutive cities</param2>
        /// <param3 name=city3>the distances between city3 and its consecutive pairs of consecutive cities</param3>
        /// <param3 name=city4>the distances between city4 and its consecutive pairs of consecutive cities</param4>
        /// <returns>a 5*5 array containing the distance from city i to cities 1, 2, ... 5 in order, separated by one space.
        /// </returns>
        /// <example>
        /// GET api/2018J3/Distance/3/10/12/5  
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


        //more practice------------------------------------------------------------------------------------------------------

        //J1 2023

        //https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2023/ccc/juniorEF.pdf
        /// <summary>
        /// Receives two inputs for package delivered and collisions and computes the total score. 
        /// </summary>
        /// <param name="deliveries">the number of package delivered</param>
        /// <param name="collisions">the number of collision with an obstacle</param>
        /// <returns>the final score at the end of a game</returns>
        /// <example>
        ///Get api/J1/totalScore/5/2   -> 730
        ///Get api/J1/totalScore/0/10  -> -100
        /// </example>
        [HttpGet]
        [Route("api/J1/totalScore/{deliveries}/{collisions}")]
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



        //J2 2018

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
        [Route("api/J2/parkingSpace/{num}/{yesterday}/{today}")]
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



        //J2 2024

        //https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2024/index.html
        [HttpGet]
        [Route("api/Dusa/{yobis}")] //split by ","
        ///<summary>
        ///receives a number of different sizes of Yobis that may or may not be eaten by Dusa and return to the size of Dusa when it runs away(when the size is smaller than Yobis)
        /// </summary>
        /// <param name="Yobis">a string with a series of number(Yobis sizes) split by "," to get unfixed input</param>
        /// <returns>Dusa’s size when it eventually runs away.
        /// </returns>
        /// <example>
        /// GET api/Dusa/5,3,2,9,20,22,14  -> 19
        /// GET api/Dusa/10,10,3,5,13  -> 10
        /// </example>
        public int DusaEating(string Yobis)
        {
            string[] DusaEating = Yobis.Split(',');
            int Dusa = int.Parse(DusaEating[0]);
            for (int i = 1; i <= DusaEating.Length; i++)
            {
                if (Dusa > int.Parse(DusaEating[i]))
                {
                    Dusa += int.Parse(DusaEating[i]);
                }
                else break;
            }

            return Dusa;
        }






    }
}

        