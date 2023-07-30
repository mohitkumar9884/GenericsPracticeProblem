using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblem
{
    internal class FindMaxValue
    {
        public static void FindMax(int first,int second,int third)
        {
            int result = first.CompareTo(second);//0 or 1 or -1

            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                Console.WriteLine("{0} is greater ", first);
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                Console.WriteLine("{0} is greater", second);
            else
                Console.WriteLine("{0} ise greater", third);
        }
    }
}
