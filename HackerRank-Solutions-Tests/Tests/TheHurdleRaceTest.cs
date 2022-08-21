﻿using HackerRank_Solutions.Solutions;

namespace HackerRank_Solutions_Tests.Tests
{
    [TestClass]
    public class TheHurdleRaceTest
    {
        [TestMethod]
        public void TheHurdleRaceTest1()
        {
            // Arrange 
            var k = 4;
            var heights = new List<int> { 1, 6, 3, 5, 2 };
            var expectedNumberOfDoses = 2;

            // Act
            var actualNumberOfDoses = TheHurdleRace.HurdleRace(k, heights);

            // Assert
            Assert.AreEqual(expectedNumberOfDoses, actualNumberOfDoses);
        }

        [TestMethod]
        public void TheHurdleRaceTest2()
        {
            // Arrange 
            var k = 87;
            var heights = new List<int> 
            { 
                56, 61, 6, 83, 54, 85, 43, 21, 63, 76, 79, 39, 78, 84, 71, 10, 86, 58, 2, 35, 71, 23, 46, 21, 61, 
                64, 54, 6, 16, 36, 22, 3, 37, 25, 71, 66, 9, 80, 51, 58, 63, 84, 64, 38, 66, 19, 47, 16, 66, 57, 73, 
                77, 13, 22, 79, 14, 5, 86, 5, 28, 81, 85, 59, 28, 67, 53, 74, 47, 50, 70, 17, 61, 33, 38, 52, 64, 84, 
                51, 3, 58, 68, 80, 68, 38, 56, 12, 69, 34, 21, 19, 83, 8, 84, 27, 5, 39, 5, 7, 44, 74
             };
            var expectedNumberOfDoses = 0;

            // Act
            var actualNumberOfDoses = TheHurdleRace.HurdleRace(k, heights);

            // Assert
            Assert.AreEqual(expectedNumberOfDoses, actualNumberOfDoses);
        }
    }
}
