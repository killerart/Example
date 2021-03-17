using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.NUnit
{
    public class UnitTest2
    {
        static readonly TestCaseData[] TestCases = new[] {
            new TestCaseData(new int[] { 1, 2, 3 }) {
                ExpectedResult = 6
            },
            new TestCaseData(new int[] { -1, -2, 3 }) {
                ExpectedResult = 0
            },
            new TestCaseData(new int[] { -1, 2, -3, 4 }) {
                ExpectedResult = 2
            }
        };

        [Theory]
        [TestCaseSource(nameof(TestCases))]
        public int SumTest(int[] array) {
            int result = Program.Sum(array);
            return result;
        }
    }
}
