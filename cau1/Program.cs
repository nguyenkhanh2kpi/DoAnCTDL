using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau1
{
    public class Program
    {
        public static void Clear()
        {
            Console.WriteLine("\nEnter any key to continue");
            Console.ReadLine();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            Employee e1 = new Employee("Dang Dinh Sang", 1, 18, Sex.male, "A", 5000);
            Employee e2 = new Employee("Nguyen Van Nam", 2, 19, Sex.male, "B", 6000);
            Employee e3 = new Employee("Le Hong Nhung", 3, 23, Sex.female, "A", 15000);
            Employee e4 = new Employee("Nguyen Anh Tai", 4, 20, Sex.male, "C", 25000);
            Employee e5 = new Employee("Pham Van Hung", 5, 30, Sex.male, "A", 8000);
            Employee e6 = new Employee("Le Phuong Mai", 6, 18, Sex.female, "A", 2000);
            Employee e7 = new Employee("Tran Hong Nhung", 7, 27, Sex.female, "B", 500);
            Employee e8 = new Employee("Nguyen Van Anh", 8, 21, Sex.female, "A", 500);

            Node n1 = new Node(e1);
            Node n2 = new Node(e2);
            Node n3 = new Node(e3);
            Node n4 = new Node(e4);
            Node n5 = new Node(e5);
            Node n6 = new Node(e6);
            Node n7 = new Node(e7);
            Node n8 = new Node(e8);

            DoubleLinkedList Dlist = new DoubleLinkedList();
            DoubleLinkedList Dlist2 = new DoubleLinkedList();
            Dlist.AddLast(n1);
            Dlist.AddLast(n2);
            Dlist.AddLast(n3);
            Dlist.AddLast(n4);
            Dlist.AddLast(n5);
            Dlist.AddLast(n6);
            Dlist.AddLast(n7);
            Dlist.AddLast(n8);
            int checkID(Node n)
            {
                Node check = new Node();
                check = Dlist.SearchNodeID(n.info.ID);
                if (check == null)
                    return 1;
                return 0;
            }
            while (true)
            {
                Console.WriteLine("\nDOUBLE LINKLIST EMPLOYEE");
                Console.WriteLine("*************************MENU*************************************");
                Console.WriteLine("**  1. Print out the existing list Employee                     **");
                Console.WriteLine("**  2. Inserst a new Node at the beginning of the list          **");
                Console.WriteLine("**  3. Inserst a new Node at the end of the list                **");
                Console.WriteLine("**  4. Inserst a node after a node of the list                  **");
                Console.WriteLine("**  5. Remove the first node of the list                        **");
                Console.WriteLine("**  6. Remove the last node of the list                         **");
                Console.WriteLine("**  7. Remove a node after a node of the list                   **");
                Console.WriteLine("**  8. Search a node in the list by ID                          **");
                Console.WriteLine("**  9. Search a node by name in the list                        **");
                Console.WriteLine("**  10.Sort the list by income(selection sort)                  **");
                Console.WriteLine("**  11.Sort the list by ID(quick sort)                          **");
                Console.WriteLine("**  12.Demo Seperate a list into two list                       **");
                Console.WriteLine("**  13.Demo Merge two list(using 2 seperate list in feature 11) **");
                Console.WriteLine("**  14.Remove nodes with income greater than 1 input            **");
                Console.WriteLine("**  0. Quit the aplication                                      **");
                Console.WriteLine("******************************************************************");
                Console.Write("Enter option: ");
                int i = 0;
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("invalid option!!");
                }
              
                switch (i)
                {
                    case 1:
                        {
                            // In ra danh sách nhân viên ban đầu
                            Console.WriteLine("\nThe original list now available is:  ");
                            Dlist.PrintList();
                            Clear();
                            break;
                        };
                    case 2:
                        {
                            // Thêm 1 Node vào vị trí đầu tiên 
                            Employee a = new Employee();
                            a.EnterEmployee();
                            Node n = new Node(a);
                            if (checkID(n) == 1)
                            {
                                Dlist.AddFirst(n);
                                Console.WriteLine("\nAfter Insert a new node at the beginning of the list : ");
                                Dlist.PrintList();
                            }
                            else
                            {
                                Console.WriteLine("The ID is Exist!!");
                            }                       
                            Clear();
                            break;
                        };
                    case 3:
                        {
                            // Thêm 1 Node vào cuối cùng
                            Employee a = new Employee();
                            a.EnterEmployee();
                            Node n = new Node(a);
                            if (checkID(n) == 1)
                            {
                                Dlist.AddLast(n);
                                Console.WriteLine("\nAfter Insert a new node at the end of the list : ");
                                Dlist.PrintList();
                            }
                            else
                            {
                                Console.WriteLine("The ID is Exist!!");
                            }
             
                            Clear();
                            break;
                        };
                    case 4:
                        {
                            // Thêm 1 Node n vào sau Node m ở trong danh sách

                            Console.WriteLine("\nAdd  Node n to after Node m of the list: ");
                            Console.WriteLine("\nPlease create a Node you want to add: ");
                            Employee a = new Employee();
                            a.EnterEmployee();
                            Node n = new Node(a);
                            if (checkID(n) == 1 && n.IsEmptyNode()==0)
                            {
                                try
                                {
                                    Console.WriteLine("\nPlease Enter the ID you want to 'AddAfter'  : ");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    Node m = new Node();
                                    m = Dlist.SearchNodeID(id);
                                    if (m == null)
                                    {
                                        Console.WriteLine("Can't find your id you Enter!!! ");
                                    }
                                    else
                                    {
                                        Dlist.AddAfter(n, m);
                                        Console.WriteLine("\n After Add 1 Node n to after Node m in list: ");
                                        Dlist.PrintList();
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("invalid option");       
                                }
                            }
                            else
                            {
                                Console.WriteLine("Can't add a node: ID already exists or you just entered a invalid name!!");
                            }
                            Clear();
                            break;
                        };
                    case 5:
                        {
                            // Xóa Node đầu tiên 
                            Dlist.RemoveFirst();
                            Console.WriteLine("\nAfter remove the first node of the list : ");
                            Dlist.PrintList();
                            Clear();
                            break;
                        };
                    case 6:
                        {
                            // Xóa Node cuối cùng
                            Dlist.RemoveLast();
                            Console.WriteLine("\nAfter remove the last node of the list : ");
                            Dlist.PrintList();
                            Clear();
                            break;

                        };
                    case 7:
                        {
                            // Xóa Node sau Node 4
                            Console.WriteLine("\nRemove Node n to after Node m in list: ");
                            Console.WriteLine("\nPlease Enter the ID you want to 'Remove After'  : ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Node m = new Node();
                            m = Dlist.SearchNodeID(id);
                            if (m == null)
                            {
                                Console.WriteLine("Can't find your id you Enter!!! ");
                            }
                            else
                            {
                                Dlist.RemoveNodeAfter(m);
                                Console.WriteLine("\n After Remove Node after Node m in list: ");
                                Dlist.PrintList();
                            }
                            Clear();
                            break;
                        };
                    case 8:
                        {
                            // Tìm vị trí Node 
                            Console.WriteLine("\nPlease Enter the ID you want to Search: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Node m = new Node();
                            m = Dlist.SearchNodeID(id);
                            int kq = 0;
                            if (m == null)
                            {
                                Console.WriteLine("Can't find your id you Enter!!! ");
                            }
                            else
                            {
                                kq = Dlist.SearchNode(m);
                                Console.WriteLine("\nNode position in list: {0}", kq);
                            }
                            Clear();
                            break;
                        };
                    case 9:
                        {
                            // Tìm list có Node chứa thông tin Employee có tên
                            DoubleLinkedList listnew = new DoubleLinkedList();
                            Console.WriteLine("\nPlease Enter the Employee's name you want to search ");
                            string namee = Convert.ToString(Console.ReadLine());
                            listnew = Dlist.SearchNodesName(namee);
                            listnew.PrintList();
                            Clear();
                            break;
                        };
                    case 10:
                        {
                            // Xắp Xếp Node bằng Selection Sort theo thunhap
                            Console.WriteLine("\nAfter sort the list by income: ");
                            Dlist.Selectionsort();
                            Dlist.PrintList();
                            Clear();
                            break;
                        };
                    case 11:
                        {
                            // Xắp xếp Node bằng Quick Sort theo ID
                            Console.WriteLine("\nAfter sort the list by ID : ");
                            Dlist.QuickSort();
                            Dlist.PrintList();
                            Clear();
                            break;
                        };
                    case 12:
                        {
                            //Tách 1 chuỗi thành 2 chuỗi từ vị trí n
                            Console.WriteLine("\nPlease Enter the ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Node m = new Node();
                            m = Dlist.SearchNodeID(id);

                       
                            Dlist2 = Dlist.SeparateList(m);
                            Console.WriteLine("\nThe list after separate :");
                            Console.WriteLine("The list 1 : ");
                            Dlist.PrintList();
                            Console.WriteLine("The list 2: ");
                            Dlist2.PrintList();
                            Clear();
                            break;

                        };
                    case 13:
                        {
                            // Trả về 1 danh sách được ghép từ 2 danh sách a,b
                            DoubleLinkedList fList = new DoubleLinkedList();
                            Console.WriteLine("\nThe list after merge: ");
                            fList.Merge2List(Dlist, Dlist2);
                            fList.PrintList();
                            Clear();
                            break;
                        }
                    case 14:
                        {
                            Console.WriteLine("Please enter 1 number, the application will eliminate employees with higher income ");
                            int j = Convert.ToInt32(Console.ReadLine());
                            Dlist.RemoveNodeThuNhapLonHonN(j);
                            Dlist.PrintList();
                            Clear();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("You are exiting the Application, Enter any key to Exit");
                            Clear();
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Option!!!");
                            Clear();
                            break;
                        }
                }
            };
            Console.ReadKey();
        }
    }
}
