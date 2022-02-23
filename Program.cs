using System;


namespace OOPS_Line_Length
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line length program of OOPS Concept");
            LengthOfLine line1 = new LengthOfLine(5, 4, 6, 7);
            double lineLength1 = line1.lineLength();
            LengthOfLine line2 = new LengthOfLine(7, 8, 9, 2);
            double lineLength2 = line2.lineLength();
            int result = lineLength1.CompareTo(lineLength2);
            switch (result)
            {
                case 0:
                    Console.WriteLine("Two lines are equal");
                    break;
                case 1:
                    Console.WriteLine("Line 1 is greater than Line 2");
                    break;
                default:
                    Console.WriteLine("Line 2 is greater than Line 1");
                    break;
            }
        }
    }

}
