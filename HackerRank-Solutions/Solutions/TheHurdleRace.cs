namespace HackerRank_Solutions.Solutions
{
    public static class TheHurdleRace
    {
        public static int HurdleRace(int k, List<int> height)
        {
            var maxHeight = height.Max();
            return maxHeight - k > 0 ? maxHeight - k : 0;
        }
    }
}
