using System;

namespace FirstLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello, Sviatoslav!
            //

            Console.Write("Select the task (1-7): ");
            int TaskNumber = Convert.ToInt32(Console.ReadLine());

            switch (TaskNumber)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
                case 7:
                    Task7();
                    break;
                default:
                    Console.Write("No task with number " + TaskNumber + ", restart the program and select a task from the interval (1-7)");
                    break;
            }
        }

        static void Task1()
        {
            // The user enters the number of hours, output the number of minutes in that number of hours.
            // There is no specification about the type of data that the user enters. We use integers.

            Console.WriteLine("Enter the number of hours:");
            int Hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of minutes: " + Hours*60);
        }
        static void Task2()
        {
            // The user enters 2 numbers (A and B). Print the solution (5*A+B^2)/(B-A) to the console.
            // Without the use of the construction "if" it is impossible to solve the problem completely.

            Console.WriteLine("Enter the number A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number B:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b == a)
            {
                Console.WriteLine("Number B should not be equal to number A. Enter the number B (not " + a + "):");
                b = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Result: " + (5*a+b*b)/(b-a));
        }
        static void Task3()
        {
            // The user enters 2 string values (A and B). Swap the contents of variables A and B.
            // Can be done with two more variables
            // For example:
            //...
            //string c = a
            //string d = b
            // a = d
            // b = c

            Console.WriteLine("Enter the string A:");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the string B:");
            string b = Convert.ToString(Console.ReadLine());
            (a, b) = (b, a);
            Console.WriteLine("Result: " + a + " " + b);
        }
        static void Task4()
        {
            // The user enters 2 numbers (A and B). Print to the console the result of dividing A by B and the division remainder.
            // Need to check for division by 0

            Console.WriteLine("Enter the number A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number B:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b==0)
            {
                Console.WriteLine("Division by zero, enter the number B again:");
                b = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Result (integer): " + (float) a / b + ", division remainder: " + (float) a % b);
        }
        static void Task5()
        {
            // The user enters 3 non-zero numbers (A, B and C). Print to the console the solution (X value) of the standard linear equation, where A*X+B=C.
            // It's good that there is a clarification about non-zero values

            Console.WriteLine("Enter the number A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number B:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number C:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value X = " + (float) (c-b)/a);
        }
        static void Task6()
        {
            // The user enters 4 numbers (X1, Y1, X2, Y2) describing the coordinates of 2 points on the coordinate plane.
            // Output the equation of a straight line in the format Y=AX+B passing through these points.
            // Use Math.Round Method to improve the display

            Console.WriteLine("Enter the number X1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number Y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number X2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number Y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            // Algorithm:
            // y1 = a*x1 + b
            // y2 = a*x2 + b
            // b = y2 - a *x2
            // y1 = a*x1 + y2 - a*x2
            // a = (y1 - y2)/(x1 - x2)
            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;
            string result = (b > 0) ? "Y = " + Math.Round(a,3) + "X + " + Math.Round(b,3) : "Y = " + a + "X " + Math.Round(b,3);
            Console.WriteLine(result);
        }
        static void Task7()
        {
            // The variable N stores a natural two-digit number (10-99). Write a program that calculates and displays the sum of the digits of n.

            Console.WriteLine("Enter the number (10-99):");
            int someNumber = Convert.ToInt16(Console.ReadLine());
            int firstNum = someNumber % 10;
            int secondNum = someNumber / 10;
            Console.WriteLine("Sum of digits: " + (firstNum + secondNum));
        }
    }
}
