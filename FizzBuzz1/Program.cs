using System;

namespace FizzBuzz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //fizz if mod of 5.
            //buzz if mod of 3.
            //FizzBuzz if both are mod of 5 and 3

            for(int i = 1; i <= 100; i++)
            {
                if(i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                } else if(i % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                } else if(i % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }

              
            }
        }
    }
}
