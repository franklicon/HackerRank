namespace HackerRank_Solutions.Solutions
{
    public static class BeautifulDaysAtTheMovies
    {
        public static int BeautifulDays(int i, int j, int k)
        {
            var beautifulDays = 0;
            for(var l=i; l<=j; l++)
            {
                if(Math.Abs(l - Reverse(l)) % k == 0)
                {
                    beautifulDays++;
                }
            }
            return beautifulDays;
        }

        private static int Reverse(int n)
        {
            var reverse = 0;
            while(n > 0)
            {
                reverse = reverse * 10 + n % 10;
                n /= 10;
            }
            return reverse;
        }
    }
}
