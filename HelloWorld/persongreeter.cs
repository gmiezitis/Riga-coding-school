using System;
namespace HelloWorld
{
    public class persongreeter
    {
        public string HelloText;
            public void SayHello()
            {
                string myName;
                myName = Console.ReadLine();
            Console.WriteLine(HelloText + myName);
            }

    }
}
