using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwedishValidation.Tests
{
    [TestClass]
    public class PhoneNumber
    {
        [TestMethod]
        public void IsValid()
        {
            Assert.IsTrue(BeAValid.MobilePhoneNumber("019-123123"));
        }

        [TestMethod]
        public void IsInvalid()
        {
            Assert.IsTrue(BeAValid.MobilePhoneNumber("08-1231233sa"));
        }
    }
}
