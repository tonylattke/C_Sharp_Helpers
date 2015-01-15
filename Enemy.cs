using System;

namespace EnemyClass {

	class Enemy<T> {

		// T is generic
		
		public string hability;
		public T character;

		public Enemy(string a, T b) {
			hability 	= a;
			character 	= b;
		}

	}

}