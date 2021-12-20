using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau1
{
    public class DoubleLinkedList
    {
        public Node head { get; set; }
        public Node tail { get; set; }


        ///  khởi tạo 1 list
        public DoubleLinkedList()
        {
            this.head = this.tail = null;
        }

        // kiểm tra list rỗng hay không
        public int IsEmptyDBLL()
        {
            if (this.head == null)
                return 1;
            return 0;
        }

        // thêm 1 Node và đầu list
        public void AddFirst(Node n)
        {
            if (n.IsEmptyNode() == 0)
            {
                if (this.head == null)
                {
                    this.head = this.tail = n;
                }
                else
                {
                    n.next = this.head;
                    this.head.prev = n;
                    this.head = n;
                }
            }
        }

        // thêm 1 Node vào cuối list
        public void AddLast(Node n)
        {
            if (n.IsEmptyNode() == 0)
            {
                if (this.IsEmptyDBLL() == 1)
                {
                    this.head = this.tail = n;
                }
                else
                {
                    this.tail.next = n;
                    n.prev = this.tail;
                    this.tail = n;
                }
            }
        }

        // thêm Node n vào sau Node i trong list
        public void AddAfter(Node n, Node i)
        {
            if (n.IsEmptyNode() == 0)
            {
                if (i == this.tail)
                    this.AddLast(n);
                else
                {
                    n.next = i.next;
                    n.prev = i;
                    i.next.prev = n;
                    i.next = n;
                }
            }
        }

        // Xóa Node đầu tiên
        public void RemoveFirst()
        {
            if (this.IsEmptyDBLL() == 1)
            {
                Console.WriteLine("The list is Empty!");
            }
            else
            {
                Node p = this.head;
                if (this.head == this.tail)
                    this.head = this.tail = null;
                else
                {
                    this.head.next.prev = null;
                    this.head = this.head.next;
                }
            }
        }

        // Xóa Node cuối cùng
        public void RemoveLast()
        {
            if (this.IsEmptyDBLL() == 1)
            {
                Console.WriteLine("The list is empty!");
            }
            else
            {
                Node p = this.tail;
                if (this.head == this.tail)
                    this.head = this.tail = null;
                else
                {
                    Node q = this.tail.prev;
                    q.next = null;
                    this.tail = q;
                }
            }
        }

        // xóa Node phía sau i
        public void RemoveNodeAfter(Node i)
        {
            Node p = i.next;
            if (p == null)
                Console.WriteLine("Don't exist the next Node!");
            else
            {
                if (p == this.tail)
                    this.RemoveLast();
                else
                {
                    i.next = p.next;
                    p.next.prev = i;
                }
            }
        }

        // Xóa Node n
        public void RemoveNode(Node n)
        {
            if (this.head == this.tail)
                this.head = this.tail = null;
            else
            {
                if (n == this.head)
                {
                    this.RemoveFirst();
                }
                else
                {
                    if (n == this.tail)
                        this.RemoveLast();
                    else
                    {
                        Node p = n.prev;
                        this.RemoveNodeAfter(p);
                    }
                }
            }
        }

        // Tìm kiếm trả về vị trí của Node trong List
        public int SearchNode(Node n)
        {
            int q = 1;
            Node p = this.head;
            while (p != n)
            {                            
                q++;
                p = p.next;
            }
            return q;
        }
        // tìm Node theo id và trả về Node(trả về null nếu không thấy)
        public Node SearchNodeID(int id)
        {
            Node m = new Node();
            Node q = this.head;
            while(q != null)
            {
                if (q.info.ID == id)
                    m = q;
                q = q.next;
            }
            if (m.info == null)
                return null;
            return m;
        }

        // tìm kiếm Node theo tên : Node có Employee có tên ii
        public DoubleLinkedList SearchNodesName(string ii)
        {
            DoubleLinkedList r = new DoubleLinkedList();
            Node p = this.head;
            while (p != null)
            {
                if (p.info.name.Contains(ii))
                {
                    Node q = new Node();
                    q.info = p.info;
                    r.AddLast(q);
                }
                p = p.next;
            }
            return r;
        }

        // In ra list
        public void PrintList()
        {
            if (this.head == null)
            {
                Console.WriteLine("The list is empty!");
            }
            else
            {
                Console.WriteLine("List Employee: ");
                Node p = this.head;
                while (p != null)
                {
                    p.info.Print();
                    p = p.next;
                }
            }
        }

        // Xắp xếp bằng Selection Sort theo thu nhập
        public void Selectionsort()
        {
            DoubleLinkedList listReturn = new DoubleLinkedList();

            if (this.head == this.tail)
            {
                return;
            }
            while (this.head != null)
            {
                Node min = this.head;
                Node r = min.next;
                while (r != null)
                {
                    if (min.info.CompareIncome(r.info) == 1)
                    {
                        min = r;
                    }
                    r = r.next;
                }
                this.RemoveNode(min);
                listReturn.AddLast(min);
            }
            this.head = listReturn.head;
            this.tail = listReturn.tail;
        }


        // Xắp xếp bằng Quick Sort theo ID
        public void QuickSort()
        {
            DoubleLinkedList myList1 = new DoubleLinkedList();
            DoubleLinkedList myList2 = new DoubleLinkedList();
            Node pivot, p;
            if (this.head == this.tail)
                return;
            pivot = this.head;
            p = this.head.next;
            while (p != null)
            {
                Node q = p;
                p = p.next;
                q.next = null;
                q.prev = null;
                if (q.info.SoSanhID(pivot.info) == 0)
                    myList1.AddLast(q);
                else
                    myList2.AddLast(q);
            };

            myList1.QuickSort();
            myList2.QuickSort();
            if (myList1.IsEmptyDBLL() == 0)
            {
                this.head = myList1.head;
                myList1.tail.next = pivot;
                pivot.prev = myList1.tail;
            }
            else
                this.head = pivot;

            pivot.next = myList2.head;
            if (myList2.IsEmptyDBLL() == 0)
            {
                this.tail = myList2.tail;
                myList2.head.prev = pivot;
            }        
            else
                this.tail = pivot;
        }

        // Nối 2 list a, b và trả về 1 list
        public void Merge2List(DoubleLinkedList a, DoubleLinkedList b)
        {
            if (a.IsEmptyDBLL() == 1 && b.IsEmptyDBLL()==0)
            {
                this.head = b.head;
                this.tail = b.tail;
            }
            else
            {
                if(a.IsEmptyDBLL()==0 && b.IsEmptyDBLL() == 1)
                {
                    this.head = a.head;
                    this.tail = a.tail;
                }
                else
                {
                    if(a.IsEmptyDBLL()==1 && b.IsEmptyDBLL() == 1)
                    {
                        this.tail = this.head = null;
                    }
                    else
                    {
                        b.head.prev = a.tail;
                        a.tail.next = b.head;
                        this.head = a.head;
                        this.tail = b.tail;
                    }
                }
            }
        }

        //Xóa những Node trong danh sách (Node employee có thu nhập lớn hơn N)
        public void RemoveNodeThuNhapLonHonN(int n)
        {
            Node p = this.head;
            while (p != null)
            {
                if (p.info.income > n)
                {
                    this.RemoveNode(p);
                }
                p = p.next;
            }
        }

        //Tách 1 danh sách thành 2 danh sách từ vị trí n
        public DoubleLinkedList SeparateList(Node n)
        {
            DoubleLinkedList r = new DoubleLinkedList();
            if (n == this.tail || n == null)
            {
                return r;
            }
            r.head = n.next;
            r.tail = this.tail;
            this.tail = n;
            n.next = null;
            r.head.prev = null;
            return r;
        }
    }
}
