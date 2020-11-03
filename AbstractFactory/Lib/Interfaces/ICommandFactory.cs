using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Interfaces
{
    interface ICommandFactory
    {
        ICommand createCommand(CommandType type, List<double> args);
    }
}
