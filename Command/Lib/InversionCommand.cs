using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class InversionCommand : ICommand
    {
        double number;
        public double Result { get; private set; }

        public InversionCommand(int number)
        {
            this.number = number;
        }
        public void ExecuteCommand()
        {
            Result = -number;
            Console.Write(Result);
        }

        public override string ToString()
        {
            return $"Inversion of {number} = ";
        }
    }
}
