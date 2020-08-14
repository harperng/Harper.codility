using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;


using System.Text.RegularExpressions;

namespace ConsoleApp1.Iterations
{
	class Program
	{
		public static void Main()
		{
			
			Console.Write("Nhap mot so thap phan bat ky: ");
			
			int N = Convert.ToInt32(Console.ReadLine());
			int maxGap = 0;
			int currentGap = 0;
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
			Console.Write(maxGap);

			Console.ReadKey();

		}
	}
}
//string binary = Convert.ToString(N, 2);
//binary = binary.TrimEnd(new Char[] { '0' });
//        var gaps = binary.Split('1');
//int max = 0;
//        foreach (var item in gaps)
//        {
//            if (!string.IsNullOrEmpty(item))
//                if(item.Length > max)
//                   max = item.Length;
//        }            
//        return max ;