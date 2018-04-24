using System;

namespace Lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus' Room Detail Generator!\n");

        Start:
            Console.Write("Enter Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter Height: ");
            double height = double.Parse(Console.ReadLine());

            double area;
            area = (length * width) * 2;

            double perimeter;
            perimeter = (length * 2) + (width * 2);


            double volume;
            volume = (width * length * height);

            Console.WriteLine("\nArea: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("Volume: " + volume);

            Console.WriteLine("\nContinue? (y/n)");
            string response;
            response = Console.ReadLine();
            if (response == "y")
            {
                Console.WriteLine("");
                goto Start;
            }
            else { };

        }
    }
}
