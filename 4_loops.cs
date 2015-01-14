using System;

class LoopsApp {

	static void Main() {
		
		// While .. then ..
		Console.WriteLine("While");
		int i = 1;
		while (i < 5) {
			Console.WriteLine(i);
			i++; // i += 1; also works
		}

		// While with function break
		Console.WriteLine("While with break");
		i = 5;
		int result = 1;
		while (true) {
			result *= i;
			if (i <= 1) {
				Console.WriteLine(result);
				break;
			}
			i--; // i -= 1; also works
		}

		// While with continue
		Console.WriteLine("While with continue");
		i = 5;
		result = 1;
		while (true) {
			result *= i;
			if (i > 1) {
				i--;
				continue;	
			}
			Console.WriteLine(result);
			break;
		}

		// do .. while
		Console.WriteLine("Do while");
		i = 5;
		result = 1;
		do {
			result *= i;
			i--;
		} while (i > 1);
		Console.WriteLine(result);

		// For		
		Console.WriteLine("For");
		int x;
		for ( x = 0; x < 5; x++ ) {
			Console.WriteLine(x);
		}

		// For each
		Console.WriteLine("For each");
		int[] numbers = { 1,2,3,4,5 };
		foreach (int v in numbers) {
			Console.WriteLine(v);
		}

	}

}
