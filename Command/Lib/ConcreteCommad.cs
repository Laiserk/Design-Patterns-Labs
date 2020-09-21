using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class InversionCommad : ICommand 
    {
        Receiver receiver;
        public InversionCommad(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public void ExecuteCommand(int number1, int? number2 = null)
        {
             receiver.Inversion(number1);

        }
    }
    public class SumCommad : ICommand 
    {
        Receiver receiver;
        public SumCommad(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public void ExecuteCommand(int number1, int? number2)
        {
            receiver.Sum(number1,number2);

        }
    }
    public class MultiplicationCommad : ICommand 
    {
        Receiver receiver;
        public MultiplicationCommad(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public void ExecuteCommand(int number1, int? number2)
        {
            receiver.Multiplication(number1,number2);

        }
    }
}
