using System;
using System.Collections.Generic;
using System.Text;
using Lib.Interfaces;

namespace Lab2
{
    public class ConsoleLogger : ILogger
    {
        public void Write(string message)
        {
            Console.Write(message);
        }
    }
}
