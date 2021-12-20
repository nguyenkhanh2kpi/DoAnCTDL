using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau1
{
    public enum Sex { male, female }
    public class Employee
    {
        public string name { get; set; }
        public int ID { get; set; }
        public int age { get; set; }
        public Sex sex { get; set; }
        public String companyDepartment { get; set; }
        public int income { get; set; }
        public Employee()
        {

        }

        public Employee(string ten, int ID, int age, Sex s, String cty, int tn)
        {
            this.name = ten;
            this.ID = ID;
            this.age = age;
            this.sex = s;
            this.companyDepartment = cty;
            this.income = tn;
        }
        public Employee(Employee i)
        {
            this.name = i.name;
            this.ID = i.ID;
            this.age = i.age;
            this.sex = i.sex;
            this.companyDepartment = i.companyDepartment;
            this.income = i.income;
        }
        public int CompareIncome(Employee n)
        {
            if (this.income > n.income)
                return 1;
            return 0;
        }
        public int SoSanhID(Employee n)
        {
            return this.ID > n.ID ? 1 : 0;
        }
        public void Print()
        {
            Console.WriteLine(" Name: {0}\t\t\tID:{1} Age:{2}\tSex:{3}\tCompany:{4}\tIncome:{5} ",
                this.name,this.ID, this.age, this.sex, this.companyDepartment, this.income);
        }
        public void EnterEmployee()
        {
            Console.WriteLine("Enter Employee's name: ");
            string name = Convert.ToString(Console.ReadLine());
            if(name.Length== 0)
            {
                this.name = null;
                this.ID = 0;
                Console.WriteLine("Invalid name!!");
                return;
            }
            int Id = 0;
            void EnterID()
            {
                try
                {
                    Console.WriteLine("Enter Employee's ID: ");
                    Id = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    EnterID();
                }
            }
            EnterID();
            int agee = 0;
            void EnterAge()
            {
                try
                {
                    Console.WriteLine("Enter Employee's age: ");
                    agee = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    EnterAge();
                }
            }
            EnterAge();
            int n = 3;
            while(n!=1 && n!=0)
            {
                Console.WriteLine("Employee's sex: (enter 1 if male 0 if female) ");
                n = Convert.ToInt32(Console.ReadLine());
            };
        
            Console.WriteLine("Enter company department: ");
            string cmp = Convert.ToString(Console.ReadLine());
            int incomee = 0;
            void EnterIncome()
            {
                try
                {
                    Console.WriteLine("Enter Employee's income: ");
                    incomee = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    EnterIncome();
                }
            }
            EnterIncome();
            this.name = name;
            this.ID = Id;
            this.age = agee;
            this.sex = (n == 1 ? Sex.male : Sex.female);
            this.companyDepartment = cmp;
            this.income = incomee;
        }
    }
}
