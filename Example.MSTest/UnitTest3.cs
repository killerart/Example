using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSTest
{
    [TestClass]
    public class UnitTest3
    {
        static IEnumerable<object[]> TestCases() {
            yield return new object[] { 3, new int[] { 1, 2, 3 } };
            yield return new object[] { 0, new int[0] };
        }

        [DataTestMethod]
        [DynamicData(nameof(TestCases), DynamicDataSourceType.Method)]
        public void DynamicDataTestMethod2(int n, int[] expectedResult) {
            int[] result = Program.GenerateArray(n);
            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}
