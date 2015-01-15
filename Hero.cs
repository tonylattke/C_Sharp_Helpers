using System;
using HeroBaseAbstract;

namespace HeroImplementation {

	class Hero: HeroBase{

		// Constructors
		public Hero() {
			name = "Tony";
		}
		public Hero(string name) {
			this.name = name;
		}

		// Get
		public override string getName() {
			return name;
		}

	}
}