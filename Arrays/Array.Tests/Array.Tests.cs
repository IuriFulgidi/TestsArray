using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayLibrary;

namespace Array.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] start = { 1, 2, 3, 4, 5 };
            int[] expected = { 11, 12, 13, 14, 15 };

            int[] obtained = ArrayLibrary.Array.Incremento_1(start);

            CollectionAssert.AreEqual(expected, obtained);
        }
    }
}
