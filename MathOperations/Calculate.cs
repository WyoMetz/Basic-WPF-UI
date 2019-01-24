using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public class Calculate
    {
        public int x { get; set; }
        public int y { get; set; }
        public bool isIncorrect { get; set; }

        public int Addition()
        {
            return x + y;
        }

        public int Multiplication()
        {
            return x * y;
        }

        public string Division()
        {
            if (x == 0 || y == 0)
            {
                isIncorrect = true;
                return ValueFailed();
            }
            else
            {
                return (x / y).ToString();
            }
        }

        public int Subtraction()
        {
            return x - y;
        }

        public string ValueFailed()
        {
            return "Cannot Divide by Zero";
        }
    }
}
