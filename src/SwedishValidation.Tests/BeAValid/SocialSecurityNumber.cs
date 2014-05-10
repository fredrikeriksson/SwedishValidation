using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwedishValidation.Tests.BeAValid
{
    [TestClass]
    public class SocialSecurityNumber
    {
        [TestMethod]
        public void IsValid()
        {
            Assert.IsTrue(SwedishValidation.BeAValid.SocialSecurityNumber("750231-0241"));
            Assert.IsTrue(SwedishValidation.BeAValid.SocialSecurityNumber("881014-6616"));
            Assert.IsTrue(SwedishValidation.BeAValid.SocialSecurityNumber("881014+6616"));
        }

        [TestMethod]
        public void IsInvalid()
        {
            Assert.IsFalse(SwedishValidation.BeAValid.SocialSecurityNumber("771016-a9584"));
            Assert.IsFalse(SwedishValidation.BeAValid.SocialSecurityNumber("881014*6616"));
            Assert.IsFalse(SwedishValidation.BeAValid.SocialSecurityNumber("881a014*6616"));
            Assert.IsFalse(SwedishValidation.BeAValid.SocialSecurityNumber("881a014*6616"));
            Assert.IsFalse(SwedishValidation.BeAValid.SocialSecurityNumber("881014+661"));
            Assert.IsFalse(SwedishValidation.BeAValid.SocialSecurityNumber("881014-661"));
        } 
    }
}