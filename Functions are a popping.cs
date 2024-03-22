using System;

class Task1
{
    public static class MathFunctions
    {
        public static double Square(double number)
        {
            return number * number;
        }

        public static double InchesToMillimeters(double inches)
        {
            return inches * 25.4;
        }

        public static double SquareRoot(double number)
        {
            return Math.Sqrt(number);
        }

        public static double Cube(double number)
        {
            return number * number * number;
        }

        public static double CircleArea(double radius)
        {
            return Math.PI * Square(radius);
        }

        public static string Greet(string name)
        {
            return $"Hello, {name}!";
        }
    }

    class Task1Test
    {
        static void Main(string[] args)
        {
            double squareResult = MathFunctions.Square(5);
            double lengthInMM = MathFunctions.InchesToMillimeters(2);
            double sqrtResult = MathFunctions.SquareRoot(16);
            double cubeResult = MathFunctions.Cube(3);
            double areaResult = MathFunctions.CircleArea(2);
            string greeting = MathFunctions.Greet("Teacher");

            Console.WriteLine($"Square: {squareResult}");
            Console.WriteLine($"Length in mm: {lengthInMM}");
            Console.WriteLine($"Square root: {sqrtResult}");
            Console.WriteLine($"Cube: {cubeResult}");
            Console.WriteLine($"Area of circle: {areaResult}");
            Console.WriteLine(greeting);
        }
    }
}


