using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class OptionalParameter
    {
        public int MultiplyBy3(int firstOperand, int secondOperand = 1)
        {
            int result = firstOperand * secondOperand * 3;
            return result;
        }
    }
}
