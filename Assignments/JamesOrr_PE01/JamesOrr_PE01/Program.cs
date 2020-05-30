using System;
using System.Collections.Generic;

namespace JamesOrr_PE01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new dictionary to search through
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            //Creates a bool to track the serch loop
            bool endProgram = false;

            //Adds 10 new entries to the dictionary before the program runs
            dictionary.Add("catastrophe", "-noun-  an event causing great and often sudden damage or suffering; a disaster");
            dictionary.Add("deja vu", "-noun-  a feeling of having already experienced the present situation");
            dictionary.Add("snooty", "-adjective-  showing disapproval or contempt toward others, \nespecially those considered to belong to a lower social class");
            dictionary.Add("thesaurus", "-noun-  a book that lists words in groups of synonyms and related concepts");
            dictionary.Add("dream", "-verb-  to experience things during sleep; indulge in daydreams \nor fantasies about something greatly desired");
            dictionary.Add("ambiguous", "-adjective-  having more than one possible meaning");
            dictionary.Add("dwell", "-verb-  live in or at a specified place; think, speak, \nor write at length about a particular subject");
            dictionary.Add("stride", "-verb-  walk with long, decisive steps in a specified direction; \ncross (an obstacle) with one long step");
            dictionary.Add("etheral", "-adjective-  characterized by lightness and insubstantiality");
            dictionary.Add("naginata", "-noun-  a pole weapon of several varieties of traditionally made Japanese blades");

            //The start of the program
            Console.WriteLine("Welcome to the Dictionary");

            //Loop that repeats searching the dictionary until prompted to stop by typing 'EXIT'
            while (endProgram == false)
            {
                Console.Write("Enter a word to look for in the dictionary, or type EXIT to end the program : ");
                string lookFor = Console.ReadLine();

                if(dictionary.ContainsKey(lookFor) == true) //Runs if the key is in the dictioary
                {
                    Console.WriteLine();
                    Console.WriteLine(lookFor); //Types out the word again
                    Console.WriteLine(dictionary[lookFor]); //Types out the definition
                }

                if (lookFor == "EXIT")
                {
                    endProgram = true;
                }

                else //The searched word is not in the dictionary
                {
                    Console.WriteLine();
                    Console.WriteLine("The word \"" + lookFor + "\" could not be found in the dictionary. Try again.");
                }

                Console.WriteLine();
            }
        }
    }
}
