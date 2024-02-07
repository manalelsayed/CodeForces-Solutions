using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.C__Solutioms
{
    internal class CF263_D2_A
    {
        public static void sol()
        {
            //https://codeforces.com/contest/263/problem/A  A. Beautiful Matrix
            //    <-I->
            //    - - -       
            //0 0 0 1 0 | 
            //0 0 0 0 0 | J
            //0 0 0 0 0 |
            //0 0 0 0 0
            //0 0 0 0 0

            //steps =   -J -I 4-0-3
            //0,3
            int[,] matrix = new int[5, 5];
            int i1 = 0;
            int j1 = 0;
            for (int i = 0; i < 5; i++)
            {
                var iRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = iRow[j];
                    if (iRow[j] == 1)
                    {

                        i1 = i;


                        j1 = j;


                    }
                }
            }
            Console.WriteLine(Math.Abs(2 - i1) + Math.Abs(2 - j1));


        }
    }
}
