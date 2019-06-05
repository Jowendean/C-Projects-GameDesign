using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDemo
{
    class Trainees:Employee
    {
        // properties
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }

        // default constructor from Employee class
        public Trainees() { }

        // instance constructor
        public Trainees(string lastName, string firstName, int salary, int workingHours, int schoolHours)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Salary = salary;
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("Trainee: {0}, {1} has trained at school for {2} hours",LastName,FirstName,SchoolHours);
        }

        public  override void Work()
        {
            Console.WriteLine("Trainee: {0}, {1} has worked for {2} hours per work day for a {3} salary.",LastName,FirstName,WorkingHours,Salary);
        }


    }
}
