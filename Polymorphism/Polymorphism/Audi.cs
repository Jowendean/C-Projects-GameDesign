using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Audi:Car
    {
        // member
        private string Brand = "Audi";

        // property 
        private string Model { get; set; }

        // base constructor
        public Audi() { }

        // instance constructor
        public Audi(int hp, string color, string model):base(hp,color)
        {
            this.Model = model;
        }

        // display the details of the car
        public override void ShowDetails()
        {
            Console.WriteLine("The {0} {1} has an estimated HP of {2} and the color {3}",Brand,Model, HP, Color);
        }

        public override void Repair()
        {
            Console.WriteLine("The {0} {1} was repaired!",Brand,Model);
        }
    }
}
