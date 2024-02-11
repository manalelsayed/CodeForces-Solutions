using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.C__Solutioms
{
    internal class CF427_D2_A
    {
        //https://codeforces.com/contest/427/problem/A Police Recruits
        public void sol()
        {
            int numberOfEvents = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int numOfAvailableOfficers = 0;
            int unSolvedCrimes = 0;


            for (int i = 0; i < numberOfEvents; i++)
            {

                if (arr[i] > 0)
                {
                    numOfAvailableOfficers += arr[i];
                }
                else
                {
                    if (numOfAvailableOfficers > 0)
                    {
                        numOfAvailableOfficers--;
                    }
                    else
                    {
                        unSolvedCrimes++;
                    }
                }

            }
            Console.WriteLine(unSolvedCrimes.ToString());
        }
    }
}
