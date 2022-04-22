using System;

namespace MethodsExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var name = Console.ReadLine();

            int result = Multiply(10, 2);

            Console.WriteLine($" Great question, the answer would be {result}");
        }

        public static int Add(int num1, int num2)
        {
           return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }

}
