using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDemo
{
    class Boss:Employee
    {
        // properties
        protected string CompanyCar { get; set; }
        
        // default constructor of Employee class
        public Boss() { }

        // instance constructor
        public Boss(string lastName, string firstName, int salary, string companyCar)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Salary = salary;
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("Todays Manager: {0}, {1} was seen drinving the company car ({2}) to train employees for a ${3} salary.",LastName,FirstName,CompanyCar,Salary);
        }
    }
}
