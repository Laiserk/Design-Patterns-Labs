using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public interface ICommand
    {
        void ExecuteCommand(int number1, int? number2 = null);
        //void UnDO();
    }
}
