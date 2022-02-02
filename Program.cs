// See https://aka.ms/new-console-template for more information
using LineComparisonProblem;
LineProblem line = new LineProblem();
double line1lenght = line.GetLineLength(2,2,4,4);
double line2length = line.GetLineLength(3, 2, 8, 4);
line.CompareLine(line1lenght,line2length);
