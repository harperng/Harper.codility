﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harper.Codiliy
{
   public class TapeEquilibrium
    {
        public int Solution(int[] A)
        {
            long sumright = 0;
            long sumleft = 0;
            long ans;

            for (int i = 1; i < A.Length; i++)
                sumright += A[i];

            sumleft = A[0];
            ans = Math.Abs(Math.Abs(sumright) + Math.Abs(sumleft));

            for (int P = 1; P < A.Length; P++)
            {
                if (Math.Abs(Math.Abs(sumleft) - Math.Abs(sumright)) < ans)
                    ans = Math.Abs(Math.Abs(sumleft) - Math.Abs(sumright));
                sumleft += A[P];
                sumright -= A[P];
            }
            return (int)ans;

        }
    }
}
