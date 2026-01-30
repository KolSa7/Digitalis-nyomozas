using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozas
{
	internal class Case
	{
		private int azonosito;
		private string cim;
		private string leiras;
		private string allapot;
		private List<Person> szemelyLista;
		private List<Evidence> bizonyitekLista;

		public Case(int azonosito, string cim, string leiras, string allapot, List<Evidence> bizonyitekLista, List<Person> szemelyLista)
		{
			this.azonosito = azonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			szemelyLista = new List<Person>();
			bizonyitekLista = new List<Evidence>();
		}

		public int Azonosito { get => azonosito; set => azonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
	}
}
