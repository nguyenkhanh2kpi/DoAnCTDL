using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau31
{
    public class Scanner
    {
        public static Word InWordSearch()
        {
            Word w = new Word();
            Console.WriteLine("Enter a word in English: ");
            w.word = Convert.ToString(Console.ReadLine().Trim().ToLower());
            w.type = w.mean = null;
            return w;
        }
        public static Word InAWord()
        {
            Word w = new Word();
            Console.WriteLine("Enter a word in English: ");
            w.word = Convert.ToString(Console.ReadLine().Trim().ToLower());
            Console.WriteLine("Enter it's type: ");
            w.type = Convert.ToString(Console.ReadLine().Trim().ToLower());
            Console.WriteLine("Enter it's mean in Vietnamese: ");
            w.mean = Convert.ToString(Console.ReadLine().Trim().ToLower());
            return w;
        }
        public static HashTable InALibDict()
        {
            HashTable d = new HashTable();
            string[] a = File.ReadAllLines("dict.txt");
            int i = 0;
            while(i<=(a.Length-3))
            {
                Word w = new Word();
                w.word = a[i].Trim().ToLower();
                w.type = a[i+1].Trim().ToLower();
                w.mean = a[i+2].Trim().ToLower();
                d.AddToHashTable(w);
                i += 3;
            }
            return d;
        }
    }
}
