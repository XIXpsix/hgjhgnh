using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp20.Logic;
using System;

namespace ConsoleApp20.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSwapPairs()
        {
            // Arrange
            string input = "abcd";
            string expected = "badc";

            // Act
            string result = StringProcessor.SwapPairs(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestProcessTask2()
        {
            // Arrange
            string input = "молоко";
            string expected = "моко__";

            // Act
            string result = StringProcessor.ProcessTask2(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMoveFirstToLast()
        {
            // Arrange
            string input = "abcde";
            string expected = "bcdea";

            // Act
            string result = StringProcessor.MoveFirstToLast(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}