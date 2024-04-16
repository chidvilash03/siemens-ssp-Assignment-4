using System;
using System.Collections.Generic;


namespace Dictionary
{
    //class WordsDictionary
    class WordsDictionary
    {
        //created words dictionary using collections 
        Dictionary<string, string> wordsDictionary = new Dictionary<string, string>();

        //method to add word to the dictionary
        public void AddWord()
        {
            Console.WriteLine("Enter the word to add : ");
            string word = Console.ReadLine();
            if (wordsDictionary.ContainsKey(word))
            {
                Console.WriteLine("The word already contains in the dictionary , if you want to update the meaning of the word press 1");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter the meaning of the word : ");
                    string newMeaning = Console.ReadLine();
                    if (wordsDictionary.ContainsKey(word))
                        wordsDictionary[word] = newMeaning;
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Choice!");
                    return;
                }
            }
            Console.WriteLine("Enter the meaning of the word : ");
            string meaning = Console.ReadLine();
            wordsDictionary.Add(word, meaning);
            Console.WriteLine("Word added into the dictionary successfully");
        }

        //method to display words and the corresponding meanings in the dictionary
        public void DisplayWords()
        {
            //condition to check whether the dictionary is empty or not
            if (wordsDictionary.Count == 0)
            {
                Console.WriteLine("Dictionary is Empty");
                return;
            }

            //displaying content in the dictionary
            Console.WriteLine("The words and corresponding meanings in the dictionary : ");
            foreach (var pair in wordsDictionary)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }


        }

        public void SearchMeaning()
        {
            Console.WriteLine("Enter the word for meaning : ");
            string word = Console.ReadLine();
            if (wordsDictionary.Count == 0)
            {
                Console.WriteLine("Dictionary is empty");
                return;
            }
            if (wordsDictionary.ContainsKey(word))
            {
                Console.WriteLine("Meaning of the word is : " + wordsDictionary[word]);
                return;
            }
            else
            {
                Console.WriteLine("No word in Dictionary");
            }

        }

        public void RemoveWord()
        {
            if (wordsDictionary.Count == 0)
            {
                Console.WriteLine("Dictionary is empty");
                return;
            }
            Console.WriteLine("The words in the dictionary : ");
            DisplayWords();
            Console.WriteLine("\n");
            Console.WriteLine("Enter the word in the dictionary to be removed : ");
            string word = Console.ReadLine();
            wordsDictionary.Remove(word);
            Console.WriteLine("Word removed from the dictionary successfully ");
            DisplayWords();

        }

    }
}
