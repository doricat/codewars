using NUnit.Framework;
using Solutions;

namespace Tests
{
    public class ProductOfConsecutiveFibNumbersTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var o = new ProductOfConsecutiveFibNumbers();
            var tuple = o.ProductFib(714);
            Assert.AreEqual(tuple.Item1, 21);
            Assert.AreEqual(tuple.Item2, 34);
            Assert.AreEqual(tuple.Item3, true);
        }

        [Test]
        public void Test2()
        {
            var o = new ProductOfConsecutiveFibNumbers();
            var tuple = o.ProductFib(800);
            Assert.AreEqual(tuple.Item1, 34);
            Assert.AreEqual(tuple.Item2, 55);
            Assert.AreEqual(tuple.Item3, false);
        }

        [Test]
        public void Test3()
        {
            var o = new ProductOfConsecutiveFibNumbers();
            var tuple = o.ProductFib(4895);
            Assert.AreEqual(tuple.Item1, 55);
            Assert.AreEqual(tuple.Item2, 89);
            Assert.AreEqual(tuple.Item3, true);
        }
    }
}