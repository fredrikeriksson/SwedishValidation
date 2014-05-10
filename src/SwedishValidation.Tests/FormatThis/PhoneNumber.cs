using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwedishValidation.Tests.FormatThis
{
    [TestClass]
    public class PhoneNumber
    {
        [TestMethod]
        public void IsValid()
        {
            Assert.AreEqual(string.Empty, SwedishValidation.FormatThis.MobilePhoneNumber("019-123123"));
        }

        [TestMethod]
        public void IsInvalid()
        {
            Assert.AreEqual(string.Empty, SwedishValidation.FormatThis.MobilePhoneNumber("08-1231233sa"));
        }
    }
}
