using Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Markup;

namespace Lib
{
    public class CommandDescription
    {
        public string type;
        public List<string> args;

        public CommandDescription(string[] values)
        {
            type = values[0].ToLower();
            args = values[1..].ToList();
        }
    }
}
