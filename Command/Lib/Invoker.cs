using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Invoker
    {
        ICommand command;
        public Invoker() { }
        public void SetCommand(ICommand c)
        {
            command = c;
        }
        public void Run()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(command.ToString());
            command.ExecuteCommand();
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine();
        }
    }
}
