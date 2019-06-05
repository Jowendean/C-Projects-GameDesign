using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    // can seal a class so it cannot be inherited
    /*sealed*/class BMW:Car
    {
        // member
        private string Brand = "BMW";

        // property
        protected string Model { get; set; }

        // base constructor
        public BMW() { }

        // instance constructor
        public BMW(int hp, string color, string model):base(hp, color)
        {
            this.Model = model;
        }

        // display the details of the car
        // "new" keyword gives precedence to derived class over base class
        public new void ShowDetails()
        {
            Console.WriteLine("The {0} {1} has an estimated HP of {2} and the color {3}",Brand, Model, HP, Color);
        }

        // "sealed" keyword ensures that any class derived from BMW cannot overide its Repair() method
        public /*sealed*/ override void Repair()
        {
            Console.WriteLine("The {0} {1} was repaired!",Brand,Model);
        }
    }
}
