using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH1.bai1
{
    class Employee
    {
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;
        private double basicSalary;
        public void getId()
        {
            Console.WriteLine("Dinh danh nguoi lao dong : ", id);
        }
        public void getName()
        {
            Console.WriteLine("Ten cua nguoi lao dong : ", name);
        }
        public void getYearOfBirth()
        {
            Console.WriteLine("Nam sinh nguoi lao dong :", yearOfBirth);
        }
        public double getIncome()
        {
            double thunhap = salaryLevel * basicSalary;
            return thunhap;
        }
        public void Hienthi()
        {
            Console.WriteLine("Dinh danh :"+id+"\t"+"Ten :"+name+"\t"+"Nam sinh:"+yearOfBirth+"\t"+"Luong co ban :"+basicSalary+"\t"+"Thu nhap:"+getIncome());
        }
        public double setSalaryLevel
        {
            get
            {
                return salaryLevel;
            }
            set
            {
                salaryLevel = value;
            }
        }
        public double setBasicSalary
        {
            get
            {
                return basicSalary;
            }
            set
            {
                basicSalary = value;
            }
        }
        static void Main()
        {

        }
    }
}
