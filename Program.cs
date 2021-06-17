using System;
using System.IO;
namespace OOP_With_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());
            stack.Clear();
        }
    }
}