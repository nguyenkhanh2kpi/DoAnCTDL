using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau31
{
    public class Node
    {
        public Word info { get; set; }
        public Node next { get; set; }
        public Node(Word w)
        {
            this.info = w;
            this.next = null;
        }
    }
}
