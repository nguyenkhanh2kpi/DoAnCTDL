using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau31
{
    public class ListW
    {
        public Node head { get; set; }
        public Node tail { get; set; }
        public char key { get; set; }
        public ListW(char key)
        {
            this.head = this.tail = null;
            this.key = key;
        }
        public void AddWord(Word a)
        {
            Node n = new Node(a);
            if (this.head == null)
            {
                this.head = this.tail = n;
            }
            else
            {
                this.tail.next = n;
                this.tail = this.tail.next;
            }
        }
        public void SearchNode(Word t)
        {
            Word w = new Word();
            Node p = this.head;
            while (p != null)
            {
                if (p.info.word == t.word)
                {
                    Console.WriteLine("_____find Vietnamese meaning____ ");
                    p.info.PrintWord();
                    return;
                }
                p = p.next;
            }
            Console.WriteLine("can't find this word!");
        }
        public void PrintListW()
        {
            Console.WriteLine("Begin by: "+ key);
            Node p = head;
            while (p != null)
            {
                p.info.PrintWord();
                p = p.next;
            }
        }
    }
}
