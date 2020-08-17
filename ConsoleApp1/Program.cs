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



//long sumright = 0;
//long sumleft = 0;
//long ans;
    
//    for (int i =1;i<A.length;i++)
//        sumright += A[i];
    
//    sumleft = A[0];
//    ans =Math.abs(Math.abs(sumright)+Math.abs(sumleft));
    
//    for (int P=1; P<A.length; P++)
//    {
//        if (Math.abs(Math.abs(sumleft) - Math.abs(sumright))<ans)
//            ans = Math.abs(Math.abs(sumleft) - Math.abs(sumright));
//        sumleft += A[P];
//        sumright -=A[P];
//    }
//    return (int) ans;

