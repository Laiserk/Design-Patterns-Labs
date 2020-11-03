using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Interfaces
{
    public enum CommandType
    {
        Sum,
        Inversion,
        Multiplication
    }

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