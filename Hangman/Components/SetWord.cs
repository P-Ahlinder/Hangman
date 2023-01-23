using System.Collections.Generic;

namespace SetWords
{

    public class SetWord
    {
        static void GenerateWord()
        {

            Random random = new Random();
            List<string> wordList = new List<string>
    {
    "Pizza",
    "Kebabtallrik",
    "Kaffekopp",
    "Tandpetare",
    "Blomma",
    "Kyrka",
    };

            int index = random.Next(wordList.Count);
            string GenerateWord = wordList[index];

        }
    }


}



