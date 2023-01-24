namespace PrintRightWords
{

    public class PrintRightWord
    {
        public static int printWord(List<char> guessedLetters, String randomWord)
        {
            int counter = 0;
            int rightLetters = 0;
            Console.Write("\r\n");
            foreach (char c in randomWord)
            {
                if (guessedLetters.Contains(c))
                {
                    Console.Write(c + " ");
                    rightLetters += 1;
                }
                else
                {
                    Console.Write(" ");

                }
                counter += 1;
            }
            return rightLetters;
        }
    }

}