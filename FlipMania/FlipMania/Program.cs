using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipCoins(10000);
            FlipForHeads(10000);
           
            Console.ReadKey();
        }
        /// <summary>
        /// number of flips insert
        /// </summary>
        /// <param name="numberOfFlips">how many flips to be performed</param>
        static void FlipCoins(int numberOfFlips)
        {
           int numberOfHeads = 0;
           int numberOfTails = 0;
           Random rng = new Random();
           int randomNumber = 0;
           for (int i = 0; i < numberOfFlips; i++)
            {
                randomNumber = rng.Next(0, 2);
                if (randomNumber == 0)
                {
                    numberOfHeads++;
                }
                else
                    numberOfTails++;
            }
            Console.WriteLine("We flipped a coin " + numberOfFlips + " times.");
            Console.WriteLine("Number of Heads: " + numberOfHeads);
            Console.WriteLine("Number of Tails: " + numberOfTails);
        }
       /// <summary>
       /// Flippage of a coin for a heads result
       /// </summary>
       /// <param name="numberOfHeads">heads results number</param>
        static void FlipForHeads(int numberOfHeads)
        {
          int numberOfHeadsFlipped = 0;
          int totalFlips = 0;
            
          Random rng = new Random();
          int randomNumber = 0;
           while (numberOfHeadsFlipped < numberOfHeads)
            {
                randomNumber = rng.Next(0, 2);
                if (randomNumber == 0)
                {
                    numberOfHeadsFlipped++;
                }
            totalFlips++;
            }
            
            Console.WriteLine("We are flipping a coin until we find " + numberOfHeads + " heads.");
            Console.WriteLine("It took " + totalFlips + " flips to find " + numberOfHeads + " heads.");
        }
    }
}
