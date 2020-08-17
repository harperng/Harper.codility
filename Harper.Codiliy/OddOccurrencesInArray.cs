using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Harper.Codiliy
{
  public  class OddOccurrencesInArray
    {
        public int Solution(int[] A)
        {

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                    continue;
                Boolean f = false;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] == 0) continue;
                    if (A[i] == A[j])
                    {
                        A[i] = A[j] = 0;
                        f = true;
                    }
                }
                if (!f)
                    return A[i];
            }
            return 0;
        }
    }
}
