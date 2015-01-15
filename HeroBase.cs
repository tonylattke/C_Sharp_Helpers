using System;

namespace HeroBaseAbstract {

	abstract class HeroBase {

		// We can declare atributes and implement functions in abstract Class
		
		public string name;

		// Get
		public abstract string getName();

		// Set
		public void setName(string v){
			name = v;
		}

	}
}