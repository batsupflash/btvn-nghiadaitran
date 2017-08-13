using System;
using System.Collections.Generic;

namespace home2_ses7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			
			List<int> allDivisors = new List<int> ();

			int[] l = new int[]{ 1, 2, 3, 4, 5, 6 };
		
			for (int y = 0; y < l.Length; y++) 
				
			{
				int a = l [y];
				for (int i = a; i >0; i--) {
					if (i % a == 0) {
						allDivisors.Add(i);
					}
				}
			}
			Console.WriteLine (allDivisors);

		}
						
	}
}
		
	

