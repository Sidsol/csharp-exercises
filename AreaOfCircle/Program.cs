using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.WriteLine("Enter a Radius: ");
            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine("The Area of the circle is: ");
            Console.WriteLine(pi * (radius * radius));
            Console.ReadLine();

        }
    }
}
