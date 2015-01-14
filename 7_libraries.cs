using System;

class LibrariesApp {

	static void Main() {
		
		/************************************ Datetime *********************************/
		
		// Now
		DateTime tm = DateTime.Now;
		Console.WriteLine(tm);
		
		// Now - 2 Hours
		DateTime two_hours = tm.AddHours(-2);
		Console.WriteLine(two_hours);
		// We have also minus/plus seconds, minutes, days, months and years functions

		/**************************************  Math **************************************/

		// Elemental numbers
		double aux_pi = Math.PI;
		double aux_exp = Math.E;
		double phi = (1 + Math.Sqrt(5))/2;

		int x = 10;

		//  It's a number must check

		int res_round = (int) Math.Round((double) x);	// Round x
		
		double res_exp = Math.Exp(x); 	// e to the power of 10

		double res_log = Math.Log(x); 	// Default base e - Log10 for logarithm base 10
		
		double res_sqrt = Math.Sqrt(10);

		double res_sin = Math.Sin(10);
		double res_cos = Math.Cos(10);
		double res_tan = Math.Tan(10);

		/************************************** Random *************************************/

		// Random value generator
		Random rand = new Random();

		// Set seed with time value
		rand = new Random((int)DateTime.Now.Ticks);

		Console.WriteLine(rand.Next());  		// Random int value from Min till Max int value
		Console.WriteLine(rand.Next(23));		// Random int value from 0 till 22
		Console.WriteLine(rand.Next(-42,23));	// Random int value from -42 till 22

		// Random number betwen 0 and 1
		Console.WriteLine(rand.NextDouble());

		int[] lost = { 4, 8, 15, 16, 23, 42 };

		// Random member of array
		int value_lost = lost[Math.Abs(rand.Next(6))];

		// Random int on range
		int range = 50;
		int minimum = 100;
		int random_number = Math.Abs(rand.Next()) % range + minimum;
		Console.WriteLine(random_number);

	}

}
