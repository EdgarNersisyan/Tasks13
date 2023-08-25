using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a ComplexNumber class representing complex numbers. 
            Overload the + operator to add two complex numbers.
            Create a Vector2D class representing a 2D vector. Overload the * operator
            to scale the vector by a given factor.*/

            ComplexNumber num1 = new ComplexNumber(1, 2);
            ComplexNumber num2 = new ComplexNumber(3.5, 5);

            ComplexNumber num3 = num1 + num2;

            Console.WriteLine("Num1: " + num1.ToString());
            Console.WriteLine("Num2: " + num2.ToString());
            Console.WriteLine("Num3: " + num3.ToString());

            Vector2D vector = new Vector2D(5, 6);

            double factor = 5;
            Vector2D vector2 = vector * factor;

            Console.WriteLine("Vector 1: " + vector.ToString());
            Console.WriteLine("Vector 2: " + vector2.ToString());
            
            Console.ReadLine();
        }
    }
}
