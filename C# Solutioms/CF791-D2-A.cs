using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.C__Solutioms
{
    internal class CF791_D2_A
    {
        //https://codeforces.com/contest/791/problem/A
        public static void sol()
        {


            var n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int numOfYears = 0;
            int l = n[0];
            int b = n[1];
            while (l <= b)
            {
                l *= 3;
                b *= 2;
                numOfYears++;
            }
            Console.WriteLine(numOfYears);
        }
    }
}
