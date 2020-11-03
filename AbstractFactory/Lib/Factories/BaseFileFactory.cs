using System;
using System.Collections.Generic;
using System.Text;
using Lib.Commands;
using Lib.Interfaces;

namespace Lib.Factories
{
    abstract public class BaseFileFactory : ICommandFactory
    {
        public List<ICommand> createCommands(string path)
        {
            var lines = ReadFile(path);
            var commandTypes = new List<CommandType>();
            var args = new List<List<double>>();
            ParseFile(lines, commandTypes, args);

            var commands = new List<ICommand>(commandTypes.Count);
            for(int i = 0; i < commandTypes.Count; i++)
            {
                commands.Add(createCommand(commandTypes[i], args[i]));
            }
            return commands;
        }
        protected ICommand createCommand(CommandType type, List<double> args)
        {
            if (type == CommandType.Sum)
            {
                return new SumCommand(args[0], args[1]);
            }
            if (type == CommandType.Inversion)
            {
                return new InversionCommand(args[0]);
            }
            if (type == CommandType.Multiplication)
            {
                return new MultiplicationCommand(args[0], args[1]);
            }
            else
                return null;
        }

        protected abstract string[] ReadFile(string path);
        protected static string[] ParseFile(string[] lines, List<CommandType> types, List<List<double>> args)
        {
           

            for (int i = 0; i < lines.Length; i++)
            {
                var values = lines[i].Split('\t');
                var type = values[0];
                switch(type)
                {
                    case "sum":
                        types.Add(CommandType.Sum);
                        args.Add(new List<double>(2));
                        args[args.Count - 1].Add(double.Parse(values[1]));
                        args[args.Count - 1].Add(double.Parse(values[2]));
                        break;
                    case "inversion":
                        types.Add(CommandType.Inversion);
                        args.Add(new List<double>(1));
                        args[args.Count - 1].Add(double.Parse(values[1]));
                        break;
                    case "multiplication":
                        types.Add(CommandType.Sum);
                        args.Add(new List<double>(2));
                        args[args.Count - 1].Add(double.Parse(values[1]));
                        args[args.Count - 1].Add(double.Parse(values[2]));
                        break;
                    default:
                        throw new ArgumentException($"Operation with type '{type}' does not exist");
                        
                }
                    

                if (type == "sum")
                {
                    types.Add(CommandType.Sum);
                    args.Add(new List<double>(2));
                    args[args.Count - 1].Add(double.Parse(values[1]));
                    args[args.Count - 1].Add(double.Parse(values[2]));
                }   

                if (type == "inversion")
                {
                    types.Add(CommandType.Inversion);
                    args.Add(new List<double>(1));
                    args[args.Count - 1].Add(double.Parse(values[1]));
                }

                if (type == "multiplication")
                {
                    types.Add(CommandType.Multiplication);
                    args.Add(new List<double>(2));
                    args[args.Count - 1].Add(double.Parse(values[1]));
                    args[args.Count - 1].Add(double.Parse(values[2]));
                }                     
            }
            return null;
        }
    }
}
