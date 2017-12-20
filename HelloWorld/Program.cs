using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            persongreeter greet;
            greet = new persongreeter();
            greet.HelloText = "Hello World!";
            greet.SayHello();

            persongreeter seagreet;
            seagreet  = new persongreeter();
            seagreet.HelloText = "Ahoy World!";
            seagreet.SayHello();

            Console.ReadLine();
        }
    }
}
