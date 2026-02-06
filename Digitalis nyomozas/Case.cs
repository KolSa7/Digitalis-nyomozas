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

		public Case(int azonosito, string cim, string leiras, string allapot)
		{
			this.azonosito = azonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.szemelyLista = new List<Person>();
			this.bizonyitekLista = new List<Evidence>();
		}

		public int Azonosito { get => azonosito; set => azonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		internal List<Person> SzemelyLista { get => szemelyLista; set => szemelyLista = value; }
		internal List<Evidence> BizonyitekLista { get => bizonyitekLista; set => bizonyitekLista = value; }

		public override string ToString()
		{
			return $"Ügy azonosító: {this.Azonosito}, Cím: {this.Cim}, Leírás: {this.Leiras}, Állapot: {this.Allapot}";
		}
	}
}
