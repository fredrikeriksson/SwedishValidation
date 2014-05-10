using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwedishValidation.Tests.FormatThis
{
    [TestClass]
    public class SocialSecurityNumber
    {
        [TestMethod]
        public void IsValid()
        {
            Assert.AreEqual(string.Empty, SwedishValidation.FormatThis.SocialSecurityNumber("750231-0241"));
        }

        [TestMethod]
        public void IsInvalid()
        {
            Assert.AreEqual(string.Empty, SwedishValidation.FormatThis.SocialSecurityNumber("771016-9584"));
        } 
    }
}