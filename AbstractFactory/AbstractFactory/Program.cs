using System;
using System.IO;
using System.Net;
using Lib.Factories;
using Lib.Interfaces;
using Lib.Commands;
using Lab2;

namespace AbstractFactory
{   
    class Program
    { 
        static bool isRemote(string path)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(path);
            }
            catch(System.InvalidCastException)
            {
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            var configFileName = args[0];
            BaseFileFactory factory;
            if (isRemote(configFileName))   
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
