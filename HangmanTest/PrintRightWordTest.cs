using Xunit;
using Xunit.Abstractions;


namespace PrintRightWord
{
    public class PrintRightWordTest
    {
        
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

            [Fact]
            public void PrintWordTest()
            {
                InputTester RandomLetter = new InputTester();

                Random random = new Random();

                int index = random.Next(RandomLetter.TestLetters.Count);
                char randomInput = RandomLetter.TestLetters[index];

                string ParsedRandomInput = randomInput.ToString();

            if (string.IsNullOrEmpty(ParsedRandomInput) || ParsedRandomInput.Length > 1 || ParsedRandomInput.Any(c => !char.IsLetter(c)))
            {
                output.WriteLine("This is not a valid input");
                output.WriteLine(ParsedRandomInput);
            }
            else
            {
                char letterGuessed = char.Parse(ParsedRandomInput);
                output.WriteLine("This letter is a valid input");
                output.WriteLine(letterGuessed.ToString());
                
            }  
        }
    }
}
