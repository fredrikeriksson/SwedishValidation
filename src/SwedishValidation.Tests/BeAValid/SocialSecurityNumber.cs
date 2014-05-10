using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwedishValidation.Tests.BeAValid
{
    [TestClass]
    public class SocialSecurityNumber
    {
        [TestMethod]
        public void IsValid()
        {
            Assert.IsTrue(SwedishValidation.BeAValid.SocialSecurityNumber("771016-9584"));
        }

        [TestMethod]
        public void IsInvalid()
        {
            Assert.IsTrue(SwedishValidation.BeAValid.SocialSecurityNumber("771016-a9584"));
        } 
    }
}