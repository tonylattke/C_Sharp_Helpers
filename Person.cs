using System;
using PersonBaseInterface;

namespace PersonImplementation {
	
	class Person : PersonBase {

		// Data
		public string name;
		int age; // Default attribute is private in C#

		// Constructors
		public Person() {
			name= "Tony";
			age = 24;
		}
		public Person(string name, int age) {
			this.name= name;
			this.age = age;
		}

		// Get
		public string getName() {
			return name;
		}
		public int getAge() {
			return age;
		}

		// Set
		public void setName(string v){
			name = v;
		}
		public void setAge(int v) {
			age = v;
		}

		public void hello(){
			Console.WriteLine("Hello " + name);
		}

	}

}