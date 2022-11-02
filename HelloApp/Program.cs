using System;

namespace HelloApp
{
    internal class Program
    {
        public static void GreetBlack()
        {
            Console.WriteLine("hello black"); //хаски послушал
        }
        public static void GreetWhite()
        {
            Console.WriteLine("hello white"); // у нас так не принято
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
        }
    }
}