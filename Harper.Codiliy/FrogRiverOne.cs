using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harper.Codiliy
{
    public class FrogRiverOne
    {
        public int Solution( int X, int[] A)
        {
            int[] count = new int[X + 1];
            int Ans = -1;
            int x = 0;
            for (int i = 0; i < A.Length;i++)
            {
                if (count[A[i]] == 0)
                {
                    count[A[i]] = A[i];
                    x += 1;
                    if (x == X)
                    {
                        return i;
                    }
                }
            }
            return Ans;
        }
    }
}


