using System;
using MyCalculator; // importing the simple calculator library
using ClassLibraryAreaCalculator; // importing the area calculator library 

namespace CalculatorCBSE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating Component Based Software Application!");
            Console.WriteLine();
            Console.WriteLine("Performing Simple Calculations...");
            Console.WriteLine();

            Calculator calc = new Calculator(); //simple calculator class object

            Console.WriteLine("Addition: 3 + 2 = " + calc.add(3, 2));
            Console.WriteLine("Subtraction: 3 - 2 = " + calc.subtract(3, 2));
            Console.WriteLine("Multiplication: 3 * 2 = " + calc.multiply(3, 2));
            Console.WriteLine("Division: 3 / 2 = " + calc.divide(3, 2));

            Console.WriteLine();
            Console.WriteLine("Performing Boolean Operations...");
            Console.WriteLine();

            Console.WriteLine("And Operation: true and false implies " + calc.and(true, false));
            Console.WriteLine("Or Operation: true or false implies " + calc.or(true, false));

            Console.WriteLine();
            Console.WriteLine("Performing Area Calculations...");
            Console.WriteLine();

            AreaCalculator area_calc = new AreaCalculator(); //area calculator class object

            Console.WriteLine("Area of a triangle where base = 3 and height = 2: " + area_calc.find_triangle_area(3, 2));
            Console.WriteLine("Area of a rectangle where width = 3 and height = 2: " + area_calc.find_rectangle_area(3, 2));
            Console.WriteLine("Area of a circle where radius = 3: " + area_calc.find_circle_area(3));
           
        }
    }
}
