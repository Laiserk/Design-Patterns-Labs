using System;
using Lib.Factories;
using Lib.Interfaces;
using Lib.Commands;
using Lab2;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var configFileName = args[0];
         
            var localFactory = new LocalFileFactory();
            var commands = localFactory.createCommands(configFileName);
 
            var processor = new CommandProcessor((ILogger)new ConsoleLogger());
            processor.ExecuteBatch(commands);
            Console.ReadKey();
        }
    }
}
