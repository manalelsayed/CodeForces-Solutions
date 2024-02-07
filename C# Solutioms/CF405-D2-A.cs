using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.C__Solutioms
{
    internal class CF405_D2_A
    {
        public static void sol()
        {

            //https://codeforces.com/contest/405/problem/A Gravity Flip
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }


        }
    }
}
