
namespace Hangman
{
    class Program
    {

        private static int printWord(List<char> guessedLetters, String RandomWord)
        {
            int guesses = 0;
            int rightGuesses = 0;
            Console.Write("\r\n");
            foreach (char c in RandomWord)
            {
                if (guessedLetters.Contains(c))
                {
                    Console.Write(c + " ");
                    rightGuesses++;
                }
                else
                {
                    Console.Write(" ");

                }
                guesses++;
            }
            return rightGuesses;

        }

        private static void printLines(String randomWord)
        {
            Console.Write("\r");
            foreach (char c in randomWord)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write("\u0305");
            }
        }


        static void WriteHangMan(int wrong)
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






        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman!!!!!");
            Console.WriteLine("=======================");

            Random random = new Random();
            List<string> wordList = new List<string>
                {
                "Pizza",
                "Kebabtallrik",
                "Kaffekopp",
                "Tandpetare",
                "Blomma",
                "Kyrka",
                };
            int index = random.Next(wordList.Count);
            string RandomWord = wordList[index];

            foreach (char x in RandomWord)
            {
                Console.WriteLine("___ ");
            }

            int wordLenght = RandomWord.Length;
            int wrongGuess = 0;
            int rightGuess = 0;
            List<char> currentGuesses = new List<char>();

            while (wrongGuess != 7 && rightGuess != wordLenght)
            {
                Console.WriteLine("\nGuesses so far: ");
                foreach (char letter in currentGuesses)
                {
                    Console.WriteLine(letter + " ");
                }
                Console.Write("\nGuess a letter: ");
                char guessedLetters = Console.ReadLine()[0];

                if (currentGuesses.Contains(guessedLetters))
                {

                    Console.WriteLine("\r\nYou have already guessed this letter..");
                    WriteHangMan(wrongGuess);
                    rightGuess = printWord(currentGuesses, RandomWord);
                    printLines(RandomWord);
                }
                else
                {
                    bool right = false;
                    for (int i = 0; i < RandomWord.Length; i++)
                    {
                        if (guessedLetters == RandomWord[i]) { right = true; }

                        if (right)
                        {
                            WriteHangMan(wrongGuess);
                            currentGuesses.Add(guessedLetters);
                            rightGuess = printWord(currentGuesses, RandomWord);
                            printLines(RandomWord);
                        }
                        else
                        {
                            wrongGuess++;
                            currentGuesses.Add(guessedLetters);
                            WriteHangMan(wrongGuess);
                            rightGuess = printWord(currentGuesses, RandomWord);
                            printLines(RandomWord);
                        }
                    }
                }


            }


        }
    }
}

