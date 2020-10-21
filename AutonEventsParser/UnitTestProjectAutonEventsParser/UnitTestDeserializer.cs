using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectAutonEventsParser
{
    [TestClass]
    public class UnitTestDeserializer
    {
        [TestMethod]
        public void GetByteArrayLengthEmpty()
        {
            var deserializer = new AutonEventsParser.Deserializer();

            var result = deserializer.GetByteArrayLength("");
            var expected = (uint)0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetByteArrayLengthNotHexCode()
        {
            var deserializer = new AutonEventsParser.Deserializer();

            var result = deserializer.GetByteArrayLength("#&");
            var expected = (uint)0;
            Assert.AreEqual(expected, result);
        }
    }
}
