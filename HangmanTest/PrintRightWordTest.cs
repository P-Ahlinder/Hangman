using Xunit;
using System.Text;
using Xunit.Abstractions;
using PrintRightWords;
using GenerateRandomWord;
using System.Text.RegularExpressions;

namespace PrintRightWord
{
    public class PrintRightWordTest
    {

        private readonly ITestOutputHelper output;
        public PrintRightWordTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void PrintWordTest()
        {
            string randomWord = WordGenerator.GetaWord();

            string guessedLetter = "a";

            Console.WriteLine(Regex.IsMatch(guessedLetter, @"^[a-zA-Z]+$"));

            


            Assert.Contains(guessedLetter, randomWord);

            output.WriteLine(randomWord);
            output.WriteLine(guessedLetter); ;
        }
    }
}
