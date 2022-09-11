using HackerRank_Solutions.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Solutions_Tests.Tests
{
    [TestClass]
    public class AngryProfessorTest
    {
        [TestMethod]
        public void AngryProfessorTest1()
        {
            // Arrange 
            var k = 3;
            var a = new List<int> { -2, -1, 0, 1, 2 };
            var expectedResult = "NO"; ;

            // Act
            var actualResult = AngryProfessor.AngryProfessorSolution(k, a);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AngryProfessorTest2()
        {
            // Arrange 
            var k = 28;
            var a = new List<int> 
            {
                12, -77, -36, 76, -7, -57, 99, -27, 36, 18,
                -63, -44, -5, 91, -55, 89, 93, 5, 22, 17,
                93, 26, -86, -43, 14, -79, -62, -88, -10, 94,
                -46, -37, -53, -73, 25, -10, 17, 63,-90, 30,
                71, -33, -89, -4, -5, 68, -85, 95, -49, 67
            };

            var expectedResult = "YES"; ;

            // Act
            var actualResult = AngryProfessor.AngryProfessorSolution(k, a);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
