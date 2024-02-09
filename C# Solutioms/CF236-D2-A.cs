using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.C__Solutioms
{
    internal class CF236_D2_A
    {
        //https://codeforces.com/contest/236/problem/A Boy Or Girl
        public static void sol()
        {
            string s = Console.ReadLine();
            HashSet<char> distinctChars = new HashSet<char>(s);
            Console.WriteLine((distinctChars.Count % 2 != 0) ? "IGNORE HIM!" : "CHAT WITH HER!");

        }

    }
}
