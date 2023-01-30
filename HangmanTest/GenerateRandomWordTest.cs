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
            //Output printer
            this.output = output;
        }
        //Here we test the method GetaWord, check that its getting different results when we runt it. 
        [Fact]
        public void GetaWordTest()
        {
            // A new instacne of the list is created.
            WordGenerator wordList = new WordGenerator();

            //A Random word is called in from WordGenerator.GetaWord.
            string randomWord = WordGenerator.GetaWord();

            //Assert checks if randomWord is in the list of words, and displays the results.
            Assert.Contains(randomWord, wordList.CreateRandomWords);
            output.WriteLine("Randomized word is: " + randomWord);


            output.WriteLine("Randomized word generated from list:");
            foreach (string item in wordList.CreateRandomWords)
            {
                output.WriteLine(item);
            }

        }
    }
}



