using System;
using System.Collections.Generic;
using System.Text;
using Lib;

namespace Lab2
{
    class ConsoleLogger : ILogger
    {
        public void Write(string message)
        {
            Console.Write(message);
        }
    }
}
