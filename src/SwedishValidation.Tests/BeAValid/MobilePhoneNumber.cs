using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwedishValidation.Tests.BeAValid
{
    [TestClass]
    public class MobilePhoneNumber
    {
        [TestMethod]
        public void IsValid()
        {
            Assert.IsTrue(SwedishValidation.BeAValid.MobilePhoneNumber("073-614 82 85"));
        }

        [TestMethod]
        public void IsInvalid()
        {
            Assert.IsFalse(SwedishValidation.BeAValid.MobilePhoneNumber("073-a14 82 85"));
        }
    }
}
