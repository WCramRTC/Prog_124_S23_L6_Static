namespace Prog_124_S23_L6_Static
{
    internal class Program
    {
        // static fields
        // static methods
        // properties
        // constructor
        // class

        // Static members cannot access instanced members directly
        static string _name = "Will";

        static void Main(string[] args)
        {
            

        } // Main

        static void DisplayThis(string name)
        {
            Console.WriteLine(name);
        }

        public static void Example()
        {
            // Variables have to be built inside of here
            // or globals have to be static


            _name = "Jon";
            DisplayThis(_name);
            Console.WriteLine("Hello, World!");

            BankAccount ba1 = new BankAccount(500);
            BankAccount ba2 = new BankAccount(1000);

            Console.WriteLine(ba1);
            Console.WriteLine(ba2);

            BankAccount combinedAccount = BankAccount.CombineAccounts(ba1, ba2);
            Console.WriteLine(combinedAccount);

            double sum = MyMath.Add(1, 2);
            Console.WriteLine(sum);



            Console.WriteLine(Bird.count);

            Bird b1 = new Bird();
            Console.WriteLine(Bird.count);

            b1 = new Bird();
            Console.WriteLine(Bird.count);

            b1 = new Bird();
            Console.WriteLine(Bird.count);

            b1 = new Bird();
            Console.WriteLine(Bird.count);
        }

    } // class

} // namespace