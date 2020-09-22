using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public interface ICommand
    {
        void ExecuteCommand();
        double Result { get;  }
        //void UnDO();
    }
}
