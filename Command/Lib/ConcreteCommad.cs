using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    class ConcreteCommad : Command // RENAME
    {
        Receiver receiver;
        public void ExecuteCommand()
        {
            receiver.Operation();
        }
    }
}
