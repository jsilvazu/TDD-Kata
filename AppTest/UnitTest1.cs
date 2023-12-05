using App;

namespace AppTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("1", 1)]
        [InlineData("1,1", 2)]
        [InlineData("1,2,3", 6)]
        public void Test1(string s, int n) => Assert.Equal(StringCalculator.Add(s), n);
    }
}