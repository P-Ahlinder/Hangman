namespace Introdution
{
    internal class Intro
    {
        public static void GameIntroduction()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Hangman!!!!!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=======================");
            Console.ResetColor();
            Console.WriteLine("Game rules: ");
            Console.WriteLine("You have to guess the word below you have, you have 7 chances. Good Luck! ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=======================");
            Console.ResetColor();
            Console.WriteLine("Enter a letter from a-z");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=======================");
            Console.ResetColor();

        }
    }
}
