using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Prime numbers between 1-100
             2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, and 97  */
            // numbers is the counter
            int num1;
            int num2;
            // Calculated Prime 
            int prime;
            // Prime numbers will have 2 divisors (1 and num) anything greater than 2 is not prime
            Console.WriteLine("This program will return all prime numbers between 1 and 100)");
                // Count MODs
                for (num1 = 1; num1 <= 100; num1++)
            {
                    for (num2 = 1; num2 <= 100; num2++)
                {
                    prime = num1 % num2;
                       while (prime ==0)
                    {
                        
                    }
                }

            }


            Console.ReadKey();
        }
    }
}
