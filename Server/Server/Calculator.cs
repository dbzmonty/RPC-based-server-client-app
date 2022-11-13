using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;

namespace Server
{
    public class Calculator : MarshalByRefObject, ICalculator.ICalculator
    {
        int ICalculator.ICalculator.Addition(int a, int b)
        {
            return a + b;
        }

        int ICalculator.ICalculator.Subtraction(int a, int b)
        {
            return a - b;
        }

        int ICalculator.ICalculator.Multiplication(int a, int b)
        {
            return a * b;
        }

        int ICalculator.ICalculator.Division(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Param -b- can not be zero!");
            else
                return a / b;
        }

        int ICalculator.ICalculator.Modulus(int a, int b)
        {
            return a % b;
        }
    }
}
