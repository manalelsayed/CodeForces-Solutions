using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.C__Solutioms
{
    internal class CF431_D2_A
    {
        //Black Square https://codeforces.com/contest/431/problem/A
        public void sol()
        {
            int[] stripsCalories = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] sequence = Console.ReadLine().Select(c => int.Parse(c.ToString())).ToArray();
            int totalCalories = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                int calory = sequence[i];
                totalCalories += stripsCalories[calory - 1];
            }
            Console.WriteLine(totalCalories);
        }
    }
}
