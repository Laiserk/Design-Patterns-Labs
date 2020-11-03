using System;
using System.Collections.Generic;
using System.Text;
using Lib.Commands;
using Lib.Interfaces;

namespace Lib.Factories
{
    abstract class BaseFileFactory : ICommandFactory
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
                commands[i] = createCommand(commandTypes[i], args[i]);
            }
            return commands;
        }
        public ICommand createCommand(CommandType type, List<double> args)
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
    }
}
