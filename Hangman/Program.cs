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
            //Eveything is wrapped in a do while loop.
            do
            {   
                // The first section prints the game and tells the player what the game is about. 
                // It also creates a random word that is hidden from the player from the class WordGenerator

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

                // This is a while loop that checks how many times the player is wrong, if the player exceeds 7 wrong answers he/she loses.

                while (amountOfTimesWrong != 7 && currentLettersRight != lengthOfWordToGuess)
                {
                    // Here we print out all the guessed letters 

                    Console.Write("\nGuesses so far: ");

                    foreach (char letter in currentLettersGuessed)
                    {
                        Console.Write(letter + " ");
                    }

                    // We're asking the player to insert a radom letter

                    Console.Write("\nGuess a letter: ");

              
                    string userInput = Console.ReadLine();

                    // Heres an if statement that checks whether the user enters a valid character or not.
                    // If the User does enter a valid character the program carrys on to the next if satement otherwise it throws an error message. 
                    
                    if (string.IsNullOrEmpty(userInput) || userInput.Length > 1 || userInput.Any(c => !char.IsLetter(c)))
                    {
                        Intro.GameIntroduction();
                        HangManPrinter.WriteHangMan(amountOfTimesWrong);
                        currentLettersRight = PrintRightWord.printWord(currentLettersGuessed, randomWord);
                        Console.Write("\r\n");
                        SetUnderLines.PrintLines(randomWord);
                        Console.Write("\r");
                        Console.WriteLine("Invalid input, try again.");
                        continue;
                    }
                    
                    char letterGuessed = char.Parse(userInput);

                    
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\nGAME OVER!!");
                    Console.ResetColor();
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


