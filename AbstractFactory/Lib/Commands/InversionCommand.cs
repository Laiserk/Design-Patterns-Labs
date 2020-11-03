using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Commands
{
    public class InversionCommand : Command
    {
        double number;

        public InversionCommand(double number)
        {
            this.number = number;
        }
        public override void ExecuteCommand()
        {
            Result = -number;
        }

        public override string ToString()
        {
            return $"Inversion of {number}";
        }
    }
}