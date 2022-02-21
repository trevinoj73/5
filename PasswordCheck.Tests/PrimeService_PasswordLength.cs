using Xunit;
using Password.Check;

namespace Prime.UnitTests.Services
{
    public class PasswordCheck_PasswordLength
    {
        [Fact]
        public void PasswordCheck_InputIs1_ReturnFalse()
        {
            var passwordCheck = new PasswordCheck();
            bool result = passwordCheck.Equals(1);

            Assert.False(result, "Password must be at least 8 characters long.");
        }
    }
}