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

        [TestMethod]
        public void FindEventClassIdEmpty()
        {
            var deserializer = new AutonEventsParser.Deserializer();
            var result = deserializer.FindEventClassId("#&");
            var expected = "No hex data";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindEventClassIdTooSmallData2Chars()
        {
            var deserializer = new AutonEventsParser.Deserializer();
            var result = deserializer.FindEventClassId("12");
            var expected = "At least 2 bytes required";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindEventClassIdTooSmallData3Chars()
        {
            var deserializer = new AutonEventsParser.Deserializer();
            var result = deserializer.FindEventClassId("123");
            // #TODO fix 
            var expected = "No hex data";
            Assert.AreEqual(expected, result);
        }

    }
}
