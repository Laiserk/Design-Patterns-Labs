using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public enum CommandState
    {
        Unprocessed,
        Failed,
        Succeed
    }

    public interface ICommand
    {
        void ExecuteCommand();
        double Result { get; }

        CommandState state { get; }
    }
}