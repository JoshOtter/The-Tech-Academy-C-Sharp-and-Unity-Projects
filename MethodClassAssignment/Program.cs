using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoParameters twoNumbers = new TwoParameters();
            twoNumbers.Calculate(firstNumber: 3,secondNumber: 5);
            Console.ReadLine();
        }
    }
}
