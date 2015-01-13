using System;

class VariablesApp {

	static void Main() {
		
		/*************************** Printing Variables **************************/

		// Using Strings
		string foo = "World";
		Console.WriteLine("Hello " + foo);

		// Using numbers
		int minutes = 60;
		Console.WriteLine("1 Hour have " + minutes + " minutes");

		// Using Floating point numbers
		float celcius = 0;
		double farenheit = 32.0 + celcius*(9.0/5);
		Console.WriteLine(celcius + " Celcius are " + farenheit + " Farenheit grades");

		// Using Double floating point numbers with fixed amount digits of the right
		// Only the first 5 first digits of phi will be showed precision 5
		double phi   = 1.618033988749894848;
		Console.WriteLine("The golden ratio " + String.Format("{0:0.00000}", phi));

		// Hexadecimal of numbers
		int red 	= 0xFF0000;
		int green 	= 0x00FF00;
		int blue	= 0x0000FF;
		
		Console.WriteLine(
			"Hexadecimal code of:\nRed is: " + String.Format("{0:x6}", red) + 
			"\nGreen is: " + String.Format("{0:x6}", green) + 
			"\nBlue is: " + String.Format("{0:x6}", blue));

		/***************************** Operating Variables *****************************/

		// Numbers
		int p_foo = 23;
		int p_bar = 19;
		int p_baz = p_foo + p_bar; // Plus
		Console.WriteLine(p_foo + " + " + p_bar + " = " + p_baz);
		
		int m_foo = 69;
		int m_bar = 27;
		int m_baz = m_foo - m_bar; // Minus
		Console.WriteLine(m_foo + " + " + m_bar + " = " + m_baz);

		int mu_foo = 7;
		int mu_bar = 6;
		int mu_baz = mu_foo * mu_bar; // Multiply
		Console.WriteLine(mu_foo + " * " + mu_bar + " = " + mu_baz);

		int d_foo = 420;
		int d_bar = 10;
		int d_baz = d_foo / d_bar; // Divide
		Console.WriteLine(d_foo + " / " + d_bar + " = " + d_baz);

		int mo_foo = 429;
		int mo_bar = 43;
		int mo_baz = mo_foo % mo_bar; // Module
		Console.WriteLine(mo_foo + " mod " + mo_bar + " is " + mo_baz);

		double po_foo = 6.48074069840786;
		int po_bar = 2;
		double po_baz = Math.Pow(po_foo, po_bar); // Pow
		Console.WriteLine(po_foo + " to the power of " + po_bar + " is " + po_baz);

		// Strings
		String s_foo = "C++ ";
		String s_bar = s_foo + "Works"; // Concat Strings

		// Simple character
		char c_foo = 'T';

		// String size
		String r_foo = "Lorem ipsum dolor sit amet";
		Console.WriteLine("Size: " + r_foo.Length);

		// String replace
		Console.WriteLine(r_foo.Replace(" ","_"));

		// String access
		String a_foo = "Lorem ipsum dolor sit amet";
		Console.WriteLine(a_foo[0]); // First char on string "Lorem ipsum dolor sit amet"
		Console.WriteLine(a_foo.Substring(6,12)); // 6 till 12 chars on string "Lorem ipsum dolor sit amet"
		Console.WriteLine(a_foo.Substring(5)); // First 5 chars on string "Lorem ipsum dolor sit amet"
		Console.WriteLine(a_foo.Substring(0,6)); // 6 till the end chars on string "Lorem ipsum dolor sit amet"

	}

}
