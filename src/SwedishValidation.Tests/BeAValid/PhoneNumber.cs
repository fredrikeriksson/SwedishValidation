using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwedishValidation.Tests.BeAValid
{
    [TestClass]
    public class PhoneNumber
    {
        [TestMethod]
        public void IsValid()
        {
            Assert.IsTrue(SwedishValidation.BeAValid.PhoneNumber("019-12 31 23"));
            Assert.IsTrue(SwedishValidation.BeAValid.PhoneNumber("070-614 82 85"));
        }

        [TestMethod]
        public void IsInvalid()
        {
            Assert.IsFalse(SwedishValidation.BeAValid.PhoneNumber("08-1231233sa"));
        }
    }
}
