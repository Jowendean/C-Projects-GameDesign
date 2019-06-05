using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        // pre-challenge:
        // create a base class Car with two properties HP and Color (done)
        // create a constructor setting those two properties (done)
        // create a method called ShowDetails() which shows the HP and Color of the car on the console (done)
        // create a Repair() method which writes "Car was repaired!" onto the console (done)
        // create two deriving class, BMW and Audi, which have their own constructor and have an additional property (done)
        // called Model. Also a private member called brand. Brand should be different in each of the two classes. (done)
        // create the two methods ShowDetails() and Repair() in them as well. Adjust those methods accordingly (done)
        static void Main(string[] args)
        {
            // use polymorphism to create a list of cars
            // List<> is found in System.Collection.Generic namespace

            // a car can be a BMW, an Audi, a Porsche etc.
            // Polymorphism at work #1: an Audi, BMW, Porsche
            // can all be used whenever a Car is expected. No cast is
            // required because an implicit conversion exists from a derived
            // class to its base class
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            // Polymorphism at work #2: the virtual method Repair is
            // invoked on each of the derived classes, not the base class
            foreach(var car in cars)
            {
                car.Repair();
            }

            // show the "new" showDetails() method from derived BMW class
            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails();

            // use type casting to convert bmwM5 to use base class methods
            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            // create an object of M3
            M3 myM3 = new M3(260, "red", "m3Super Turbo");
            myM3.Repair();

            // demonstrate car info that has a relationship with CarIDInfo
            myM3.SetCarIDInfo(15689, "Jordan");
            myM3.GetCarIDInfo();
                

            Console.ReadKey();
        }
    }
}
