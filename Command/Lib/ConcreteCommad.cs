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
        Receiver receiver;
        int number;
       
        public InversionCommand(Receiver receiver, int number)
        {
          
            this.receiver = receiver;
            this.number = number;
        }
        public void ExecuteCommand()
        {
           
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.Write($"Taking the inversion of a number {number} = ");
            receiver.Inversion(number);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine();
        }
    }
    public class SumCommand : ICommand 
    {
        Receiver receiver;
        int number1,number2;
      
        public SumCommand(Receiver receiver, int number1, int number2)
        {
           
            this.receiver = receiver;
            this.number1 = number1;
            this.number2 = number2;
        }
        public void ExecuteCommand()
        {

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.Write($"Sum {number1} and {number2} = ");
            receiver.Sum(number1,number2);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine();
        }
    }
    public class MultiplicationCommand : ICommand 
    {
        Receiver receiver;
        int number1, number2;
        
        public MultiplicationCommand(Receiver receiver, int number1, int number2)
        {
            this.receiver = receiver;
            this.number1 = number1;
            this.number2 = number2;
        }
        public void ExecuteCommand()
        {

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.Write($"Multiplication {number1} and {number2} = ");
            receiver.Multiplication(number1,number2);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine();

        }
    }
}
