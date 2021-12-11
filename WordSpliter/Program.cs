using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace WordSpliter
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Enter the path to the processing file");
            string processedInputPath = Console.ReadLine();

            Console.WriteLine("Enter the path to the file to save the results");
            string processedOutputPath = Console.ReadLine();

            Console.WriteLine("Enter the path to the dictionary file");
            string dictionaryPath = Console.ReadLine();
            if (File.Exists(processedInputPath) && File.Exists(processedOutputPath)&& File.Exists(dictionaryPath)) 
            {
                HashSet<string> dictionary = new HashSet<string>();
                List<string> testWords = new List<string>();
                List<string> resultOutput = new List<string>();
                List<string> returnedCollection = new List<string>();

                returnedCollection = FileProcessing.ReadFromFile(dictionaryPath);
                foreach (string word in returnedCollection)
                {
                    dictionary.Add(word);
                }

                returnedCollection = FileProcessing.ReadFromFile(processedInputPath);
                testWords.AddRange(returnedCollection);

                WordChecking wordChecking = new WordChecking();
                wordChecking.setDictionary(dictionary);
                resultOutput = wordChecking.parseWords(testWords);

                WordWriter wordWriter = new WordWriter();

                wordWriter.SetSource(processedOutputPath);

                foreach (string line in resultOutput)
                {
                    wordWriter.Write(line);
                }

                Console.WriteLine("Done");
                wordWriter.TearDown();
            }
            else
            {
                Console.WriteLine("Invalid filepath. Please check entered data");
            }
        }
    }
}
