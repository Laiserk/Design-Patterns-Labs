using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Interfaces;

namespace Lib.Commands
{
    public class MultiplicationCommand : Command
    {
        double number1, number2;

        public MultiplicationCommand(double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        public override void ExecuteCommand()
        {
            Result = number1 * number2;
            state = CommandState.Succeed;
        }

        public override string ToString()
        {
            return $"Multiplication of {number1} and {number2}";
        }
    }
}
