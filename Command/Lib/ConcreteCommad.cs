using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Lib
{
    
    public class InversionCommand : ICommand 
    {
        MathCommandProcessor receiver;
        int number;
       
        public InversionCommand(MathCommandProcessor receiver, int number)
        {
            this.receiver = receiver;
            this.number = number;
        }
        public void ExecuteCommand()
        {
            receiver.Inversion(number);
        }

        public override string ToString()
        {
            return $"Inversion of {number}";
        }
    }
    public class SumCommand : ICommand 
    {
        MathCommandProcessor receiver;
        int number1,number2;
      
        public SumCommand(MathCommandProcessor receiver, int number1, int number2)
        {
            this.receiver = receiver;
            this.number1 = number1;
            this.number2 = number2;
        }
        public void ExecuteCommand()
        {
            receiver.Sum(number1,number2);
        }

        public override string ToString()
        {
            return $"Sum of {number1} and {number2}";
        }
    }
    public class MultiplicationCommand : ICommand 
    {
        MathCommandProcessor receiver;
        double number1, number2;
        double result;
        
        public MultiplicationCommand(MathCommandProcessor receiver, int number1, int number2)
        {
            this.receiver = receiver;
            this.number1 = number1;
            this.number2 = number2;
        }
        public void ExecuteCommand()
        {
            receiver.Multiplication(number1,number2);
        }

        public override string ToString()
        {
            return $"Multiplication of {number1} and {number2}";
        }
    }
}
