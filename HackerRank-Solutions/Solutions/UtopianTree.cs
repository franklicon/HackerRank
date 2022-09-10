using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Solutions.Solutions
{
    public static class UtopianTree
    {
        public static int UtopianTreeSolution(int n)
        {
            var height = 1;
            for(var i =1; i<=n; i++)
            {
                height = i % 2 == 0 ? height += 1 : height *= 2;
            }
            return height;
        }
    }
}
