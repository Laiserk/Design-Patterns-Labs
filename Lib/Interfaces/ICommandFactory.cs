﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Interfaces
{
    public interface ICommandFactory
    {
        List<ICommand> createCommands(string path);
    }
}
