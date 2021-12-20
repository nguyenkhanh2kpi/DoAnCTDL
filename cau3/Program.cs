using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau31
{
    class Program
    {
        static HashTable dictionary = new HashTable();
        public static void Clear()
        {
            Console.WriteLine("\nEnter any key to continue");
            Console.ReadLine();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            dictionary = Scanner.InALibDict();
            while (true)
            {
                Console.WriteLine("*****************************Dictionary***************************");
                Console.WriteLine("******************************************************************");
                Console.WriteLine("**  1. Print the dictionary                                     **");
                Console.WriteLine("**  2. Add a new word to the dictionary                         **");
                Console.WriteLine("**  3. Search a word in dictionary                              **");
                Console.WriteLine("**  0. Exit dictionary                                          **");
                Console.WriteLine("******************************************************************");
                Console.Write("Enter option: ");
                try
                {
                    int i = Convert.ToInt32(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            {
                                dictionary.PrintDict();
                                Clear();
                                break;
                            };
                        case 2:
                            {
                                dictionary.AddAWord();
                                Clear();
                                break;
                            };
                        case 3:
                            {
                                dictionary.SearchAWord();
                                Clear();
                                break;
                            };
                        case 0:
                            {
                                Console.WriteLine("Exit the dictionary");
                                Clear();
                                return;
                            }
                        default:
                            {
                                Console.WriteLine("invalid option! Exit the dictionary");
                                Clear();
                                return;
                            };
                    };
                }
                catch
                {
                    Console.WriteLine("invalid option!!");
                }
                Console.ReadKey();
            }
        }
    }
}
