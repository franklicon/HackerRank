using HackerRank_Solutions.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Solutions_Tests.Tests
{
    [TestClass]
    public class BeautifulDaysAtTheMoviesTest
    {
        [TestMethod]
        public void BeautifulDaysAtTheMoviesTest1()
        {
            // Arrange
            var i = 20;
            var j = 23;
            var k = 6;
            var expectedBeautifulDays = 2;

            // Act
            var actualBeautifulDays = BeautifulDaysAtTheMovies.BeautifulDays(i, j, k);

            // Assert
            Assert.AreEqual(expectedBeautifulDays, actualBeautifulDays);
        }

        [TestMethod]
        public void BeautifulDaysAtTheMoviesTest2()
        {
            // Arrange
            var i = 1;
            var j = 123456;
            var k = 13;
            var expectedBeautifulDays = 9657;

            // Act
            var actualBeautifulDays = BeautifulDaysAtTheMovies.BeautifulDays(i, j, k);

            // Assert
            Assert.AreEqual(expectedBeautifulDays, actualBeautifulDays);
        }
    }
}
