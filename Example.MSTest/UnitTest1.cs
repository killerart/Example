using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Example.MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod() {
            int result1 = Program.Add(3, 6);
            Assert.AreEqual(9, result1);

            int result2 = Program.Sum(new int[] { 1, 2, 3 });
            Assert.AreEqual(6, result2);

            int[] result3 = Program.GenerateArray(5);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, result3);
        }

        [DataTestMethod]
        [DataRow(3, 6, 9)]
        [DataRow(-5, 8, 3)]
        [DataRow(5, -8, -3)]
        public void DataTestMethod(int a, int b, int expectedResult) {
            int result = Program.Add(a, b);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
