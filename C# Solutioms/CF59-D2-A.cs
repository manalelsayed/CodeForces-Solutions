using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.C__Solutioms
{
    internal class CF59_D2_A
    {
        //https://codeforces.com/contest/59/problem/A Word
        public static void sol()
        {

            string s = Console.ReadLine();
            int uppercaseCount = 0;

            foreach (char c in s)
            {
                //if (char.IsLower(c))
                //{
                //    lowercaseCount++;
                //}
                if ((90 >= c) && (c >= 65)) //Assuming ASCII
                {
                    uppercaseCount++;
                }
            }
            int lowercaseCount = s.Length - uppercaseCount;

            Console.WriteLine(uppercaseCount == lowercaseCount ? s.ToLower() : uppercaseCount > lowercaseCount ? s.ToUpper() : s.ToLower());

        }
    }
}
