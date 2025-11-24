using Xunit;

namespace Stock.Assertions
{
    public class ParameterizedTests
    {
        //[Theory]
        //[InlineData(null)]
        //[InlineData("")]
        //public void Is_invalid_if_email_is_empty_or_null(string? email)
        //{
        //    var isValid = isValidEmail(email!);

        //    Assert.False(isValid);
        //}

        //private bool isValidEmail(string v)
        //{
        //    throw new NotImplementedException();
        //}

        [Theory]
        [InlineData(5, 9, 14)]
        [InlineData(10, 50, 60)]
        [InlineData(-1, 1, 0)]
        public void AddingNumbersTest(int a, int b, int expected)
        {
            int result = a + b;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Kan", "Ye", "Kan Ye")]
        [InlineData("", "x", " x")]
        public void ConcatTest(string a, string b, string expected)
        {
            string result = a + " " + b;
            Assert.Equal(expected, result);
        }
    }
}
