using System;
using Lib;
using Lab2;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var configFileName = args[0];

            var localFactory = new LocalFileCommandFactory();
            var commands = localFactory.createCommands(configFileName);
 
            var processor = new CommandProcessor(new ConsoleLogger());
            processor.ExecuteBatch(commands);
            Console.ReadKey();
        }
    }
}
