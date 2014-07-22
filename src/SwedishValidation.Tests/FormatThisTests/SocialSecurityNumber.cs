using Xunit;

namespace SwedishValidation.Tests.FormatThisTests
{
    public class SocialSecurityNumber
    {
        [Fact]
        public void IsValid()
        {
            Assert.Equal(string.Empty, FormatThis.SocialSecurityNumber("750231-0241"));
        }

        [Fact]
        public void IsValidWithPlus()
        {
            Assert.Equal(string.Empty, FormatThis.SocialSecurityNumber("750231+0241"));
        }

        [Fact]
        public void IsInvalid()
        {
            Assert.Equal(string.Empty, FormatThis.SocialSecurityNumber("771016-9584"));
        }
    }
}