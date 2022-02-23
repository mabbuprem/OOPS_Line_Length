using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Line_Length
{
    internal class LengthOfLine
    {
        public double valueOfX1;
        public double valueOfX2;
        public double valueOfY1;
        public double valueOfY2;

        public LengthOfLine(double valueOfX1, double valueOfX2, double valueOfY1, double valueOfY2)
        {
            this.valueOfX1 = valueOfX1;
            this.valueOfX2 = valueOfX2;
            this.valueOfY1 = valueOfY1;
            this.valueOfY2 = valueOfY2;
        }
        public void lineLength()
        {


            double lengthOfALine = Math.Pow(Math.Pow(valueOfX2 - valueOfY1, 2) + Math.Pow(valueOfX2 + valueOfY1, 2), 0.5);
            Console.WriteLine(lengthOfALine);

        }
    }
}
