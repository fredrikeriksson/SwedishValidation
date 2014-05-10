using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwedishValidation.Tests.BeAValid
{
    [TestClass]
    public class MobilePhoneNumber
    {
        [TestMethod]
        public void IsValid()
        {
            Assert.IsTrue(SwedishValidation.BeAValid.MobilePhoneNumber("070-1231233"));
        }

        [TestMethod]
        public void IsInvalid()
        {
            Assert.IsTrue(SwedishValidation.BeAValid.MobilePhoneNumber("070-a''1231233"));
        }
    }
}
