using Xunit;
using Xunit.Abstractions;


namespace PrintRightWord
{
    public class PrintRightWordTest
    {
        // The inputTester contains both valid and invalid input.
        public class InputTester
        {
            public List<char> TestLetters { get; set; }

            public InputTester()
            {
                TestLetters = new List<char>()
                {
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '#', '&', '¤','/','!','(','?','%'
                };

            }
        }
           
        private readonly ITestOutputHelper output;
        public PrintRightWordTest(ITestOutputHelper output)
        {
            this.output = output;
        }
            //This test is for handling user input. 
            [Fact]
            public void PrintWordTest()
            {
                // We generate a random characher from the list above.
                InputTester RandomLetter = new InputTester();
                Random random = new Random();

                int index = random.Next(RandomLetter.TestLetters.Count);
                char randomInput = RandomLetter.TestLetters[index];
                // We have to parse it to a string so we can validate the input from the user.
                string ParsedRandomInput = randomInput.ToString();

                //We only allow input from a-z, everything else should throw and error message.
            if (string.IsNullOrEmpty(ParsedRandomInput) || ParsedRandomInput.Length > 1 || ParsedRandomInput.Any(c => !char.IsLetter(c)))
            {
                output.WriteLine("This is not a valid input");
                output.WriteLine(ParsedRandomInput);
            }
            else
            {   
                //If the input is valid we parse it back into a char.
                char letterGuessed = char.Parse(ParsedRandomInput);
                output.WriteLine("This letter is a valid input");
                output.WriteLine(letterGuessed.ToString());
                
            }  
        }
    }
}
