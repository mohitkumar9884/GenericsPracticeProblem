using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblem
{
    internal class FindMaxValueUsingGenerics<T> where T: IComparable
    {
        public static void FindMax(T first, T second, T third)
        {
            //int result = first.CompareTo(second);//0 or 1 or -1

            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                Console.WriteLine("{0} is greater ", first);
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                Console.WriteLine("{0} is greater", second);
            else
                Console.WriteLine("{0} is greater", third);
        }
    }
}
