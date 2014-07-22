using Xunit;

namespace SwedishValidation.Tests.BeAValidTests
{
    public class MobilePhoneNumber
    {
        [Fact]
        public void IsValid()
        {
            Assert.True(BeAValid.MobilePhoneNumber("073-6148285"));
        }

        [Fact]
        public void IsValidWithCountryCode()
        {
            Assert.True(BeAValid.MobilePhoneNumber("+46736148285"));
        }

        [Fact]
        public void IsValidWithoutSpaces()
        {
            Assert.True(BeAValid.MobilePhoneNumber("073-6148285"));
        }

        [Fact]
        public void IsValidWithoutSpacesAndDelimiter()
        {
            Assert.True(BeAValid.PhoneNumber("0736148285"));
        }

        [Fact]
        public void IsValidWithCountryCodeWithoutSpaces()
        {
            Assert.True(BeAValid.MobilePhoneNumber("+46736148285"));
        }

        [Fact]
        public void IsValidWithMixedSpaces()
        {
            Assert.True(BeAValid.MobilePhoneNumber("073-614  82 85"));
        }

        [Fact]
        public void IsValidWithCountryCodeWithMixedSpaces()
        {
            Assert.True(BeAValid.MobilePhoneNumber("+467361 482  85"));
        }

        [Fact]
        public void IsInvalid()
        {
            Assert.False(BeAValid.MobilePhoneNumber("073-a14 82 85"));
        }

        [Fact]
        public void IsInvalidWithStartingA()
        {
            Assert.False(BeAValid.MobilePhoneNumber("a073-214 82 85"));
        }
        [Fact]
        public void IsInvalidWithEndingA()
        {
            Assert.False(BeAValid.MobilePhoneNumber("073-214 82 85A"));
        }

        [Fact]
        public void IsInvalidNoStartingZero()
        {
            Assert.False(BeAValid.PhoneNumber("173-114 82 85"));
        }

        [Fact]
        public void IsInvalidTooMany()
        {
            Assert.False(BeAValid.PhoneNumber("17301230203123123123"));
        }
    }
}
