using System;

namespace relationaloperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;
            Console.WriteLine("a > b = {0}", a > b);//true
            Console.WriteLine("a > 3 = {0}", a > 3);//true
            Console.WriteLine("2 < a = {0}",2 < a);//true
            Console.WriteLine(" a >= 10 = {0}",a >= 10);//true
            Console.WriteLine("b != 5 = {0}", b != 5);//true
            Console.WriteLine("2 == b = {0}", 2 == b);//true
            bool agree = b > 20;
            Console.WriteLine("agree = {0}",agree);
        }
    }
}
