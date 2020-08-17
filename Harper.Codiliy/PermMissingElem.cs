using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harper.Codiliy
{
   public class PermMissingElem
    {
        public int Solution(int[] A)
        {

            int count = 1;

            Array.Sort(A);

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != count)
                    return count;
                count++;
            }
            return count;
        }
    }
}
