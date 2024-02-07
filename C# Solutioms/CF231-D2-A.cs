using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.C__Solutioms
{
    internal class CF231_D2_A
    {
        public static void sol()
        {
            //https://codeforces.com/contest/231/problem/A Team

            int n = int.Parse(Console.ReadLine());
            int Count = 0;
            for (int i = 0; i < n; i++)
            {
                var arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                if (arr.Sum() >= 2) { Count++; }
            }
            Console.WriteLine(Count);
        }
    }
}
