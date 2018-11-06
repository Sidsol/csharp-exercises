using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your miles driven");
            int miles = int.Parse(Console.ReadLine());
            Console.WriteLine("How much gas have you consumed");
            int gas = int.Parse(Console.ReadLine());

            Console.WriteLine( miles / gas);
            Console.ReadLine();


        }
    }
}
