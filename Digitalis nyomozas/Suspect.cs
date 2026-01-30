using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozas
{
	internal class Suspect
	{
		private Person gyanusitottAdat;
		private int korozottSzint;

		public Suspect(Person gyanusitottAdat, int korozottSzint)
		{
			this.gyanusitottAdat = gyanusitottAdat;
			this.korozottSzint = korozottSzint;
		}

		public int KorozottSzint { get => korozottSzint; set => korozottSzint = value; }
		internal Person GyanusitottAdat { get => gyanusitottAdat; set => gyanusitottAdat = value; }
	}
}
