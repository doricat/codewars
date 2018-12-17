using NUnit.Framework;
using Solutions;

namespace Tests
{
    public class CrisisTests
    {
        [Test]
        public void ExampleTest1()
        {
            var expected = "Yes";
            var actual = Crisis.HelpZoom(new[] {1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1});
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExampleTest2()
        {
            var expected = "No";
            var actual = Crisis.HelpZoom(new[] {1, 1, 0, 0, 0, 0, 1, 1, 0});
            Assert.AreEqual(expected, actual);
        }
    }
}