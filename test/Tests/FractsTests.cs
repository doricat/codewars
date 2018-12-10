using NUnit.Framework;
using Solutions;

namespace Tests
{
    public class FractsTests
    {
        [Test]
        public void Test1()
        {
            var lst = new long[,] {{1, 2}, {1, 3}, {1, 4}};
            Assert.AreEqual("(6,12)(4,12)(3,12)", Fracts.ConvertFrac(lst));
        }
    }
}