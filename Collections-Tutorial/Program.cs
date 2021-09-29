using System;
using System.Collections.Generic;

namespace Collections_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //var listOfNumbers = new List<int>();  //syntax to establish list
            //listOfNumbers.Add(56);
            //listOfNumbers.Add(13);
            //listOfNumbers.Add(72);
            //listOfNumbers.Add(42);
            //listOfNumbers.Add(44);
            //listOfNumbers.Add(98);
            //listOfNumbers.Add(7);

            //var sum = 0;
            //foreach (var n in listOfNumbers)   // foreach() is the best way to iterate through the list
            //{
            //    sum += n;                      // do not manipulate the list while iterating through
            //}
            //Console.WriteLine($"Sum is {sum}");


            var rnd = new Random();
            var BowlingScore = new List<int>();
            var final = 0;
            for (var idx = 0; idx < 10; idx++)
            {
                var number = rnd.Next(0, 31);
                BowlingScore.Add(number);
            }
            foreach(var score in BowlingScore)
            {
                final += score;
            }
            Console.WriteLine($"Score is {final}");
        }
    }
}
