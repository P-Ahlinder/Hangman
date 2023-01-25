using Xunit;
using Xunit.Abstractions;
using PrintLines;
using GenerateRandomWord;


namespace PrintLinesTest
{ 
    public class Printer
    {
        private readonly ITestOutputHelper output;
        public Printer(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void PrintLineTest()
        {
            string randomWord = WordGenerator.GetaWord();
           
            string result = SetUnderLines.PrintLines(randomWord);

            Assert.Equal(result, randomWord);
        }
    }

}


