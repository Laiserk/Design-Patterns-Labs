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
        static void Main(string[] args)
        {
            var configFileName = args[0];
            BaseFileFactory factory;
            var client = new WebClient();
            try
            {
               client.DownloadFile(configFileName, "C:\\Users\\Admin\\Documents\\Repos\\Design-Patterns-Labs\\AbstractFactory\\AbstractFactory\\Config\\RemoteConfig.tsv");
               factory = new RemoteFileFactory();
            }
            catch(WebException webEx)
            {
                HttpWebResponse error = webEx.Response as HttpWebResponse;
                Console.WriteLine($"File {error.StatusCode}");
                if (error.StatusCode == HttpStatusCode.NotFound)
                {
                    FileStream fs = File.Open(configFileName, FileMode.Open);
                    if (fs.CanRead)
                        factory = new LocalFileFactory();
                }
                    
            }
            factory = new LocalFileFactory();
            //if (configFileName.Contains("/"))   
            //    factory = new RemoteFileFactory();
            //else
            //    factory = new LocalFileFactory();
            var commands = factory.createCommands(configFileName);
 
            var processor = new CommandProcessor(new ConsoleLogger());
            processor.ExecuteBatch(commands);
            Console.ReadKey();
        }
    }
}
