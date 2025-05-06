using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ちわわわ!");
            int result = Add(3, 5);
            Console.WriteLine("結果: " + result);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}