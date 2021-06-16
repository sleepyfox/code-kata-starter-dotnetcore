using System;
using Xunit;

namespace code_kata_starter_dotnetcore
{
    public class UnitTest1
    {
        [Fact]
        public void FailingTest()
        {
            Assert.Equal(42, 6 * 9);
        }
    }
}
