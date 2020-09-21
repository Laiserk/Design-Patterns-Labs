using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Receiver
    {
        public void Inversion(int number)
        {
            Console.WriteLine(-number);
        }
        public void Sum(int number1, int? number2)
        {
            Console.WriteLine(number1+number2);
        }
        public void Multiplication(int number1,int number2)
        {
            Console.WriteLine(number1 * number2);
        }
    }
}
