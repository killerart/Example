using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSTest
{
    [TestClass]
    public class UnitTest2
    {
        static IEnumerable<object[]> TestCases() {
            yield return new object[] { new int[] { 1, 2, 3 }, 6 };
            yield return new object[] { new int[] { -1, -2, 3 }, 0 };
            yield return new object[] { new int[] { -1, 2, -3, 4 }, 2 };
        }

        [DataTestMethod]
        [DynamicData(nameof(TestCases), DynamicDataSourceType.Method)]
        public void SumTestMethod(int[] array, int expectedResult) {
            int result = Program.Sum(array);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
