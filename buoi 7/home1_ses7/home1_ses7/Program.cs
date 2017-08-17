using System;

namespace home1_ses7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Convert to Binary
			int numberDecimal = 10;
			string binary = string.Empty;
			int num = numberDecimal;
			int remainder = 0;
			while (numberDecimal>0) {
				//Chia lay so du
				remainder=numberDecimal % 2;
				//Cong chuoi
				binary = remainder.ToString() + binary;
				numberDecimal = numberDecimal / 2;
			}
			Console.WriteLine ("Binary of "+ num + " is: "+binary);

			//Highest commond factor
			int a,b;
			a = 0;
			b = 180;

			int i;
			i = (a < b) ? a : b;

			int hcf = 0;

			for (int j = 1; j <= i; j++) {
				if (a % j == 0 && b %j == 0) {
					hcf = j;
				}
			
			}
			Console.WriteLine (hcf);
		}
	}
}
