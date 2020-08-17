using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harper.Codiliy
{
    public class FrogJmp
    {
        public int Solution(int X, int Y, int D)
        {
            int i = 0;
            while (X < Y)
            {
                i++;
                X = X + D;

            }
            return i;
        }

    }
}
