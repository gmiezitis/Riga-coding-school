using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            persongreeter greet;
            greet = new persongreeter();
            greet.SayHello();
            Console.ReadLine();
        }
    }
}
