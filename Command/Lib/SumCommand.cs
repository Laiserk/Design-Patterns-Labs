using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class SumCommand : Command
    {
        double number1, number2;

        public SumCommand(double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        public override void ExecuteCommand()
        {
            Result = number1 + number2;
            Console.Write(Result);
        }

        public override string ToString()
        {
            return $"Sum of {number1} and {number2} = ";
        }
    }
}
