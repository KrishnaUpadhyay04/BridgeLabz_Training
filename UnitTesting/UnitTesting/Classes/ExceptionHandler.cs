using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting.Classes
{
    public class ExceptionHandler
    {
        public int Divide(int a, int b)
        {
            if(b == 0)
            {
                throw new ArithmeticException("Cannot Divide by Zero.");
            }

            return a / b;
        }
    }
}
