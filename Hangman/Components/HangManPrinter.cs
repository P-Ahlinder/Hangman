namespace HangManWriter
{
    //The printer class is made for showing which state the user is in. The output is determined by the wrong variable.
    public class HangManPrinter
    {
        public static void WriteHangMan(int wrong = 0)
        {

            if (wrong == 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  +------+");
                Console.WriteLine("  |      |");
                Console.WriteLine("  o      |");
                Console.WriteLine(" /|\\     |");
                Console.WriteLine(" / \\     |");
                Console.WriteLine("==========");
                Console.ResetColor();
            }
            if (wrong == 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  +------+");
                Console.WriteLine("  |      |");
                Console.WriteLine("  o      |");
                Console.WriteLine(" /|\\     |");
                Console.WriteLine(" / \\     |");
                Console.WriteLine("==========");
                Console.ResetColor();
            }
            if (wrong == 5)
            {
                Console.WriteLine("  +------+");
                Console.WriteLine("  |      |");
                Console.WriteLine("  o      |");
                Console.WriteLine(" /|      |");
                Console.WriteLine(" / \\     |");
                Console.WriteLine("==========");
            }
            if (wrong == 4)
            {
                Console.WriteLine("  +------+");
                Console.WriteLine("  |      |");
                Console.WriteLine("  o      |");
                Console.WriteLine(" /|      |");
                Console.WriteLine(" /       |");
                Console.WriteLine("==========");
            }
            if (wrong == 3)
            {
                Console.WriteLine("  +------+");
                Console.WriteLine("  |      |");
                Console.WriteLine("  o      |");
                Console.WriteLine(" /|      |");
                Console.WriteLine("         |");
                Console.WriteLine("==========");
            }
            if (wrong == 2)
            {
                Console.WriteLine("  +------+");
                Console.WriteLine("  |      |");
                Console.WriteLine("  o      |");
                Console.WriteLine("  |      |");
                Console.WriteLine("         |");
                Console.WriteLine("==========");
            }
            if (wrong == 1)
            {
                Console.WriteLine("  +------+");
                Console.WriteLine("  |      |");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("==========");
            }
            if (wrong == 0)
            {
                Console.WriteLine("  +------+");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("==========");
            }
        }
    }
}
