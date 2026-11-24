namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // array = a variable that can store multiple values. fixed size

            string[] cars = { "Camaro", "Mustang", "Challenger" };
            cars[0] = "Corvette"; // changing the value of the first element in the array

         
            foreach ( string car in cars )
                Console.WriteLine(car);
            Console.ReadKey();

        }
    }
}
