using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    class CommandProcessor
    {
        DateTime t;
        CommandProcessor()
        {
            t = DateTime.Now;
        }
        
       public void ExecuteBatch(ICommand[] commands)
        {
            for(int i = 0; i<commands.Length;i++)
            {
                ExecuteCommand(commands[i]);
            }
        }
       public ICommand ExecuteCommand(ICommand cmd)
        {
            Console.Write($"{t.Hour}:{t.Minute}:{t.Second}:{t.Millisecond} ");
            Console.Write(cmd.ToString());
            cmd.ExecuteCommand();
            Console.Write($" {t.Hour}:{t.Minute}:{t.Second}:{t.Millisecond}");
            Console.WriteLine();
            return cmd;
        }
    }
}
