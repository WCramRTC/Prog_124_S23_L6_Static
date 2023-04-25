using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L6_Static
{

    // Modify the class by giving it the static keyword
    // the static class modifer limits instance fields and constructors
    internal static class DataClass
    {
        public static string BusinessName = "Meta Espresso";
        private static List<Bird> birds;

        // static constructor
        // static constructors are not public,
        // take no paremters,
        // and cannot be manually called
        static DataClass()
        {
            // What is lazy instantiation
            birds = new List<Bird>();

            birds.Add(new Bird("Flamingo", 4, "Pink", true));

        }


        // Property
        internal static List<Bird> Birds { get => birds; }

        // static method
        public static void AddBird(Bird newBird)
        {
            Birds.Add(newBird);
        }

        // static constructor






    } // class

} // namespace
