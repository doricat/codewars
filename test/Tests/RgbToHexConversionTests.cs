using NUnit.Framework;
using Solutions;

namespace Tests
{
    public class RgbToHexConversionTests
    {
        [Test]
        public void FixedTests()
        {
            Assert.AreEqual("FFFFFF", RgbToHexConversion.Rgb(255, 255, 255));
            Assert.AreEqual("FFFFFF", RgbToHexConversion.Rgb(255, 255, 300));
            Assert.AreEqual("000000", RgbToHexConversion.Rgb(0, 0, 0));
            Assert.AreEqual("9400D3", RgbToHexConversion.Rgb(148, 0, 211));
            Assert.AreEqual("9400D3", RgbToHexConversion.Rgb(148, -20, 211), "Handle negative numbers.");
            Assert.AreEqual("90C3D4", RgbToHexConversion.Rgb(144, 195, 212));
            Assert.AreEqual("D4350C", RgbToHexConversion.Rgb(212, 53, 12), "Consider single hex digit numbers.");
        }
    }
}