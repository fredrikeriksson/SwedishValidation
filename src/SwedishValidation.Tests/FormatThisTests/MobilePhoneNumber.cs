

using Xunit;

namespace SwedishValidation.Tests.FormatThisTests
{
    public class MobilePhoneNumber
    {
        [Fact]
        public void IsValid()
        {
            Assert.Equal(string.Empty, FormatThis.MobilePhoneNumber("070-1231233"));
        }

        [Fact]
        public void IsInvalid()
        {
            Assert.Equal(string.Empty, FormatThis.MobilePhoneNumber("070-a''1231233"));
        }
    }
}
