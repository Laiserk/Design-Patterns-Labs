using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class CommandProcessor
    {   
       public void ExecuteBatch(ICommand[] commands)
        {
            foreach(var command in commands)
            {
                ExecuteCommand(command);
            }
        }
       public ICommand ExecuteCommand(ICommand cmd)
        {
            DateTime t = DateTime.Now;
            Console.Write($"{t.Hour}:{t.Minute}:{t.Second}:{t.Millisecond} {cmd}");
            cmd.ExecuteCommand();
            t = DateTime.Now;
            Console.WriteLine($" {t.Hour}:{t.Minute}:{t.Second}:{t.Millisecond}");
            return cmd;
        }
    }
}