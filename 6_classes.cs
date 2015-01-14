using System;

/************************************* Enumeration *************************************/ 

enum Nationality { GERMAN, AMERICAN, VENEZUELAN }

/************************************ Creating Class ***********************************/
// Classes by default are private

// Color
public class Color {
	// Attributes by default are private
	public int r;
	public int g;
	public int b;

	public override String ToString(){
		return "R: " + r + " G: " + g + " B: " + b;
	}
}


// Person
public class Person {
	public string name;
	public int age;

	// Example 1 Constructor - No parameters
	public Person() {
		name= "Tony";
		age = 24;
	}

	// Example 2 Constructor - With parameters
	public Person(String name, int age) {
		this.name= name;
		this.age = age;
	}

	public void hello(){
		Console.WriteLine("Hello " + name);
	}
}

/************************************ Inheritance **************************************/
public class Civil : Person {
	
	public string profesion_name;

	public Civil(string a, int b, string c) {
		name 			= a;
		age				= b;
		profesion_name	= c;
	}
};

class ClassesApp {
	
	static void Main() {

		// Use enumeration
		Nationality aux0 = Nationality.GERMAN;
		// You can also enumeration values of the same class compare

		// Create Color
		Color aux = new Color();
		Console.WriteLine(aux);

		// Change values on class
		aux.r = 150;
		Console.WriteLine(aux);
		
		// Initialize with own Constructor
		Person aux2 = new Person("Bruce", 28);
		aux2.hello();

		// Inheritance initialize
		Civil aux3 = new Civil("Heinrich", 24, "Programmer");

		// Use functions of inheritance class
		aux3.hello();

	}

}
