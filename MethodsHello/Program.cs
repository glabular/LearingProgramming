using System;

namespace MethodsHello
{
    internal class Program
    {
        // Access midifyers
        // private
        // internal
        // public

        public static void Main(string[] args)
        {
            //DoOperation(10, 5, Operation.Add);
            //DoOperation(10, 5, Operation.Subtract);
            //DoOperation(10, 5, Operation.Multiply);
            //DoOperation(10, 5, Operation.Divide);

            //void DoOperation(double x, double y, Operation op)
            //{
            //    double result = op switch
            //    {
            //        Operation.Add => x + y,
            //        Operation.Subtract => x - y,
            //        Operation.Multiply => x * y,
            //        Operation.Divide => x / y
            //    };

            //    Console.WriteLine(result);
            //}

            






















        }











        private static void SayHello()
        {
            Console.WriteLine("Hello");
        }
       
        private static void SumTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }

        private static void PrintPerson(string name, int age)
        {
            Console.WriteLine($"Name: {name} Age: {age}");
        }

        private static void PrintPerson2(string name, int age = 1, string company = "Undefined")
        {
            Console.WriteLine($"Name: {name} Age: {age} Company: {company}");
        }

        private static string GetMessage()
        {
            return "Hello to you";

        }

        private static void PrintMsg(string message)
        {
            Console.WriteLine(message);
        }

        private static void PrintPerson3(string name, int age)
        {
            if (age > 120 || age < 1)
            {
                Console.WriteLine("Недопустимый возраст");
                return;
            }

            Console.WriteLine($"Имя: {name} Возраст: {age}");
        

        }

        private static void Increment(int n)
        {
            n++;
            Console.WriteLine($"Число в методе Increment: {n}");

        }

        private static void Increment2(ref int n)
        {
            n++;
            Console.WriteLine($"Число в методе Increment: {n}");

        }

        private static void Sum(int x, int y, out int result)
        {
            result = x + y;
        }

        private static void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
        {
            rectArea = width * height; // Площадь прямоугольника
            rectPerimetr = (width + height) * 2; // Периметр прямоугольника
        }

        private static void Sum1(params int[] numbers)
        {
            int result = 0;
                foreach (var n in numbers)
            {
                result += n;
            }
            Console.WriteLine(result);
        }

        private static void Sum3(int initialValue, params int[] numbers)
        {
            int result = initialValue;
            foreach (var n in numbers)
            {
                result += n;
            }
            Console.WriteLine(result);
        }



    }
}
