using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.C__Solutioms
{
    internal class CF112_D2_A
    {
        //https://codeforces.com/contest/112/problem/A Petya and Strings
        public static void sol()
        {
            string s1 = Console.ReadLine().ToLower();
            string s2 = Console.ReadLine().ToLower();
            int s1Weight = 0;
            int s2Weight = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] > s2[i]) { s1Weight++; break; }
                else if (s1[i] < s2[i]) { s2Weight++; break; }

            }
            Console.WriteLine(s1Weight > s2Weight ? "1" : s1Weight < s2Weight ? "-1" : "0");

        }
    }
}
