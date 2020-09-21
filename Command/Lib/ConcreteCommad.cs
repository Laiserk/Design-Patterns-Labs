using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class ConcreteCommad : ICommand // RENAME
    {
        Receiver receiver;
        public ConcreteCommad(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public void ExecuteCommand(int number)
        {
             receiver.Inversion(number);

        }
    }
}
