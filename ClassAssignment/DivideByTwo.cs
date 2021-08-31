using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class DivideByTwo
    {
        public void divide(int operand)
        {
            int result = operand / 2;
            Console.WriteLine(operand + " divided by two is " + result);
        }

        public int divideBy3(int operand1, out int remainder1)
        {
            int result = operand1 / 3;
            remainder1 = operand1 % 3;
            return result;
        }

        public float divideBy3(float operand2)
        {
            float result = operand2 / 3;
            return result;
        }
    }
}
