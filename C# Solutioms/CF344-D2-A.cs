using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.C__Solutioms
{
    internal class CF344_D2_A
    {
        //Magnets https://codeforces.com/contest/344/problem/A
        public void sol()
        {
            int n = int.Parse(Console.ReadLine());
            int numOfGroubs = 0;
            string lastChar = String.Empty;
            for (int i = 0; i < n; i++)
            {
                string CurrentChar = Console.ReadLine();
                if (CurrentChar != lastChar) { numOfGroubs++; }
                lastChar = CurrentChar;
            }
            Console.WriteLine(numOfGroubs.ToString());
        }
    }
}
