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
            for(int i = 0; i<commands.Length;i++)
            {
                ExecuteCommand(commands[i]);
            }
        }
       public ICommand ExecuteCommand(ICommand cmd)
        {
            DateTime t = DateTime.Now;
            Console.Write($"{t.Hour}:{t.Minute}:{t.Second}:{t.Millisecond} ");
            Console.Write(cmd.ToString());
            cmd.ExecuteCommand();
            t = DateTime.Now;
            Console.Write($" {t.Hour}:{t.Minute}:{t.Second}:{t.Millisecond}");
            Console.WriteLine();
            return cmd;
        }
    }
}