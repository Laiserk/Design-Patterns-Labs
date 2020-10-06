using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class CommandProcessor
    {
        public CommandProcessor(ILogger logger)
        {
            if(logger == null)
            {
                throw new ArgumentNullException();
            }
            Logger = logger;
        }
        private ILogger Logger { get; set; }
        public void ExecuteBatch(IEnumerable<ICommand> commands)
        {
            foreach(var command in commands)
            {
                ExecuteCommand(command);
            }
        }
       public ICommand ExecuteCommand(ICommand cmd)
        {
            DateTime t = DateTime.Now;
            Logger.Write($"{t.Hour}:{t.Minute}:{t.Second}:{t.Millisecond} {cmd}");
            cmd.ExecuteCommand();
            t = DateTime.Now;
            Logger.Write($" = {cmd.Result} {t.Hour}:{t.Minute}:{t.Second}:{t.Millisecond}\n");
            return cmd;
        }
    }
}