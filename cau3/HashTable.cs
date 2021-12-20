using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau31
{
    public class HashTable
    {
        public ListW[] dict = new ListW[26];
        public HashTable()
        {
            for (int i = 0; i < 26; i++)
            {
                char key = (char)(i + 97);
                dict[i] = new ListW(key);
            }
        }
        public void AddToHashTable(Word w)
        {
            foreach (ListW i in dict)
            {
                if (i.key == w.GetKey())
                {
                    i.AddWord(w);
                }
            }
        }
        public void AddAWord()
        {
            Word w = Scanner.InAWord();
            this.AddToHashTable(w);
        }
        public void SearchAWord()
        {
            Word w = Scanner.InWordSearch();
            for (int i = 0; i < 26; i++)
            {
                if (dict[i].key == w.GetKey())
                {
                    dict[i].SearchNode(w);
                }
            }
        }
        public void PrintDict()
        {
            foreach (ListW i in dict)
            {
                i.PrintListW();
            }
        }
    }
}
