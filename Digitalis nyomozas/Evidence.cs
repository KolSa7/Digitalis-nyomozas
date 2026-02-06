using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozas
{
	internal class Evidence
	{
		private int azonosito;
		private int ugyAzonosito;
		private string tipus;
		private string leiras;
		private int megbizhatosag;

		public Evidence(int azonosito, string tipus, string leiras, int megbizhatosag, int ugyAzonosito)
		{
			this.Azonosito = azonosito;
			this.UgyAzonosito = ugyAzonosito;
			this.Tipus = tipus;
			this.Leiras = leiras;
			this.Megbizhatosag = megbizhatosag;
		}

		public int Azonosito { get => azonosito; set => azonosito = value; }
		public int UgyAzonosito { get => ugyAzonosito; set => ugyAzonosito = value; }
		public string Tipus { get => tipus; set => tipus = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public int Megbizhatosag { get => megbizhatosag; set => megbizhatosag = value; }
	}
}
