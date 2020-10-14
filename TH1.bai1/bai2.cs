using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH1.bai1
{
    public class Employee
    {
        private int id, yearOfBirth;
        private string name;
        private double salaryLevel, basicSalary;
        
        public int getId
        {
            get { return id; }
            set { id += 1; }
        }
        public string getName
        {
            get { return name; }
            set { name = value; }
        }
        public int getYearOfBirth
        {
            get { return yearOfBirth; }
            set { yearOfBirth = value; }
        }
        public double getIncome
        {
            get { return salaryLevel * basicSalary; }
            set { salaryLevel = setSalaryLevel; basicSalary = setBasicSalary; }
        }
        public void display()
        {
            Console.WriteLine(getId + "\t"
                + getName + "\t"
                + getYearOfBirth + "\t"
                + setBasicSalary + "\t"
                + getIncome);
        }
        public double setSalaryLevel
        {
            get { return salaryLevel; }
            set { salaryLevel = value; }
        }
        public double setBasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }
    }
}
