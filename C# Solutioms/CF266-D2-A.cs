using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.C__Solutioms
{
    internal class CF266_D2_A
    {
        public void sol()
        {
            //Stones on the Table https://codeforces.com/contest/266/problem/A
            int n = int.Parse(Console.ReadLine()); //4
            String stones = Console.ReadLine();   //BRBG
            int result = 0;
            for (int i = 0; i < n - 1; i++)
            {
                //if the color[i+1] == color[i] 
                //then result++
                //and then raise a flag to continue observing the next color
                // if they are not equal clear the flag and continue
                while (stones[i] == stones[i + 1])
                {

                    result++;
                    i++;
                    if ((n - 1) == i) break;
                }


            }
            Console.WriteLine(result.ToString());

        }
    }
}
