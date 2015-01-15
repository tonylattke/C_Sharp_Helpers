using System;

namespace PersonBaseInterface {

	interface PersonBase {

		// We can declare only functions on interface

		// Get
		string getName();
		int getAge();

		// Set
		void setName(string v);
		void setAge(int v);

		// Functions
		void hello();

	}

}