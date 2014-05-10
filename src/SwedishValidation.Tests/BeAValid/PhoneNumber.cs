using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwedishValidation.Tests.BeAValid
{
    [TestClass]
    public class PhoneNumber
    {
        [TestMethod]
        public void IsValid()
        {
            Assert.IsTrue(SwedishValidation.BeAValid.MobilePhoneNumber("019-123123"));
        }

        [TestMethod]
        public void IsInvalid()
        {
            Assert.IsTrue(SwedishValidation.BeAValid.MobilePhoneNumber("08-1231233sa"));
        }
    }
}
