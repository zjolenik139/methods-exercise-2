using System;

namespace Methods_Exersice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var result = Add(3, 5, 87);
            var multiplicationAnswer = Multiply(10,5,10);
            Console.WriteLine(result);
            Console.WriteLine(multiplicationAnswer);
        }
        public static int Add(int num1, int num2, int num3)
        { return num1 + num2 + num3; }
        public static int Multiply(int num1, int num2, int num3)
        { return num1 * num2 * num3; }


    }
}
