using System;
using System.IO;

class IOApp {

	static void Main() {
		
		/********************************* Input reading *******************************/
		
		Console.Write("Introduce the file name: ");
		string name = Console.ReadLine();
		
		/********************************** Create file ********************************/
		
		// Create and open file
		StreamWriter file = new StreamWriter(name+".txt");

		// Write the text
		file.Write("test on file\n");
		file.WriteLine("second text");

		// Close the file
		file.Close();

		// Write all lines on file
		string[] lines = { "third text\n", "fourth line" };
		File.WriteAllLines(name + "2.txt",lines);

		/*********************************** Read file *********************************/

		// Create and open file
		StreamReader file2 = new StreamReader(name+".txt");

		// Read line by line
		string line;
		while ((line = file2.ReadLine()) != null) {
			Console.WriteLine(line);
		}

		// Reset the seek (position 0 on file)
		file2.BaseStream.Seek(0, SeekOrigin.Begin);

		// Close the file
		file2.Close();

		// Read all lines
		string[] lines2 =  File.ReadAllLines(name + ".txt");

	}

}
