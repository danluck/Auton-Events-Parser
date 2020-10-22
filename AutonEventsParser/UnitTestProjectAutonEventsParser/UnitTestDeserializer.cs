using System;
using AutonEventsParser;
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

            var inputDataFormat = InputDataFormats.Hex;
            var result = deserializer.GetByteArrayLength("", inputDataFormat);
            var expected = (uint)0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetByteArrayLengthNotHexCode()
        {
            var deserializer = new AutonEventsParser.Deserializer();

            var inputDataFormat = InputDataFormats.Hex;
            var result = deserializer.GetByteArrayLength("#&", inputDataFormat);
            var expected = (uint)0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindEventClassIdEmpty()
        {
            var deserializer = new AutonEventsParser.Deserializer();
            var inputDataFormat = InputDataFormats.Hex;
            var result = deserializer.FindEventClassId("#&", inputDataFormat);
            var expected = "No hex data";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindEventClassIdTooSmallData2Chars()
        {
            var deserializer = new AutonEventsParser.Deserializer();
            var inputDataFormat = InputDataFormats.Hex;
            var result = deserializer.FindEventClassId("12", inputDataFormat);
            var expected = "At least 2 bytes required";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindEventClassIdTooSmallData3Chars()
        {
            var deserializer = new AutonEventsParser.Deserializer();
            var inputDataFormat = InputDataFormats.Hex;
            var result = deserializer.FindEventClassId("123", inputDataFormat);
            // #TODO fix 
            var expected = "No hex data";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetClassIdHexEmpty()
        {
            var deserializer = new AutonEventsParser.Deserializer();

            var inputDataFormat = InputDataFormats.Hex;
            var result = deserializer.GetClassId("", inputDataFormat);
            var expected = (UInt16)0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetClassIdHexZero()
        {
            var deserializer = new AutonEventsParser.Deserializer();

            var inputDataFormat = InputDataFormats.Hex;
            var result = deserializer.GetClassId("0000", inputDataFormat);
            var expected = (UInt16)0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetClassIdHexFFFF()
        {
            var deserializer = new AutonEventsParser.Deserializer();

            var inputDataFormat = InputDataFormats.Hex;
            var result = deserializer.GetClassId("FFFF", inputDataFormat);
            var expected = (UInt16)0xFFFF;
            Assert.AreEqual(expected, result);
        }
    }
}
