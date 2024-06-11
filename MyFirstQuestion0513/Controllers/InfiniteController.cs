using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstQuestion0513.Controllers
{
    public class InfiniteController : ApiController
    {
        public static void Main(string[] args)
        {
            int[] test = { 1, 2, 3, 4, 5 };
            for(int i=0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
        }
    }
}
