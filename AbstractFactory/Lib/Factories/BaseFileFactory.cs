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
                throw (new ArgumentException($"Operation with type '{type.ToString()}' does not exist"));
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
