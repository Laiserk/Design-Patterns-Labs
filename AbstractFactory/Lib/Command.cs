using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    abstract public class Command : ICommand
    {
        public double Result { get; protected set; }

        public CommandState state { get; protected set; }

        abstract public void ExecuteCommand();
    }
}
