using System;


namespace OOPS_Line_Length
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to line length program of OOPS Concept");
            LengthOfLine lengthOfLine1 = new LengthOfLine(5, 4, 6, 7);
            lengthOfLine1.lineLength();
            LengthOfLine lengthOfLine2 = new LengthOfLine(7, 8, 9, 2);
            lengthOfLine2.lineLength();
            string result = lengthOfLine1.Equals(lengthOfLine2) == true ? "Two lines are equal" : "Two lines are not equal";
            Console.WriteLine(result);
        }
    }

}
