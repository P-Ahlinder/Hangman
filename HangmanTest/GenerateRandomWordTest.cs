using Xunit;
using Xunit.Abstractions;
using GenerateRandomWord;

namespace GenerateRandomWordTest
{

    public class GenerateRandomTestClass
    {
        private readonly ITestOutputHelper output;
        public GenerateRandomTestClass(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void GetaWordTest()
        {
            WordGenerator wordGenerator = new WordGenerator();

            string randomWord = WordGenerator.GetaWord();

            Assert.Contains(randomWord, wordGenerator.CreateRandomWords);
            output.WriteLine("Randomized word is: " + randomWord);


            output.WriteLine("Randomized word generated from array:");

             foreach (string item in wordGenerator.CreateRandomWords)
             {
                output.WriteLine(item);
             }

        }
    }
}



