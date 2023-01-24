namespace GenerateRandomWord
{
    public class WordGenerator
    {
        public static string GetaWord()
        {
            Random random = new Random();
            List<string> wordDictionay = new List<string>
                {
                "Pizza",
                "Kebabtallrik",
                "Kaffekopp",
                "Tandpetare",
                "Blomma",
                "Kyrka",
                };
            int index = random.Next(wordDictionay.Count);
            String randomWord = wordDictionay[index];

            return randomWord;
        }
    }
}