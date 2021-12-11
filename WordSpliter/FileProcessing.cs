using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;


namespace WordSpliter
{
    class FileProcessing
    {
        public static List<string> ReadFromFile(string filePath)
        {
            List<string> collection = new List<string>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                string word;
                while ((word = sr.ReadLine()) != null)
                {
                    collection.Add(word.ToLower());
                }
            }
            return collection;
        }
    }
}


