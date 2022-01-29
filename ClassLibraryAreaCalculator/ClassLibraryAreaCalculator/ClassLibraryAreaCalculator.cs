using System;

namespace ClassLibraryAreaCalculator
{
    // Interface
    interface IAreaCalculator
    {
        public double find_triangle_area(double baselength, double height); 
        public double find_rectangle_area(double width, double length);
        public double find_circle_area(double radius);
    }
    public class AreaCalculator: IAreaCalculator
    {
        //function to calculate area of a triangle
        public double find_triangle_area(double baselength, double height)
        {
            return (baselength * height) / 2;
        }

        //function to calculate area of a triangle
        public double find_rectangle_area(double width, double length)
        {
            return width * length;
        }

        //function to calculate area of a triangle
        public double find_circle_area (double radius)
        {
            return 3.14 * radius * radius;
        }
    }
}
