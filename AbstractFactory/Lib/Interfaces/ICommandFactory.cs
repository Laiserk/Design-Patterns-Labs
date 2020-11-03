using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Interfaces
{
    interface ICommandFactory
    {
        List<ICommand> createCommands(List<CommandType> types, List<List<double>> args);
    }
}
