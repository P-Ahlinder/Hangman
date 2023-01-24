using PrintRandomWords;
using PrintRightWords;
using HangManWriter;
using GenerateRandomWord;
namespace Hangman
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman!!!!!");
            Console.WriteLine("=======================");

            string randomWord = WordGenerator.GetaWord();
            foreach (char x in randomWord)
            {
                Console.Write("_ ");
            }

            int lengthOfWordToGuess = randomWord.Length;
            int amountOfTimesWrong = 0;
            List<char> currentLettersGuessed = new List<char>();
            int currentLettersRight = 0;


            while (amountOfTimesWrong != 7 && currentLettersRight != lengthOfWordToGuess)
            {
                Console.Write("\nGuesses so far: ");
                foreach (char letter in currentLettersGuessed)
                {
                    Console.Write(letter + " ");
                }
                Console.Write("\nGuess a letter: ");
                char letterGuessed = Console.ReadLine()[0];

                if (currentLettersGuessed.Contains(letterGuessed))
                {
                    Console.Write("\r\n You have already guessed this letter");
                    HangManPrinter.WriteHangMan(amountOfTimesWrong);
                    currentLettersRight = PrintRightWord.printWord(currentLettersGuessed, randomWord);
                    PrintRandomWord.printLines(randomWord);
                }
                else
                {
                    bool right = false;
                    for (int i = 0; i < randomWord.Length; i++) { if (letterGuessed == randomWord[i]) { right = true; } };

                    if (right)
                    {
                        HangManPrinter.WriteHangMan(amountOfTimesWrong);
                        currentLettersGuessed.Add(letterGuessed);
                        currentLettersRight = PrintRightWord.printWord(currentLettersGuessed, randomWord);
                        Console.Write("\r\n");
                        PrintRandomWord.printLines(randomWord);

                    }
                    else
                    {
                        amountOfTimesWrong += 1;
                        currentLettersGuessed.Add(letterGuessed);
                        HangManPrinter.WriteHangMan(amountOfTimesWrong);
                        currentLettersRight = PrintRightWord.printWord(currentLettersGuessed, randomWord);
                        Console.Write("\r\n");
                        PrintRandomWord.printLines(randomWord);
                        Console.Write("\r\n");
                        Console.WriteLine("Wrong letter try again!");
                    }
                }
            }
            Console.WriteLine("\r\n GAME OVER!!");
        }
    }
}


