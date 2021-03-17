using System;
using System.Linq;

namespace Example
{
    public class Program
    {
        static void Main() { }

        public static int Add(int a, int b) {
            return a + b;
        }

        public static int Sum(int[] array) {
            int sum = 0;
            for (int i = 0; i < array.Length; i++) {
                sum += array[i];
            }
            return sum;
            //return array.Sum();
        }

        public static int[] GenerateArray(int n) {
            int[] array = new int[n];
            for (int i = 0; i < n; i++) {
                array[i] = i + 1;
            }
            return array;
            //return Enumerable.Range(1, n).ToArray();
        }
    }
}
