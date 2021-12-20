using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau31
{
    public class Word
    {
        public string word { get; set; }
        public string type { get; set; }
        public string mean { get; set; }

        public Word(string w, string t, string m)
        {
            this.word = w;
            this.type = t;
            this.mean = m;
        }
        public Word()
        {

        }
        public void PrintWord()
        {
            Console.WriteLine(this.word + ":" + this.mean + "(" + this.type + ")");
        }
        public char GetKey()
        {
            try
            {
                return word[0];
            }
            catch
            {
                return ' ';
            }
          
        }
    }
}
