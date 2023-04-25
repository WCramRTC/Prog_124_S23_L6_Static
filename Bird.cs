using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L6_Static
{
    internal class Bird
    {
        // Instanced Fields
        string _name;
        double _wingspan;
        string _color;
        bool _canFly;

        // static field
        // but static fields can have static properties
        public static int count = 0;

        public Bird()
        {
            count++;
        }

        public Bird(string name, double wingspan, string color, bool canFly)
        {
            _name = name;
            _wingspan = wingspan;
            _color = color;
            _canFly = canFly;
            // Increment our bird count when we create a new instance
            count++;
        } // Bird

        // Properties ??

        // Static Method
        public static void DisplayBirdInfo()
        {
            Console.WriteLine("THis is a bird class");
            // Static methods are built, when they don't need to have access to instanced fields
            //Console.WriteLine(_name);
        }

        // Create a new Bird that combines wingspans 
        public static Bird CombineWingspans(Bird b1, Bird b2)
        {
            // I'm combining the wingspans of the two birds passed in
            double fullWingSpan = b1._wingspan + b2._wingspan;
            
            Bird tempBird = new Bird(
                b1._name, 
                fullWingSpan, 
                b1._color, 
                b1._canFly);

            return tempBird;

        } // CombineWingspans


    } // class

} // namespace
