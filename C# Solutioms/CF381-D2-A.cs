using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.C__Solutioms
{
    internal class CF381_D2_A
    {
        //Sereja and Dima  https://codeforces.com/contest/381/problem/A
        public void sol() {
            int n = int.Parse(Console.ReadLine());
            List<int> Cards = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int Sereja = 0;
            int Dema = 0;

            for (int i = 0; i < n; i++)
            {
                //Dema's
                if (i % 2 != 0)
                {
                    if (Cards.Last() > Cards.First())
                    {
                        Dema += Cards.Last();
                        Cards.Remove(Cards[Cards.Count - 1]);
                    }
                    else
                    {
                        Dema += Cards.First();
                        Cards.Remove(Cards[0]);

                    }
                }
                //Sereja
                else
                {

                    if (Cards.Last() > Cards.First())
                    {
                        Sereja += Cards.Last();
                        Cards.Remove(Cards[Cards.Count - 1]);
                    }
                    else
                    {
                        Sereja += Cards.First();
                        Cards.Remove(Cards[0]);
                    }
                }
            }
            Console.WriteLine(Sereja.ToString() + " " + Dema.ToString());
        }
    }
}
