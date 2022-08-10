namespace HackerRank_Solutions.Solutions
{
    public static class SalesByMatch
    {
        public static int SockMerchant(int n, List<int> ar)
        {
            var hashSet = new HashSet<int>();
            var pairs = 0;

            for (var i = 0; i < n; i++)
            {
                if (!hashSet.Contains(ar[i]))
                {
                    hashSet.Add(ar[i]);
                }
                else
                {
                    pairs++;
                    hashSet.Remove(ar[i]);
                }
            }
            return pairs;
        }
    }
}
