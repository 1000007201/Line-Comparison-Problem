using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class LineProblem
    {
        private double length;
        public double GetLineLength(int x1,int y1,int x2,int y2)
        {
            length = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y2),2));
            return length;
        }

        public void CompareLine(double line1Length,double line2Length)
        {

            if (line1Length == line2Length)
            {
                Console.WriteLine("Both line are equal in length");
            }
            if (line1Length > line2Length)
            {
                Console.WriteLine("Line 1 is longer than Line 2");
            }
            if (line2Length > line1Length)
            {
                Console.WriteLine("Line 2 is longer than Line 1");
            }

        }
    }
    
}
