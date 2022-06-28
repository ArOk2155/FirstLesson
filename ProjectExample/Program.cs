using System;

namespace FirstLesson
{
    class Program
    {
        static void Main(string[] args)
        {

            
        }

        // The user enters the number of hours, output the number of minutes in that number of hours.
        static int CalculateMinutes(int hours)
        {
            return hours * 60;
        }

        // The user enters 2 numbers (A and B). Print the solution (5*A+B^2)/(B-A) to the console.
        static double CalculateSolution(int a, int b)
        {
            return (5 * a + b * b) / (b - a);
        }

        // The user enters 2 string values (A and B). Swap the contents of variables A and B.
        static (int a, int b) Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            return (a, b);
        }

        // The user enters 2 numbers (A and B). Print to the console the result of dividing A by B and the division remainder.
        static (float result, float divisionRemainder) SomeCalculation(int a, int b)
        {
            float result = a / b;
            float divisionRemainder =  a % b;

            return (result, divisionRemainder);
        }

        // The user enters 3 non-zero numbers (A, B and C). Print to the console the solution (X value) of the standard linear equation, where A*X+B=C.
        static float LinearEquation(int a, int b, int c)
        {
            return (float) (c - b) / a;
        }

        // The user enters 4 numbers (X1, Y1, X2, Y2) describing the coordinates of 2 points on the coordinate plane.
        // Output the equation of a straight line in the format Y=AX+B passing through these points.
        static (double a, double b) EquationOfLine(int x1, int y1, int x2, int y2)
        {
            // Algorithm:
            // y1 = a*x1 + b
            // y2 = a*x2 + b
            // b = y2 - a *x2
            // y1 = a*x1 + y2 - a*x2
            // a = (y1 - y2)/(x1 - x2)
            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;

            return (a, b);
        }

        // The variable N stores a natural two-digit number (10-99). Write a program that calculates and displays the sum of the digits of n.
        static int SumOfDigits(int someNumber)
        {         
            return (someNumber % 10) + (someNumber / 10);
        }
    }
}
