using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozas
{
	internal class CaseManager
	{
		private CentralDatabase centralDatabase;
		public CaseManager(CentralDatabase centralDatabase)
		{
			this.CentralDatabase = centralDatabase;
		}

		internal CentralDatabase CentralDatabase { get => centralDatabase; set => centralDatabase = value; }

		public void UjUgy(string cim, string leiras)
		{
			CaseStatus CaseStatus =new CaseStatus("Nyitott");
			Case ujUgy= new Case(centralDatabase.Ugyek.Count + 1, cim, leiras, CaseStatus);
			centralDatabase.AddUgy(ujUgy);
			Console.WriteLine($"Ügy {ujUgy.Azonosito} hozzáadva.");

		}
		public void UgyLista()
		{
			Console.WriteLine("Ügyek listája:");
			foreach (Case ugy in CentralDatabase.Ugyek)
			{
				Console.WriteLine(ugy);
			}
		}
		public void UjBizonyitek(Evidence bizonyitek, Case ugy)
		{
			EvidenceManager manageEvidence=new EvidenceManager(ugy);
			manageEvidence.ujBizonyitek(bizonyitek);
			CentralDatabase.AddBizonyitek(bizonyitek);
			Console.WriteLine($"Bizonyíték {bizonyitek.Azonosito} hozzáadva a(z) {ugy.Azonosito} azonosítójú ügyhöz");
		}
		public void UjSzemely(Person szemely, Case ugy)
		{
			ugy.SzemelyLista.Add(szemely);
			CentralDatabase.AddSzemely(szemely);
			Console.WriteLine($"{szemely.Nev} hozzáadva a(z) {ugy.Azonosito} azonosítójú ügyhöz.");
		}
	}
}
