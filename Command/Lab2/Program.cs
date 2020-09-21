using System;
using Lib;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            invoker.SetCommand(new ConcreteCommad(receiver));
            invoker.Run(-2);
            Console.ReadKey();

        }
    }
}
