using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.C__Solutioms
{
    internal class CF731_D2_A
    {
        //https://codeforces.com/contest/731/problem/A Night at the Museum
        public void sol() {
            string s = Console.ReadLine();
            int rotations = 0;
            char currentStop = 'a';
            foreach (char c in s)
            {
                if ((Math.Abs(c - currentStop)) > (26 - Math.Abs(c - currentStop)))
                {
                    rotations += (26 - Math.Abs(c - currentStop));
                }
                else
                {
                    rotations += Math.Abs(c - currentStop);
                }
                currentStop = c;
            }
            Console.WriteLine(rotations.ToString());


        }
    }
}
