using System;

namespace AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
   

            Console.WriteLine("Please enter the dimensions of a Triangle");
            Console.WriteLine("Base of the Triangle");
            int base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Height of the Triangle");
            int height = int.Parse(Console.ReadLine());

            int area_of_triangle = base1 * height;

            Console.WriteLine("The Area of the Triangle is : ");
            Console.WriteLine(area_of_triangle);

            Console.ReadLine();




        }
    }
}
