using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class MathOperations1
    {
        public int argument1 { get; set; }
        
        public int Add9()
        {
            int result = argument1 + 9;
            return result;
        }
        
        public int Subtract3()
        {
            int result = argument1 - 3;
            return result;
        }

        public int Multiply10()
        {
            int result = argument1 * 10;
            return result;
        }
    }
}
