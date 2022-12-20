using System;
namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //project 1
            // Write a C# program to find the prime numbers from n1 to n2
            // prime ==>  n%n = 0 && n%1 = 0    only

            int num, i, m, start, end;
            
            Console.WriteLine("\n Find the prime numbers within a range of numbers:\n");
            
            Console.Write("Input starting number of range: ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            end = int.Parse(Console.ReadLine());
            Console.Write($"The prime numbers between {start} and {end} are : \n \n");
            
            // Repeat from start to end 

            for (num = start; num <= end; num++)
            {
                m = 0;

                // Check whether the current number i is Prime number or not 

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        m++;
                        break;
                    }
                }

                if (m == 0 && num != 1)
                    Console.WriteLine("{0} ", num);
            }
            Console.ReadLine();
        }
    }
}
// Team Members:
// 1. Mohamed Nabil Refaat Elgabar
// 2. Sara Ahmed Abdelaziz Elsayed
// 3. Malak Mohamed Mohamed Soliman