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
            BaseFileFactory factory;
            if (configFileName.Contains("://"))
                factory = new RemoteFileFactory();
            else
                factory = new LocalFileFactory();
            var commands = factory.createCommands(configFileName);
 
            var processor = new CommandProcessor(new ConsoleLogger());
            processor.ExecuteBatch(commands);
            Console.ReadKey();
        }
    }
}
