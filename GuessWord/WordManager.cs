using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessWord
{
    public class WordManager
    {
        string[] words;
        string[] translatedWords;
        Random rnd = new Random();

        public string[] ExistWords { get; private set; }
        public string Word { get; private set; }
        public string TranslatedWord { get; private set; }



        public void ImortData()
        {
            string file1 = @"data\existWords.txt";
            if (File.Exists(file1))
            {
                string str = File.ReadAllText(file1);
                ExistWords = str.Split();
            }

            string file2 = @"data\translatedWords.txt";
            if (File.Exists(file2))
            {
                string str = File.ReadAllText(file2);
                translatedWords = str.Split();
            }
            string file = @"data\words.txt";
            if (File.Exists(file))
            {
                string str = File.ReadAllText(file);
                words = str.Split();
            }
        }

        public void NewWord()
        {
            int n = rnd.Next(words.Length);
            Word = words[n];
            TranslatedWord = translatedWords[n];
        }
    }
}
