using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau1
{
    public class Node
    {
        public Node next { get; set; }
        public Node prev { get; set; }
        public Employee info { get; set; }
        public Node(Employee i)
        {
            this.next = this.prev = null;// tạo 1 Node mới có dữ liệu
            this.info = i;
        }
        public Node()
        {
            this.next = this.prev = null;// tạo 1 Node mới rỗng
            this.info = null;
        }
        public int IsEmptyNode()
        {
            if (this.info.name == null)
                return 1;
            return 0;
        }
    }

}
