using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;


namespace WordSpliter
{
    class FileProcessing
    {
        public static void ReadFromFile( string filePath, HashSet<string> dictionary)
        {
            using(StreamReader sr = new StreamReader(filePath))
            {
                string word;
                while ((word = sr.ReadLine()) != null)
                {
                    dictionary.Add(word.ToLower());
                }
            }
            
        }

        public static void ReadFromFile(string filePath, List<string> testWords)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string word;
                while ((word = sr.ReadLine()) != null)
                {
                    testWords.Add(word);
                }
            }

        }


    }
}


