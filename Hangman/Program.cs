using PrintLines;
using PrintRightWords;
using HangManWriter;
using GenerateRandomWord;
using Introdution;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {  
                Intro.GameIntroduction();
                HangManPrinter.WriteHangMan();
                Console.WriteLine();
                string randomWord = WordGenerator.GetaWord();
                foreach (char x in randomWord)
                {
                    Console.Write("_  ");
                }
                Console.Write("    <---- Secret word here");
                Console.WriteLine();
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
                    Console.Clear();


                    if (currentLettersGuessed.Contains(letterGuessed))
                    {
                        Intro.GameIntroduction();
                        HangManPrinter.WriteHangMan(amountOfTimesWrong);
                        currentLettersGuessed.Add(letterGuessed);   
                        currentLettersRight = PrintRightWord.printWord(currentLettersGuessed, randomWord);
                        Console.Write("\r\n");
                        SetUnderLines.PrintLines(randomWord);
                        Console.Write("\r\n");
                        Console.Write("You have already guessed this letter");
                       
                    }
                    else
                    {
                        bool right = false;
                        for (int i = 0; i < randomWord.Length; i++) { if (letterGuessed == randomWord[i]) { right = true; } };

                        if (right)
                        {
                            Intro.GameIntroduction();
                            HangManPrinter.WriteHangMan(amountOfTimesWrong);
                            currentLettersGuessed.Add(letterGuessed);
                            currentLettersRight = PrintRightWord.printWord(currentLettersGuessed, randomWord);
                            Console.Write("\r\n");
                            SetUnderLines.PrintLines(randomWord);
                            Console.Write("\r\n");
                            Console.Write("You were right, well done! Keep going, WeeHooo!");
                        }
                        else
                        {
                            Intro.GameIntroduction();
                            HangManPrinter.WriteHangMan(amountOfTimesWrong);
                            amountOfTimesWrong += 1;
                            currentLettersGuessed.Add(letterGuessed);
                            currentLettersRight = PrintRightWord.printWord(currentLettersGuessed, randomWord);
                            Console.Write("\r\n");
                            SetUnderLines.PrintLines(randomWord);
                            Console.Write("\r\n");
                            Console.Write($"Wrong letter, you lost a life! ||| You have {7 - amountOfTimesWrong} lives Remaining!");
                        }
                    }
                }
                if (amountOfTimesWrong == 7)
                {
                    Console.WriteLine("\r\nGAME OVER!!");
                    Console.WriteLine("Wanna play again? [yay | nay]");
                }
                else
                {
                    Console.WriteLine("\r\nYOU WON. GZ!!");
                    Console.WriteLine("Wanna play again? [yay | nay]");
                }

            } while (Console.ReadLine() != "nay");

        }

    }
}


