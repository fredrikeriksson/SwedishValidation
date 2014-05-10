using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwedishValidation.Tests
{
    [TestClass]
    public class SocialSecurityNumber
    {
        [TestMethod]
        public void IsValid()
        {
            Assert.IsTrue(BeAValid.SocialSecurityNumber("771016-9584"));
        }

        [TestMethod]
        public void IsInvalid()
        {
            Assert.IsTrue(BeAValid.SocialSecurityNumber("771016-a9584"));
        } 
    }
}