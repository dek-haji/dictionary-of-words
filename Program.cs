using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();
            {
                wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
                wordsAndDefinitions.Add("super", "of an extreme or excessive degree.");
                wordsAndDefinitions.Add("hammy", "characteristic of a person who overacts.");


                  Console.WriteLine(wordsAndDefinitions["Awesome"]);


              
            };
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            excitedWord.Add("word", "excited");
             excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

                dictionaryOfWords.Add(excitedWord);
            
                foreach (Dictionary<string, string> words in dictionaryOfWords)
                {
                     // Iterate the KeyValuePairs of the Dictionary
                   foreach (KeyValuePair<string, string > oneWord in words)
                   {
                    Console.WriteLine($"{oneWord.Key}; {oneWord.Value} ");
                }
                }


        }
    }
}
