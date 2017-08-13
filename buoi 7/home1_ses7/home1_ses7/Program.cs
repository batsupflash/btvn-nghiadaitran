using System;

namespace home1_ses7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float[] l = new float[]{ 1, 2, 3, 4 };
		


			foreach (int i in l)
			{
			
				string binary = Convert.ToString (i, 2);
				Console.WriteLine (binary);
			}

		}
	}
}
