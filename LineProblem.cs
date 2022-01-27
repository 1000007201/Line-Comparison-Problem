using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class LineProblem
    {
        public void GetLineLength(int x1,int y1,int x2,int y2)
        {
            double lineLength = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y2),2));
            Console.WriteLine("Length of a line is {0}",lineLength);
        }
    }
}
