using Xunit;

namespace SwedishValidation.Tests.BeAValidTests
{
    public class SocialSecurityNumber
    {
        [Fact]
        public void IsValid()
        {
            Assert.True(BeAValid.SocialSecurityNumber("750231-0241"));
            Assert.True(BeAValid.SocialSecurityNumber("881014-6616"));
        }

        [Fact]
        public void IsValidWithPlus()
        {
            Assert.True(BeAValid.SocialSecurityNumber("750231+0241"));
            Assert.True(BeAValid.SocialSecurityNumber("881014+6616"));
        }

        [Fact]
        public void IsInvalid()
        {
            Assert.False(BeAValid.SocialSecurityNumber("19881014+6616"));
            Assert.False(BeAValid.SocialSecurityNumber("19881014-6616"));
            Assert.False(BeAValid.SocialSecurityNumber("771016-a9584"));
            Assert.False(BeAValid.SocialSecurityNumber("881014*6616"));
            Assert.False(BeAValid.SocialSecurityNumber("881a014*6616"));
            Assert.False(BeAValid.SocialSecurityNumber("881a014*6616"));
            Assert.False(BeAValid.SocialSecurityNumber("881014+661"));
            Assert.False(BeAValid.SocialSecurityNumber("881014-661"));
        }
    }
}