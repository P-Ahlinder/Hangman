﻿using Hangman.Components.SetWord;
namespace Hangman
{
    class Program
    {

        static void Main(string[] args)
        {

            GenereateWord();

        }


        public class DisplayMan
        {
            public void WriteHangMan(int wrong = 0)
            {
                if (wrong == 7)
                {
                    Console.WriteLine(" +------+");
                    Console.WriteLine(" |      |");
                    Console.WriteLine(" o      |");
                    Console.WriteLine("/|\\    |");
                    Console.WriteLine("/ \\    |");
                    Console.WriteLine("==========");
                }
                if (wrong == 6)
                {
                    Console.WriteLine(" +------+");
                    Console.WriteLine(" |      |");
                    Console.WriteLine(" o      |");
                    Console.WriteLine("/|\\    |");
                    Console.WriteLine("/       |");
                    Console.WriteLine("=========");
                }
                if (wrong == 5)
                {
                    Console.WriteLine(" +------+");
                    Console.WriteLine(" |      |");
                    Console.WriteLine(" o      |");
                    Console.WriteLine("/|      |");
                    Console.WriteLine("/       |");
                    Console.WriteLine("=========");
                }
                if (wrong == 4)
                {
                    Console.WriteLine(" +------+");
                    Console.WriteLine(" |      |");
                    Console.WriteLine(" o      |");
                    Console.WriteLine("/|      |");
                    Console.WriteLine("/       |");
                    Console.WriteLine("=========");
                }
                if (wrong == 3)
                {
                    Console.WriteLine("  +-----+");
                    Console.WriteLine("  |      |");
                    Console.WriteLine("  o      |");
                    Console.WriteLine("//|      |");
                    Console.WriteLine("         |");
                    Console.WriteLine("==========");
                }
                if (wrong == 2)
                {
                    Console.WriteLine("  +-----+");
                    Console.WriteLine("  |      |");
                    Console.WriteLine("  o      |");
                    Console.WriteLine("  |      |");
                    Console.WriteLine("         |");
                    Console.WriteLine("==========");
                }
                if (wrong == 1)
                {
                    Console.WriteLine("  +-----+");
                    Console.WriteLine("  |      |");
                    Console.WriteLine("  o      |");
                    Console.WriteLine("         |");
                    Console.WriteLine("         |");
                    Console.WriteLine("==========");
                }
                if (wrong == 0)
                {
                    Console.WriteLine("  +-----+");
                    Console.WriteLine("  |      |");
                    Console.WriteLine("         |");
                    Console.WriteLine("         |");
                    Console.WriteLine("         |");
                    Console.WriteLine("==========");
                }
            }

        }
    }
}

