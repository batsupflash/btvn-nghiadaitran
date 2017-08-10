using System;

namespace home1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Console.WriteLine ("Hello! This's the BMI calculator program! What's your name?");
			string userName = Console.ReadLine ();
			Console.WriteLine("Hello " + userName + "!");
			Console.WriteLine ("How tall are you? (cm)");
			float height;
			if ((!float.TryParse(Console.ReadLine(), out height))) {
				Console.WriteLine ("Must be number");
				
			}
			height = height / 100;

			Console.WriteLine ("How much do you weigh? (kg)");
			float weight ;
			if ((!float.TryParse(Console.ReadLine(), out weight))) {
				Console.WriteLine ("Must be number");

			}
		
			float BMI = weight / (height * height);

			if (BMI < 16)
			{
				Console.WriteLine("You're 'Severely underweight'");
			} 
			else if (18.5> BMI && BMI >= 16) 
			{
				Console.WriteLine("You're 'Underweight'");
			} 
			else if (25> BMI && BMI >= 18.5)
			{
				Console.WriteLine("You're 'Normal'");
			} 
			else if (30 > BMI && BMI >= 25)
			{
				Console.WriteLine("You're 'Overweight'");
			} 
			else 
			{
				Console.WriteLine("You're 'Obese'");
			} 
				

				




		}
	}
}
