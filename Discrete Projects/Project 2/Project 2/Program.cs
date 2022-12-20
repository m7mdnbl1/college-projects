using System;
namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Project 2
            // write a program to find the perfect numbers between n1 to n2

            int i, j, start, end, sum;
            
            Console.WriteLine("Find the Perfect numbers within a range of numbers: \n \n");
            
            Console.Write("Input starting number of range: ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            end = int.Parse(Console.ReadLine());
            Console.Write($"The Perfect numbers between {start} and {end} are : \n \n");
            
            // Repeat from start to end
            
            for (i = start; i <= end; i++)
            {   sum = 0;
                
                // Check whether the current number i is Perfect number or not
                
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                
                // If the current number i is Perfect number print it
                
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
// Team Members:
// 1. Mohamed Nabil Refaat Elgabar
// 2. Sara Ahmed Abdelaziz Elsayed
// 3. Malak Mohamed Mohamed Soliman