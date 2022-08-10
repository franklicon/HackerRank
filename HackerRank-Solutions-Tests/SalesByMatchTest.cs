using HackerRank_Solutions;

namespace HackerRank_Solutions_Tests
{
    [TestClass]
    public class SalesByMatchTest
    {
        [TestMethod]
        public void SocketMerchantTest1()
        {
            // Arrange
            var n = 9;
            var ar = new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            var expectedPairs = 3;

            // Act
            var actualPairs = SalesByMatch.SockMerchant(n, ar);

            // Assert
            Assert.AreEqual(expectedPairs, actualPairs);
        }

        [TestMethod]
        public void SocketMerchantTest2()
        {
            // Arrange
            var n = 15;
            var ar = new List<int>() { 6, 5, 2, 3, 5, 2, 2, 1, 1, 5, 1, 3, 3, 3, 5 };
            var expectedPairs = 6;

            // Act
            var actualPairs = SalesByMatch.SockMerchant(n, ar);

            // Assert
            Assert.AreEqual(expectedPairs, actualPairs);
        }
    }
}
