using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozas
{
	internal class CaseManager
	{
		private List<Case> ugyek;
		public CaseManager()
		{
			this.Ugyek = new List<Case>();
		}

		internal List<Case> Ugyek { get => ugyek; set => ugyek = value; }

		public void ujUgy(Case ugy)
		{
			this.Ugyek.Add(ugy);
			Console.WriteLine($"Ügy {ugy.Azonosito} hozzáadva.");
		}
		public void ugylista()
		{
			Console.WriteLine("Ügyek listája:");
			foreach (Case ugy in this.Ugyek)
			{
				Console.WriteLine(ugy);
			}
		}
		public void ujBizonyitek(Evidence bizonyitek, int ugyID)
		{
			foreach (Case ugy in this.Ugyek)
			{
				if (ugy.Azonosito == ugyID)
				{
					ugy.BizonyitekLista.Add(bizonyitek);
					Console.WriteLine($"Bizonyíték {bizonyitek.Azonosito} hozzáadva a(z) {ugy.Azonosito} azonosítójú ügyhöz");
					return;
				}
			}
			Console.WriteLine($"Nincs olyan ügy, aminek az azonosítója {ugyID}");
		}
		public void ujSzemely(Person szemely, int ugyID)
		{
			foreach (Case ugy in this.Ugyek)
			{
				if (ugy.Azonosito == ugyID)
				{
					ugy.SzemelyLista.Add(szemely);
					Console.WriteLine($"{szemely.Nev} hozzáadva a(z) {ugy.Azonosito} azonosítójú ügyhöz");
					return;
				}
			}
			Console.WriteLine($"Nincs olyan ügy, aminek az azonosítója {ugyID}");
		}
	}
}
