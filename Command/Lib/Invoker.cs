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
            DateTime t = DateTime.Now;
            Console.Write($"{t.Hour}:{t.Minute}:{t.Second}:{t.Millisecond} ");
            Console.Write(command.ToString());
            command.ExecuteCommand();
            Console.Write($" {t.Hour}:{t.Minute}:{t.Second}:{t.Millisecond}");
            Console.WriteLine();
        }
    }
}
