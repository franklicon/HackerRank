namespace HackerRank_Solutions.Solutions
{
    public static class AngryProfessor
    {
        public static string AngryProfessorSolution(int k, List<int> a)
        {
            var arrivedOn = a.Where(s => s <= 0).Count();
            return arrivedOn < k ? "YES" : "NO";
        }
    }
}
