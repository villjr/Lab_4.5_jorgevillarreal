using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_4_5_Trivia_jorgevillarreal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> scoreBoard = new List<int>();
            scoreBoard.Add(4400);
            scoreBoard.Add(8900);
            scoreBoard.Add(1200);
            scoreBoard.Add(3700);
            scoreBoard.Add(7200);

            scoreBoard.Sort();

            foreach (int s in scoreBoard)
            {
                Console.WriteLine(s);
            }

            scoreBoard.Reverse();

            foreach (int s in scoreBoard)
            {
                Console.WriteLine(s);
            }

            scoreBoard.Add(2400);

            foreach (int s in scoreBoard)
            {
                Console.WriteLine(s);
            }

            scoreBoard.Remove(4400);

            foreach (int s in scoreBoard)
            {
                Console.WriteLine(s);
            }
        }
    }
}
