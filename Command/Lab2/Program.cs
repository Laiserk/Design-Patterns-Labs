using System;
using Lib;

namespace Lab2
{
    class Program
    {
        static private ICommand[] CreateCommands()
        {
            Random rand = new Random();
            Receiver receiver = new Receiver();

            ICommand[] commands = new ICommand[10];
            commands[0] = new InversionCommand(receiver, rand.Next(1, 100));
            commands[1] = new InversionCommand(receiver, rand.Next(1, 100));
            commands[2] = new InversionCommand(receiver, rand.Next(1, 100));
            commands[3] = new SumCommand(receiver, rand.Next(1, 100), rand.Next(1, 100));
            commands[4] = new SumCommand(receiver, rand.Next(1, 100), rand.Next(1, 100));
            commands[5] = new SumCommand(receiver, rand.Next(1, 100), rand.Next(1, 100));
            commands[6] = new MultiplicationCommand(receiver, rand.Next(1, 100), rand.Next(1, 100));
            commands[7] = new MultiplicationCommand(receiver, rand.Next(1, 100), rand.Next(1, 100));
            commands[8] = new MultiplicationCommand(receiver, rand.Next(1, 100), rand.Next(1, 100));
            commands[9] = new MultiplicationCommand(receiver, rand.Next(1, 100), rand.Next(1, 100));

            return commands;
        }
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            ICommand[] commands = CreateCommands();
            for (int i = 0; i < commands.Length; i++)
            {
                invoker.SetCommand(commands[i]);
                invoker.Run();
            }
            Console.ReadKey();
        }
    }
}
