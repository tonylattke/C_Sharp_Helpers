using System;

class VariablesApp {

	static void Main() {
		
		// Commpare Values
		int aux = 23;
		bool equal 			= aux == 42;
		bool not_equal 		= aux != 42;

		bool less_than 		= aux < 42;
		bool more_than 		= aux > 42;
		bool less_equal_than= aux <= 42;
		bool more_equal_than= aux >= 42;

		bool operator_or	= aux < 23 || aux > 42;
		bool operator_and	= aux < 23 && aux > 42;			
		
		// If .. then .. else ..
		int number = 23;
		if (number == 23) {
			Console.WriteLine("Number is 23");
		} else {
			Console.WriteLine("Number is not 23");
		}

		// If .. then .. else if .. then .. else ..
		string name1 = "Tony";
		string name2 = "Enrique";
		string name  = "Heinrich";
		if (String.Equals(name,name1)) {
			Console.WriteLine("It is Tony");
		} else if (String.Equals(name,name2)) {
			Console.WriteLine("It is Enrique");
		} else {
			Console.WriteLine("It\'s not Tony or Enrique");
		}

		// switch .. case ..
		int value = 23;
		switch ( value ) {
			case 32:
				Console.WriteLine("32");
				break;
			case 43:
				Console.WriteLine("42");
				break;
			default:
				Console.WriteLine("Other");
				break;
		}

	}

}
