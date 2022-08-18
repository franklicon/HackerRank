namespace HackerRank_Solutions.Solutions
{
    public static class DesignerPDFViewer
    {
        public static int DesignerPdfViewer(List<int> h, string word)
        {
            var maxHeight = 0;
            foreach (var c in word.Distinct())
            {
                var index = char.ToUpper(c) - 65;
                if (h[index] > maxHeight)
                {
                    maxHeight = h[index];
                }
            }
            return maxHeight * word.Length;
        }
    }
}
