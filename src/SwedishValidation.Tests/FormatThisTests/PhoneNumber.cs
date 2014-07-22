using Xunit;

namespace SwedishValidation.Tests.FormatThisTests
{
    public class PhoneNumber
    {
        [Fact]
        public void IsValid()
        {
            Assert.Equal(string.Empty, FormatThis.MobilePhoneNumber("019-123123"));
        }

        [Fact]
        public void IsInvalid()
        {
            Assert.Equal(string.Empty, FormatThis.MobilePhoneNumber("08-1231233sa"));
        }
    }
}
