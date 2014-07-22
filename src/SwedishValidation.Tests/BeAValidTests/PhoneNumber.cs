using Xunit;

namespace SwedishValidation.Tests.BeAValidTests
{
    public class PhoneNumber
    {
        [Fact]
        public void IsValid()
        {
            Assert.True(BeAValid.PhoneNumber("019-12 31 23"));
        }

        [Fact]
        public void IsValidWithoutSpaces()
        {
            Assert.True(BeAValid.PhoneNumber("019-123123"));
        }

        [Fact]
        public void IsValidWithoutSpacesAndDelimiter()
        {
            Assert.True(BeAValid.PhoneNumber("019123123"));
        }

        [Fact]
        public void IsValidWithCountryCode()
        {
            Assert.True(BeAValid.PhoneNumber("+46 19 12 31 23"));
        }

        [Fact]
        public void IsValidWithCountryCodeWithoutSpaces()
        {
            Assert.True(BeAValid.PhoneNumber("+4619123123"));
        }

        [Fact]
        public void IsInvalid()
        {
            Assert.False(BeAValid.PhoneNumber("08-1231233sa"));
        }

        [Fact]
        public void IsInvalidWithStartingA()
        {
            Assert.False(BeAValid.MobilePhoneNumber("a08-214 82 85"));
        }
        [Fact]
        public void IsInvalidWithEndingA()
        {
            Assert.False(BeAValid.MobilePhoneNumber("08-114 82 85A"));
        }

        [Fact]
        public void IsInvalidNoStartingZero()
        {
            Assert.False(BeAValid.PhoneNumber("17301230203"));
        }

        [Fact]
        public void IsInvalidTooMany()
        {
            Assert.False(BeAValid.PhoneNumber("17301230203123123123"));
        }
    }
}
