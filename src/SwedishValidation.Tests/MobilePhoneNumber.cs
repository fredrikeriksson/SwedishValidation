using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwedishValidation.Tests
{
    [TestClass]
    public class MobilePhoneNumber
    {
        [TestMethod]
        public void IsValid()
        {
            Assert.IsTrue(BeAValid.MobilePhoneNumber("070-1231233"));
        }

        [TestMethod]
        public void IsInvalid()
        {
            Assert.IsTrue(BeAValid.MobilePhoneNumber("070-a''1231233"));
        }
    }
}
