using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EmployeeDemo
{
    class Employee
    {
        // properties
        public string LastName { get; set; }
        public string FirstName { get; set; }
        protected int Salary { get; set; }

        // default constructor
        public Employee()
        {
            LastName = "Ball";
            FirstName = "Jordan";
            Salary = 60000;
        }

        // instance constructor
        public Employee(string lastName, string firstName, int salary)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("Employee: {0}, {1} is working at a ${2} salary.",LastName,FirstName,Salary);
        }

        public void Pause()
        {
            Console.WriteLine("Taking a break!");
        }

    }
}
