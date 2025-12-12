
using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations operations = new MathOperations();
            operations.DoMath(5, 10);
            operations.DoMath(num1: 7, num2: 3);
            Console.ReadLine();
        }
    }
}
