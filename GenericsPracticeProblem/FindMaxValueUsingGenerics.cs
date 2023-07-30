using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblem
{
    internal class FindMaxValueUsingGenerics<T> where T : IComparable
    {
        public T[] values;

        public FindMaxValueUsingGenerics(params T[] values)
        {
            this.values = values;
        }

        public static T FindMax(T[] values)
        {
            if (values.Length == 0)
            {
                // Return a default value for type T when the array is empty
                return default(T);
            }

            T maxValue = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(maxValue) > 0)
                {
                    maxValue = values[i];
                }
            }
            return maxValue;
        }

        public void TestMaximum()
        {
            T maxValue = FindMax(values);
            if (maxValue == null)
            {
                Console.WriteLine("The array is empty. Cannot find maximum.");
            }
            else
            {
                Console.WriteLine("MaxValue is: " + maxValue);
            }
        }
    }
}
