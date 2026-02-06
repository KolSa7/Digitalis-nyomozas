using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozas
{
	internal class EvidenceManager
	{
		private Case ugy;
		private CentralDatabase centraldatabase;

		public EvidenceManager(Case ugy, CentralDatabase centraldatabase)
		{
			this.ugy = ugy;
			this.Centraldatabase = centraldatabase;
		}

		internal Case Ugy { get => ugy; set => ugy = value; }
		internal CentralDatabase Centraldatabase { get => centraldatabase; set => centraldatabase = value; }

		public void ujBizonyitek(string tipus, string leiras, int megbizhatosag)
		{
			Evidence bizonyitek= new Evidence(this.Centraldatabase.Bizonyitekok.Count+1, tipus, leiras, megbizhatosag, this.Ugy.Azonosito);
			this.Ugy.BizonyitekLista.Add(bizonyitek);
			centraldatabase.AddBizonyitek(bizonyitek);
			Console.WriteLine($"Bizonyíték {bizonyitek.Azonosito} hozzáadva a(z) {this.Ugy.Azonosito} azonosítójú ügyhöz");
		}
		public void bizonyitekTorles(int bizonyitekID)
		{
			Evidence torlendo = null;
			foreach (Evidence bizonyitek in this.Ugy.BizonyitekLista)
			{
				if (bizonyitek.Azonosito == bizonyitekID)
				{
					torlendo = bizonyitek;
				}
			}
			if (torlendo != null)
			{
				this.Ugy.BizonyitekLista.Remove(torlendo);
				Console.WriteLine( $"Bizonyíték {bizonyitekID} törölve a(z) {this.Ugy.Azonosito} azonosítójú ügyből");
			}
			else
			{
				Console.WriteLine( $"Nincs olyan bizonyíték, aminek az azonosítója {bizonyitekID}");
			}
		}
		public void bizonyitekListazas()
		{
			Console.WriteLine($"Bizonyítékok a(z) {this.Ugy.Azonosito} azonosítójú ügyhöz:");
			foreach (var bizonyitek in this.Ugy.BizonyitekLista)
			{
				Console.WriteLine($"- {bizonyitek.Azonosito}: {bizonyitek.Tipus} - {bizonyitek.Leiras} (Megbízhatóság: {bizonyitek.Megbizhatosag})");
			}
		}
	}
}
