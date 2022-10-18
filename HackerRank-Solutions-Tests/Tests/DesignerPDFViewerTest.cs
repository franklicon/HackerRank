using HackerRank_Solutions.Solutions;

namespace HackerRank_Tests.Tests
{
    [TestClass]
    public class DesignerPDFViewerTest
    {
        [TestMethod]
        public void DesignerPDFViewerTest1()
        {
            // Arrange 
            var h = new List<int> 
            {
                1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 
                5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 
            };
            var word = "abc";
            var expectedHighlightedArea = 9;

            // Act
            var actualHighlightedArea = DesignerPDFViewer.DesignerPdfViewer(h, word);

            // Assert
            Assert.AreEqual(expectedHighlightedArea, actualHighlightedArea);
        }

        [TestMethod]
        public void DesignerPDFViewerTest2()
        {
            // Arrange 
            var h = new List<int>
            {
                1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5,
                5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7
            };
            var word = "zaba";
            var expectedHighlightedArea = 28;

            // Act
            var actualHighlightedArea = DesignerPDFViewer.DesignerPdfViewer(h, word);

            // Assert
            Assert.AreEqual(expectedHighlightedArea, actualHighlightedArea);
        }
    }
}
