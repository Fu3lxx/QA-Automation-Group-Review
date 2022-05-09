using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {

        public static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                sum += arr[i];

            }
            return sum;
        }

        public static double Average(int[] arr)
        {
            if (arr.Length < 2)
            {
                throw new ArgumentException("There must be at least two numbers in array");
            }
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];

            }
            return sum / arr.Length;


        }
    }
}
