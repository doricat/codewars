using System;
using NUnit.Framework;
using Solutions;

namespace Tests
{
    public class SpellingBeeTests
    {
        [Test]
        public void BasicTests()
        {
            char[][] hive = {
                "bee.bee".ToCharArray(),
                ".e..e..".ToCharArray(),
                ".b..eeb".ToCharArray()
            };

            Assert.AreEqual(5, SpellingBee.HowManyBees(Show(hive)));

            Console.WriteLine("<hr>");

            hive = new[]
            {
                "bee.bee".ToCharArray(),
                "e.e.e.e".ToCharArray(),
                "eeb.eeb".ToCharArray()
            };

            Assert.AreEqual(8, SpellingBee.HowManyBees(Show(hive)));
        }

        private static char[][] Show(char[][] hive)
        {
            foreach (var t in hive)
                Console.WriteLine(t);
            return hive;
        }
    }
}