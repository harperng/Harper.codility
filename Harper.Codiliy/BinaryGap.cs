using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Harper.Codiliy
{
	public class BinaryGap
	{
		public int Length { get; private set; }

		/*
public int Solution(int N)
{
int maxGap = 0;
int currentGap = 0;
if (N == 0) return 1;
while (N > 0)
{
if (N % 2 == 0)
{
currentGap++;
if (maxGap < currentGap)
{
maxGap = currentGap;
}
}
else if (N % 2 == 1)
{
currentGap = 0;
}

N = N / 2;
}
//if (N != 1) return 0;
return maxGap;
}
*/
		public int Solution(int N)
		{
			
			if (N <= 2) return 0;
			var binaryStr = Convert.ToString(N, 2);
			binaryStr = binaryStr.TrimEnd(new Char[] { '0' });
			var Gap = binaryStr.Split('1');
			int maxGap = 0;
			foreach (var item in Gap)
			{
				if (!string.IsNullOrEmpty(item))
                 if(item.Length > maxGap)
				  maxGap = item.Length;
			}
			return maxGap;
		}
	}
}
