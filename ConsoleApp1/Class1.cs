using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        public int[] solution(int[] A, int K)
        {
            int[] newArr = new int[A.Length];

            if (A.Length == 0) return A;
             K=K % A.Length;
            for (int i = 0; i < A.Length; i++)
            {

                newArr[i] = A[(i + (A.Length - K)) % (A.Length)];

            }

            return newArr;
        }
    }
}
