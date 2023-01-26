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
            string[] result = { "pizza", "kebab", "paperplane", "arrow", "abandon", "firealarm" };
            string randomWord = WordGenerator.GetaWord();

            Assert.Contains(randomWord, result);
            output.WriteLine("Randomized word is: " + randomWord);


            output.WriteLine("Randomized word generated from array:");
            foreach (var item in result)
            {
               output.WriteLine(item);
            }
        }
    }
}



