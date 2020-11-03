using System;
using System.Collections.Generic;
using System.Text;
using Lib.Commands;
using Lib.Interfaces;

namespace Lib.Factories
{
    class BaseFileFactory : ICommandFactory
    {
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
        protected static string[] ParseFile(string[] lines, List<CommandType> types, List<List<double>> args)
        {
           

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split('\t');
                var type = values[0];
                if (type == "sum")
                {
                    types[i] = CommandType.Sum;
                    args[i].Add(double.Parse(values[1]));
                    args[i].Add(double.Parse(values[2]));
                }   

                if (type == "inversion")
                {
                    types[i] = CommandType.Inversion;
                    args[i].Add(double.Parse(values[1]));
                }
                

                if (type == "multiplication")
                {
                    types[i] = CommandType.Multiplication;
                    args[i].Add(double.Parse(values[1]));
                    args[i].Add(double.Parse(values[2]));
                }                     
            }
            return null;
        }
    }
}
