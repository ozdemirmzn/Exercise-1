using System;

namespace Studio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double radius;
            double pi = Math.PI;
            string input;
            double circumference;
            double diameter;
            double mpg;


            Console.WriteLine("Enter the radius of the circle: ");
            input = Console.ReadLine();
            radius = double.Parse(input);
            area = pi * Math.Pow(radius, 2);
            circumference = 2 * pi * radius;
            diameter = 2 * radius;
            Console.WriteLine("Enter the mpg of your car: ");
            input = Console.ReadLine();
            mpg = double.Parse(input);


            Console.WriteLine("The area of a circle of radius " + radius +  " is: " + area);
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + circumference);
            Console.WriteLine("The diameter of a circle of radius " + radius + " is: " + diameter);
            Console.WriteLine("Gas needed to comlpete the trip is " + mpg * circumference);

        }
    }
}
