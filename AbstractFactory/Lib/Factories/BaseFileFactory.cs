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

            var commands = new List<ICommand>(descriptions.Count);
            for(int i = 0; i < descriptions.Count; i++)
            {

                commands.Add(createCommand(descriptions[i].type, descriptions[i].args));
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

        protected static List<CommandDescription> ParseFile(string[] lines)
        {
            var descriptions = new List<CommandDescription>();
            for (int i = 0; i < lines.Length; i++)
            {
                var values = lines[i].Split('\t');
                descriptions.Add(new CommandDescription(values));                
            }
            return descriptions;
        }
    }
}
