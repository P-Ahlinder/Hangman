namespace GenerateRandomWord
{
    // Created a class for throwing a random word for the user to guess. 
    public class WordGenerator
    {
        public List<string> CreateRandomWords { get; set; }

       public WordGenerator() 
        { 
            CreateRandomWords = new List<string>()
            {
                "pizza",
                "kebab",
                "paperplane",
                "arrow",
                "appel",
                "abandon",
                "firealarm",
            };
        }
       
        public static string GetaWord()
        {
            // Generates a new instance of the list, randomizes one word by index number and saves it to randomWord.
            WordGenerator wordList = new WordGenerator();
            Random random = new Random();

            int index = random.Next(wordList.CreateRandomWords.Count);
            String randomWord = wordList.CreateRandomWords[index];

            return randomWord;
        }
    }
}