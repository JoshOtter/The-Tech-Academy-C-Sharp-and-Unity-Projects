﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Addition
    {
        public int Add(int intValue)
        {
            int result = intValue + 10;
            return result;
        }
        public float Add(float floatValue)
        {
            float result = floatValue + 100;
            return result;
        }
        //I used the out parameter to be able to return the processed number as an integer.
        public int Add(string stringValue)
        {
            int argument = Convert.ToInt32(stringValue);
            int result = argument + 1000;
            return result;
        }
    }
}
