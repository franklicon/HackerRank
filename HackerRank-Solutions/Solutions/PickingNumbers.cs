namespace HackerRank_Solutions.Solutions
{
    public static class PickingNumbers
    {
        public static int PickingNumbersSolution(List<int> a)
        {
            var hashSet = a.ToHashSet();
            var subArraysLength = new int[hashSet.Count];

            for(var i=0; i<hashSet.Count; i++)
            {
                var currentNumber = hashSet.ElementAt(i);
                var equalNumbers = a.FindAll(e => e == currentNumber).Count;
                subArraysLength[i] = Math.Max(a.Where(e => e == currentNumber + 1).Count(), 
                                                a.Where(e => e == currentNumber - 1).Count()) + equalNumbers;
            }

            return subArraysLength.Max();
        }
    }
}
