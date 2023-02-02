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
            // Eveything is wrapped in a do while loop.

            do
            {   
                // The first section prints the game and tells the player what the game is about. 
                // It also creates a random word that is hidden from the player from the class WordGenerator.

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
                
                List<char> currentLettersGuessed = new List<char>();
                int amountOfTimesWrong = 0;
                int currentLettersRight = 0;

                

                // This is a while loop that checks how many times the player is wrong, if the player exceeds 7 wrong answers he/she loses.

                while (amountOfTimesWrong != 7 && currentLettersRight != lengthOfWordToGuess)
                {

                    // Here we print out all the guessed letters.

                    Console.Write("\nGuesses so far: ");

                    foreach (char letter in currentLettersGuessed)
                    {
                        Console.Write(letter + " ");
                    }

                    // We're asking the player to insert a radom letter.

                    Console.Write("\nGuess a letter: ");

              
                    string userInput = Console.ReadLine().ToLower();

                    // Heres an if statement that checks whether the user enters a valid character or not.
                    // If the User does enter a valid character the program carrys on to the next if satement otherwise it throws an error message. 
                    
                    if (string.IsNullOrEmpty(userInput) || userInput.Length > 1 || userInput.Any(c => !char.IsLetter(c)))
                    {
                        Intro.GameIntroduction();
                        HangManPrinter.WriteHangMan(amountOfTimesWrong);
                        currentLettersRight = PrintRightWord.printWord(currentLettersGuessed, randomWord);
                        Console.Write("\r\n");
                        SetUnderLines.PrintLines(randomWord);
                        Console.Write("\r\n");
                        Console.Write("Invalid input, try again.");
                        continue;
                    }
                    // Here we are clearing the console after each loop so it looks like the program is updating itself.

                    char letterGuessed = char.Parse(userInput);
                    Console.Clear();

                    
                    // This if statement checks if you tried to enter a letter that has aldrealy been submitted, if so it will give you an error message and update the game. 

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
                        // Heres a nested if statement that checks if you entered the correct letter and prints a supportive text message and update the game.

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

                        // Here it checks if you have entered a wrong letter and prints out a text that tells you that you lost a life and how many you have left.

                        else
                        {
                            Intro.GameIntroduction();
                            amountOfTimesWrong += 1;
                            HangManPrinter.WriteHangMan(amountOfTimesWrong);
                            currentLettersGuessed.Add(letterGuessed);
                            currentLettersRight = PrintRightWord.printWord(currentLettersGuessed, randomWord);
                            Console.Write("\r\n");
                            SetUnderLines.PrintLines(randomWord);
                            Console.Write("\r\n");
                            Console.Write($"Wrong letter, you lost a life! ||| You have {7 - amountOfTimesWrong} lives Remaining!");
                        }
                    }
                }

                // Here the program checks if the player has lost all of his/her lifes, if so it prints out GAME OVER and asks the player if they wanna play again.

                if (amountOfTimesWrong == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\nGAME OVER!!");
                    Console.ResetColor();
                    Console.WriteLine("Wanna play again? [yay | nay]");
                }

                // If the player manages to enter all the right letters they end up here and get a victory text printed out and have the option to play again.

                else
                {   
                    Console.WriteLine("\r\nYOU WON. GZ!!");
                    Console.WriteLine("Wanna play again? [yay | nay]");
                }

                // Here is wher they do while loop ends. If the player wants to play again he can enter yay to restart the program. If not you have the option to enter nay which will terminate the program. 

            } while (Console.ReadLine() != "nay");

        }

    }
}


