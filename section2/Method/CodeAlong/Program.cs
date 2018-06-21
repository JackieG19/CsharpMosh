using System;

namespace Methods
{
    class program
    {

        static void Main(string[] args)
        {
            // var number = int.Parse("abc");

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine("Conversion failed");
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[]{1, 2, 3, 4, 5}));
        }

        static void UsePoint()
        {

            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }

            catch (Execption)
            {
                Console.WriteLine("An unexpected errror occured.");
            }
        }
    }

}