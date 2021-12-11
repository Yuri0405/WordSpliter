using System;
using System.Collections.Generic;
using System.Text;


namespace WordSpliter
{
    class WordChecking
    {
        private HashSet<string> _dictionary;
        public void setDictionary(HashSet<string> dictionary)
        {
            _dictionary = dictionary;
        }

        public List<string> parseWords(List<string> testWords)
        {
            List<string> result = new List<string>();

            foreach(string word in testWords)
            {
                result.Add(Checking(word));
            }

            return result;
        }
        //method for spliting word to simpler parts
         string Checking(string text)
        {
            string result;
            string substring;
            List<string> simpleWords = new List<string>();
            Stack<string> substrings = new Stack<string>();
            int parseCounter = 0;
            int sublenth = 0;
            do
            {
                for (int i = parseCounter; i < text.Length; i++)
                {
                    sublenth++;
                    substring = text.Substring(parseCounter, sublenth);

                   if (_dictionary.Contains(substring))
                   {
                            substrings.Push(substring);
                   }
                    
                }
                if(substrings.Count == 0)
                {
                    simpleWords.Clear();
                    simpleWords.Add(text);
                    break;
                }
                substring = substrings.Peek();
                simpleWords.Add(substring);
                substrings.Clear();
                parseCounter += substring.Length;
                sublenth = 0;
            } while (parseCounter != text.Length);

            result = PerformResultLine(text, simpleWords);
            return result;
        }
        //perform result line that will be written in file
        string PerformResultLine(string text, List<string> simpleWords)
        {
            string result;
            string outputWords = string.Join(", ",simpleWords);
            result = $"(on) {text} -> (out) {outputWords}";
            return result;
        }

    }
}
