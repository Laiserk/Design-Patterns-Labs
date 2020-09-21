using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Invoker
    {
        ICommand command;
        public Invoker() { }
        public void SetCommand(ICommand c)
        {
            command = c;
        }
        public void Run(int number)
        {
            command.ExecuteCommand(number);
        }
    }
}
