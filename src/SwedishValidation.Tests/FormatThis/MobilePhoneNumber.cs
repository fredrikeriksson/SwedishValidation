using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwedishValidation.Tests.FormatThis
{
    [TestClass]
    public class MobilePhoneNumber
    {
        [TestMethod]
        public void IsValid()
        {
            Assert.AreEqual(string.Empty, SwedishValidation.FormatThis.MobilePhoneNumber("070-1231233"));
        }

        [TestMethod]
        public void IsInvalid()
        {
            Assert.AreEqual(string.Empty, SwedishValidation.FormatThis.MobilePhoneNumber("070-a''1231233"));
        }
    }
}
