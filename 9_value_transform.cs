using System;

class IOApp {

	static void Main() {
		
		/******************************** Value to String ******************************/

		// Integer
		int i_value  = 42;
		string s_i_value = i_value.ToString();

		// Float
		float f_value  = 42.0f;
		string s_f_value = f_value.ToString();

		// Double
		double d_value  = 42.0;
		string s_d_value = d_value.ToString();
		
		/******************************** String to Value ******************************/

		// Integer
		i_value = Convert.ToInt32("42");

		// Float
		f_value = Convert.ToSingle("42.0");

		// Double
		d_value = Convert.ToDouble("42.0");

	}

}
