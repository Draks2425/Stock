using System;
using Xunit;

namespace Stock.Assertions
{
    public class AssertionsSamples
    {
        [Fact]
        public void EqualTest()
        {
            int expected = 5;
            int actual = 2 + 3;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TrueTest()
        {
            bool condition = (10 > 5);
            Assert.True(condition);
        }

        [Fact]
        public void FalseTest()
        {
            bool condition = (2 > 10);
            Assert.False(condition);
        }

        [Fact]
        public void NullTest()
        {
            object obj = null;
            Assert.Null(obj);
        }

        [Fact]
        public void NotNullTest()
        {
            object obj = new object();
            Assert.NotNull(obj);
        }

        [Fact]
        public void ThrowsTest()
        {
            void Throwing() => throw new InvalidOperationException("boom");
            Assert.Throws<InvalidOperationException>(() => Throwing());
        }
    }
}
