using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozas
{
	internal class Person
	{
		private string nev;
		private int eletKor;
		private string megjegyzes;

		public Person(string nev, int eletKor, string megjegyzes)
		{
			this.nev = nev;
			this.eletKor = eletKor;
			this.megjegyzes = megjegyzes;
		}

		public string Nev { get => nev; set => nev = value; }
		public int EletKor { get => eletKor; set => eletKor = value; }
		public string Megjegyzes { get => megjegyzes; set => megjegyzes = value; }
	}
}
