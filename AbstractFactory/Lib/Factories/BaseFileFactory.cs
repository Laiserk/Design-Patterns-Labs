using System;
using System.Collections.Generic;
using System.Text;
using Lib.Commands;
using Lib.Interfaces;

namespace Lib.Factories
{
    class BaseFileFactory : ICommandFactory
    {
        public ICommand createCommand(CommandType type, List<double> args)
        {
            if(type == CommandType.Sum)
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
    }
}
