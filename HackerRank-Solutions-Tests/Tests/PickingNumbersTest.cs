using HackerRank_Solutions.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Tests.Tests
{
    [TestClass]
    public class PickingNumbersTest
    {
        [TestMethod]
        public void PickingNumbersTest1()
        {
            // Arrange
            var expectedMaxLength = 22;
            var a = new List<int>
            {
                4, 2, 3, 4, 4, 9, 98, 98, 3, 3, 3, 4, 2,98, 1, 98, 98, 1, 1, 4, 98, 2, 98, 3, 9, 9, 3, 1,
                4, 1, 98, 9, 9, 2, 9, 4, 2, 2, 9, 98, 4, 98, 1, 3, 4, 9, 1, 98, 98, 4, 2, 3, 98, 98, 1, 99,
                9, 98, 98, 3, 98, 98, 4, 98, 2, 98, 4, 2, 1, 1, 9, 2, 4
            };

            // Act
            var actualMaxLength = PickingNumbers.PickingNumbersSolution(a);

            // Assert
            Assert.AreEqual(expectedMaxLength, actualMaxLength);
        }

        [TestMethod]
        public void PickingNumbersTest2()
        {
            // Arrange
            var expectedMaxLength = 5;
            var a = new List<int> { 1, 2, 2, 3, 1, 2 };

            // Act
            var actualMaxLength = PickingNumbers.PickingNumbersSolution(a);

            // Assert
            Assert.AreEqual(expectedMaxLength, actualMaxLength);
        }
    }
}
