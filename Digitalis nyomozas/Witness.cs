using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozas
{
	internal class Witness
	{
		private Person tanuAdat;
		private string vallomas;
		private int datum;

		public Witness(Person tanuAdat, string vallomas, int datum)
		{
			this.TanuAdat = tanuAdat;
			this.Vallomas = vallomas;
			this.Datum = datum;
		}

		public string Vallomas { get => vallomas; set => vallomas = value; }
		public int Datum { get => datum; set => datum = value; }
		internal Person TanuAdat { get => tanuAdat; set => tanuAdat = value; }
	}
}
