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

            if (line1Length.Equals(line2Length))
            {
                Console.WriteLine("Both line are equal in length");
            }
            //a>b
            //line1Length>line2Length
            if (line1Length.CompareTo(line2Length)>0)
            {
                Console.WriteLine("Line 1 is longer than Line 2");
            }
            //line1Length<line2Length
            if (line1Length.CompareTo(line2Length)<0)
            {
                Console.WriteLine("Line 2 is longer than Line 1");
            }

        }
    }
    
}
