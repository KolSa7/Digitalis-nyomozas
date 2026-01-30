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
		private int megbizhatosag;

		public Witness(Person tanuAdat, string vallomas, int megbizhatosag)
		{
			this.tanuAdat = tanuAdat;
			this.vallomas = vallomas;
			this.megbizhatosag = megbizhatosag;
		}

		public string Vallomas { get => vallomas; set => vallomas = value; }
		public int Megbizhatosag { get => megbizhatosag; set => megbizhatosag = value; }
		internal Person TanuAdat { get => tanuAdat; set => tanuAdat = value; }
	}
}
