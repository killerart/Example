using NUnit.Framework;

namespace Example.NUnit
{
    public class UnitTest1
    {
        [Test]
        public void Test1() {
            int result1 = Program.Add(3, 6);
            Assert.AreEqual(9, result1);

            int result2 = Program.Sum(new int[] { 1, 2, 3 });
            Assert.That(6 == result2);

            int[] result3 = Program.GenerateArray(5);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, result3);
        }

        [Theory]
        [TestCase(3, 6, ExpectedResult = 9)]
        [TestCase(-5, 8, ExpectedResult = 3)]
        [TestCase(5, -8, ExpectedResult = -3)]
        public int DataTestMethod(int a, int b) {
            int result = Program.Add(a, b);
            return result;
        }
    }
}