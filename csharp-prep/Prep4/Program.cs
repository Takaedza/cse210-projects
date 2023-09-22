using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers =new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        int stop = 0;

        while (number != stop)
        {
            Console.Write("Enter number ");
            number = int.Parse(Console.ReadLine());

            if (stop != number)
            {
                numbers.Add(number);
            }

            else
            {
                Console.WriteLine(numbers.Count);
                
                Console.WriteLine("The sum is:" + " " + numbers.Sum());
                Console.WriteLine("The average is:" + " " + numbers.Average());
                Console.WriteLine("The largest number is:" + " " + numbers.Max());
                Console.WriteLine("The smallest positive number is" + " " + numbers.Min());
                numbers.Sort();
                Console.WriteLine("The sorted list is:");
                foreach (int n in numbers)
                Console.WriteLine(n);
            }

        } 

    }
}