//using System;
//using Lib;
//using System.Collections.Generic;

//namespace Lab2
//{
//    class Program
//    {
//        static private List<ICommand> CreateCommands()
//        {
//            Random rand = new Random();
//            List<ICommand> commands = new List<ICommand>();
           
//            commands.Add(new InversionCommand(rand.Next(1, 100)));
//            commands.Add(new InversionCommand(rand.Next(1, 100)));
//            commands.Add(new InversionCommand(rand.Next(1, 100)));
//            commands.Add(new SumCommand((rand.Next(1, 100)), rand.Next(1, 100)));
//            commands.Add(new SumCommand((rand.Next(1, 100)), rand.Next(1, 100)));
//            commands.Add(new SumCommand((rand.Next(1, 100)), rand.Next(1, 100)));
//            commands.Add(new SumCommand((rand.Next(1, 100)), rand.Next(1, 100)));
//            commands.Add(new MultiplicationCommand((rand.Next(1, 100)), rand.Next(1, 100)));
//            commands.Add(new MultiplicationCommand((rand.Next(1, 100)), rand.Next(1, 100)));
//            commands.Add(new MultiplicationCommand((rand.Next(1, 100)), rand.Next(1, 100)));

//            return commands;
//        }
//        static void Main(string[] args)
//        {
//            var processor = new CommandProcessor(new ConsoleLogger());
//            var commands = CreateCommands();
//            processor.ExecuteBatch(commands);
//            Console.ReadKey();
//        }
//    }
//}