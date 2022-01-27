using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class LineProblem
    {
        private double line1Length, line2Length;
        public void GetLine1Length(int x1,int y1,int x2,int y2)
        {
            line1Length = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y2),2));
        }

        public void GetLine2Length(int x1, int y1, int x2, int y2)
        {
            line2Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y2), 2));
        }
        public void CompareLine()
        {

            if (line1Length == line2Length)
            {
                Console.WriteLine("Both line are equal in length");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
        }
    }
    
}
