using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Car
    {
        // properties
        protected int HP { get; set; }
        protected string Color { get; set; }

        // has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }

        // constructor
        public Car()
        {
            HP = 355;
            Color = "black";
        }

        // instance constructor
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        // display the details of the car
        public virtual void ShowDetails()
        {
            Console.WriteLine("The car has an estimated HP of {0} and the color {1}", HP, Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
