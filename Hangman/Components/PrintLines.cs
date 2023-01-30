namespace PrintLines
{
    // This class is setting the dotted lines. "hiding" the word from the user. 
    public class SetUnderLines
    {
        public static string PrintLines(String randomWord)
        {
            Console.Write("\r");
            foreach (char c in randomWord)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write("\u0305 ");
            }
            return randomWord;
        }
    }


}