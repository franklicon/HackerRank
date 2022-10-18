using HackerRank_Solutions.Solutions;

namespace HackerRank_Tests.Tests
{
    [TestClass]
    public class UtopianTreeTest
    {
        [TestMethod]
        public void UtopianTreeTest1()
        {
            // Arrange
            var n = 5;
            var expectedHeight = 14;

            // Act
            var actualHeight = UtopianTree.UtopianTreeSolution(n);

            // Assert
            Assert.AreEqual(expectedHeight, actualHeight);
        }

        [TestMethod]
        public void UtopianTreeTest2()
        {
            // Arrange 
            var n = 55;
            var expectedHeight = 536870910;

            // Act
            var actualHeight = UtopianTree.UtopianTreeSolution(n);

            // Assert 
            Assert.AreEqual(expectedHeight, actualHeight);
        }

    }
}
