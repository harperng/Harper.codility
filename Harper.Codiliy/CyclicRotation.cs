using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Harper.Codiliy
{
   public class CyclicRotation
    {
        public int[] Solution(int[] A, int K)
        {
            int[] newArr = new int[A.Length];

            if (A.Length == 0) return A;
            K = K % A.Length;
            for (int i = 0; i < A.Length; i++)
            {
                newArr[i] = A[(i + (A.Length - K)) % (A.Length)];

            }
            return newArr;

        }
 
    }
}
