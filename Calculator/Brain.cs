using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Brain
    {
        public double n1;
        public double n2;
        public double res;

        public double Plus()
        {
            res = n1 + n2;
            return res;
        }

        public double Minus()
        {
            res = n1 - n2;
            return res;
        }

        public double Div()
        {
            res = n1 / n2;
            return res;
        }

        public double Mul()
        {
            res = n1 * n2;
            return res;
        }        
    }
}
