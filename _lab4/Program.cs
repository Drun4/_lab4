using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _lab4
{
    class Program
    {
        static void menu()
        {
            Console.WriteLine("\n1)Show Vocabulary");
            Console.WriteLine("2)Translate the word");
            Console.WriteLine("3)Add or Remove word");
            Console.WriteLine("4)Translation list");
            Console.WriteLine("5)Random word");
        }


        static void Main(string[] args)
        {
            var vocabulary = new Dictionary<string, string>()
            {
                { "Tree", "Drzewo" },
                { "Sun", "Slonce" },
                { "Cat", "Kot" },
                { "Dog", "Pies" },
                { "Moon", "Ksierzyc" },

                { "Table", "Stol" },
                { "Chair", "Krzeslo" },
                { "Phone", "Telefon" },
                { "Flower", "Kwiat" },
                { "Rain", "Deszcz" },

                { "Box", "Skrzynka" },
                { "Star", "Gwiazda" },
                { "Ball", "Pilka" },
                { "House", "Dom" },
                { "Street", "Ulica" },
            };

            int option;
            int choice;
            List<string> history_list = new List<string>();
            Random rnd = new Random();
            menu();
            do
            {
                Console.Write("\nChoose an option \n#");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nHow to output words?");
                        Console.WriteLine("1.English => Polish");
                        Console.Write("2.Polish => English\n#");
                        List<string> sorted_words = new List<string>();
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                foreach (var word in vocabulary)
                                {
                                    sorted_words.Add(word.Key);
                                }
                                sorted_words.Sort();
                                foreach (var word1 in sorted_words)
                                {
                                    foreach (var word2 in vocabulary)
                                    {
                                        if (word1 == word2.Key)
                                            Console.WriteLine(word1 + "  -  " + word2.Value);
                                    }
                                }
                                break;
                            case 2:
                                foreach (var word in vocabulary)
                                {
                                    sorted_words.Add(word.Value);
                                }
                                sorted_words.Sort();
                                foreach (var word1 in sorted_words)
                                {
                                    foreach (var word2 in vocabulary)
                                    {
                                        if (word1 == word2.Value)
                                            Console.WriteLine(word1 + "  -  " + word2.Key);
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Choose 1 or 2!");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nChoose a translation method");
                        Console.WriteLine("1.English => Polish");
                        Console.Write("2.Polish => English\n#");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("\nEnter the word in English");
                                string _word1 = Console.ReadLine();
                                foreach (var word in vocabulary)
                                {
                                    if (word.Key == _word1)
                                    {
                                        Console.Write("Translation: " + word.Value);
                                        history_list.Add(word.Key);
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("Enter the word in Polish");
                                string _word2 = Console.ReadLine();
                                foreach (var word in vocabulary)
                                {
                                    if (word.Value == _word2)
                                    {
                                        Console.Write("Translation: " + word.Key);
                                        history_list.Add(word.Value);
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Choose 1 or 2!");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nChoose an action");
                        Console.WriteLine("1.Add");
                        Console.Write("2.Remove\n#");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("\nEnter the word in English");
                                string _word1 = Console.ReadLine();
                                Console.WriteLine("Enter the word in Polish");
                                string _word2 = Console.ReadLine();
                                vocabulary.Add(_word1, _word2);
                                break;
                            case 2:
                                Console.WriteLine("\nEnter the word in English: ");
                                string _word = Console.ReadLine();
                                foreach (var word in vocabulary)
                                {
                                    if (word.Key == _word)
                                    {
                                        vocabulary.Remove(word.Key);
                                        break;
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Choose 1 or 2!");
                                break;
                        }
                        break;
                    case 4:
                        if (history_list.Any())
                        {
                            Console.WriteLine("\nTranslation list:");
                            foreach (var word1 in history_list)
                            {
                                foreach (var word2 in vocabulary)
                                {
                                    if (word1 == word2.Key)
                                    {
                                        Console.WriteLine(word1 + "  -  " + word2.Value);
                                    }
                                    if (word1 == word2.Value)
                                    {
                                        Console.WriteLine(word1 + "  -  " + word2.Key);
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is no translations yet");
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nChoose a translation method");
                        Console.WriteLine("1.English => Polish");
                        Console.Write("2.Polish => English\n#");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice) {
                            case 1:
                                var index_vocabulary = new Dictionary<int, string>();
                                int index1 = 0;
                                foreach (var word1 in vocabulary)
                                {
                                    index1++;
                                    index_vocabulary.Add(index1, word1.Key);
                                }
                                int random1 = rnd.Next(0, index_vocabulary.Count);

                                foreach (var word1 in index_vocabulary)
                                {
                                    foreach (var word2 in vocabulary)
                                    {
                                        if (random1 == word1.Key && (word1.Value == word2.Key))
                                        {
                                            Console.WriteLine(word1.Value + "  -  " + word2.Value);
                                        }
                                    }
                                }
                                break;
                            case 2:
                                var index_vocabulary2 = new Dictionary<int, string>();
                                int index2 = 0;
                                foreach (var word1 in vocabulary)
                                {
                                    index2++;
                                    index_vocabulary2.Add(index2, word1.Value);
                                }
                                int random2 = rnd.Next(0, index_vocabulary2.Count);
                                foreach (var word1 in index_vocabulary2)
                                {
                                    foreach (var word2 in vocabulary)
                                    {
                                        if (random2 == word1.Key && (word1.Value == word2.Value))
                                        {
                                            Console.WriteLine(word1.Value + "  -  " + word2.Key);
                                        }
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Choose 1 or 2!");
                                break;
                        }
                        break;
                }
            } while (option != 0);
        }
    }
}
