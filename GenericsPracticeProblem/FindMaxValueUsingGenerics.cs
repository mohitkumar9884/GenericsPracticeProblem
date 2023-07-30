using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblem
{
    internal class FindMaxValueUsingGenerics<T> where T: IComparable// client code.
    {
        public T first, second, third;

        public FindMaxValueUsingGenerics(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public static T FindMax(T first, T second, T third)
        {
            //int result = first.CompareTo(second);//0 or 1 or -1
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is greater ", first);
                return first;
            }

            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is greater", second);
                return second;
            }
            else
            {
                Console.WriteLine("{0} is greater", third);
                return third;
            }
        }
        public void TestMaximum()
        {
            T maxValue=FindMax(first, second, third);
            Console.WriteLine("MaxValue is:" + maxValue);
        }
    }
}
