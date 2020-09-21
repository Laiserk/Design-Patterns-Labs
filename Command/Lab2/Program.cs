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
            invoker.SetCommand(new InversionCommad(receiver));
            invoker.Run(-2);
            invoker.SetCommand(new SumCommad(receiver));
            invoker.Run(1,2);
            invoker.SetCommand(new MultiplicationCommad(receiver));
            invoker.Run(3, 4);
            Console.ReadKey();

        }
    }
}
