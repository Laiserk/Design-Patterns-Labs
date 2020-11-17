using Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Markup;

namespace Lib
{
    public class CommandDescription
    {
        public CommandType type;
        public List<double> args;

        public CommandDescription(string[] values)
        {
            var strType = values[0].ToLower();
            var length = values.Length;
            switch(strType)
            {
                case "sum":
                    type = CommandType.Sum;
                    args = new List<double>(2);
                    if(length - 1 == 2)
                    {
                        args.Add(double.Parse(values[1].Trim()));
                        args.Add(double.Parse(values[2].Trim()));
                    }
                    else
                        throw new TargetParameterCountException($"Expected 2 arguments. but '{length - 1}' were recieved.");
                    break;
                case "inversion":
                    type = CommandType.Inversion;
                    args = new List<double>(1);
                    if (length - 1 == 1)
                        args.Add(double.Parse(values[1].Trim()));
                    else
                        throw new TargetParameterCountException($"Expected 1 argument. but '{length - 1}' were recieved.");
                    break;
                case "multiplication":
                    type = CommandType.Sum;
                    args = new List<double>(2);
                    if (length - 1 == 2)
                    {
                        args.Add(double.Parse(values[1].Trim()));
                        args.Add(double.Parse(values[2].Trim()));
                    }
                    else
                        throw new TargetParameterCountException($"Expected 2 arguments. but '{length - 1}' were recieved.");
                    break;
                default:
                    throw new ArgumentException($"Operation with type '{strType}' does not exist");
            }
        }
    }
}
