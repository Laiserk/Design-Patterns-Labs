using System;
using Lib;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            for(int i =0; i<10; i++)
            {
                invoker.SetCommand(new InversionCommnad(receiver, rand.Next(1,100)));
                invoker.Run();

                invoker.SetCommand(new SumCommnad(receiver, rand.Next(1, 100), rand.Next(1, 100)));
                invoker.Run();

                invoker.SetCommand(new MultiplicationCommnad(receiver, rand.Next(1, 100), rand.Next(1, 100)));
                invoker.Run();
            }
            

            Console.ReadKey();

        }
    }
}
