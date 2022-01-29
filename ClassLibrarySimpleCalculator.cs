using System;

namespace MyCalculator
{
    interface ICalculator
    {
        public double add(double num1, double num2);
        public double subtract(double num1, double num2);
        public double multiply(double num1, double num2);
        public double divide(double num1, double num2);

    }

    interface ILogicalCalculator
    {
        public bool and(bool var1, bool var2);
        public bool or(bool var1, bool var2);

    }

    public class Calculator:ICalculator, ILogicalCalculator
    {
        //function to perform addition 
        public double add(double num1, double num2)
        {
            return num1 + num2;
        }

        //function to perform subtraction 
        public double subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        //function to perform multiplication 
        public double multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        
        //function to perform division
        public double divide(double num1, double num2)
        {
                return num1 / num2;
        }

        public bool and(bool var1, bool var2)
        {
            return var1 && var2;
        }

        public bool or(bool var1, bool var2)
        {
            return var1 || var2;
        }
    }
}