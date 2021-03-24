using NUnit.Framework;

namespace Example.NUnit
{
    public class UnitTest3
    {
        static readonly TestCaseData[] TestCases = new[] {
            new TestCaseData(3) {
                ExpectedResult = new int[] { 1, 2, 3 }
            },
            new TestCaseData(0) {
                ExpectedResult = new int[0]
            }
        };

        [Theory]
        [TestCaseSource(nameof(TestCases))]
        public int[] GenerateArrayTest(int n) {
            int[] result = Program.GenerateArray(n);
            return result;
        }
    }
}
