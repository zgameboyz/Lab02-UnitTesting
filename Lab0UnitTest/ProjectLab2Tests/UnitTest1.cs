using System;
using Xunit;
using Lab02UnitTest;


namespace Lab02UnitTest
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            Assert.True(3000 < Program.Deposit(300));
        }
        [Fact]
        public void Test2()
        {
            Assert.True(3 == 3);
        }
    }
}
