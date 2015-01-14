using System;
using System.Linq;					// Array concat
using System.Collections.Generic; 	// List

class DataStructuresApp {

	static void Main() {

		/************************************* Tuple ***********************************/
		
		Tuple<string,string> mytuple = new Tuple<string,string>("Bruce","Wayne");
		
		// Triplet
		Tuple<string,string,string> triplet;
		triplet = new Tuple<string,string,string>("Red", "Green", "Blue");

		// N-Tuple
		Tuple<string,string,string,string,string,string> ntuple;
		ntuple = new Tuple<string,string,string,string,string,string>("Batman", "Superman", "Wonder Woman", "Green Light", "Flash", "J\'onn");

		// Access on Tuple
		Console.WriteLine("Name: {0}\nFamily: {1}", mytuple.Item1, mytuple.Item2);
		
		// Replace on Tuple is not supported

		/************************************* Arrays **************************************/

		// Empty Array with 3 slots
		int[] empty_array = new int[3];

		// Insert elements on array
		empty_array[0] = 1;
		empty_array[1] = 2;
		empty_array[2] = 3;

		// Print values on list
		foreach (int j in empty_array) {
			Console.WriteLine(j);
		}

		// Array loaded
		int[] lost = {4, 8, 15, 16, 23, 42};

		// Length of array
		Console.WriteLine("Lost numbers are only " + lost.Length);

		// Concat
		int[] array1 = { 1, 3, 5 };
		int[] array2 = { 0, 2, 4 };

		// Concat example 1
		var array_total = array1.Concat(array2);

		// Concat example 2
		int[] array_total2 = new int[array1.Length + array2.Length];
		array1.CopyTo(array_total2, 0);
		array2.CopyTo(array_total2, array1.Length);

		// Access to diferents elements
		int[] squares = { 1, 4, 9, 16, 36 };
		int a = squares[0];
		
		// Change value of element on array
		squares[4] =25;

		// Array inside array
		int[][] array3 = { array1, array2 };

		// Delete array is realized by Garbage Collector

		/*************************************** List **************************************/

		// Empty list
		List<int> empty_list = new List<int>();

		// Append elements to the list
		empty_list.Add(1);
		empty_list.Add(2);
		empty_list.Add(3);

		// Print values on list
		foreach (int i in empty_list) {
			Console.WriteLine(i);
		}

		// Delete the last element
		empty_list.Remove(empty_list.Count - 1);

		// Delete the first element
		empty_list.Remove(0);

		// List loaded
		int[] numbers = { 4, 8, 15, 16, 23, 42 };
		List<int> numbers1 = new List<int>(numbers);
		
		// Length of list
		Console.WriteLine("Size of list: " + numbers1.Count);

		// Concat lists
		IEnumerable<int> result_list = numbers1.Concat(empty_list);

		// Sort list
		numbers1.Sort();

		/************************************* Dictionary ******************************/

		// Empty dictionary
		Dictionary<string, string> dictionary = new Dictionary<string, string>();

		// Add elements
		dictionary.Add("a","Alice");
		dictionary.Add("e","Erick");
		dictionary.Add("i","Isaac");
		dictionary.Add("o","Oscar");
		dictionary.Add("u","Ursula");

		// Access
		Console.WriteLine(dictionary["i"]);

		// Replace value
		dictionary["o"] = "Oriana";

		// Erase element
		dictionary.Remove("u");

		// Size
		Console.WriteLine(dictionary.Count);

		/********************************* Arithmetic Conversions **************************/

		double normal_double;
		float normal_float;		
		long long_i;
		int i2;		

	}
}