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
            var descriptions = ParseFile(lines);

            var commands = new List<ICommand>();
            foreach(CommandDescription command in descriptions)
            {

                commands.Add(createCommand(command.type, command.args));
            }
            return commands;
        }
        protected ICommand createCommand(string type, List<string> args)
        {
            var length = args.Count;
            switch (type)
            {
                case "sum":
                    return new SumCommand(double.Parse(args[0]), double.Parse(args[1]));

                case "inversion":
                    return new InversionCommand(double.Parse(args[0]));

                case "multiplication":
                    return new MultiplicationCommand(double.Parse(args[0]), double.Parse(args[1]));
                default:
                    throw new ArgumentException($"Operation with type '{type}' does not exist");
            }
        }

        protected abstract string[] ReadFile(string path);

        protected static IEnumerable<CommandDescription> ParseFile(IEnumerable<string> lines)
        {
            var descriptions = new List<CommandDescription>();
            foreach(string line in lines)
            {
                var values = line.Split('\t');
                descriptions.Add(new CommandDescription(values));                
            }
            return descriptions;
        }
    }
}
