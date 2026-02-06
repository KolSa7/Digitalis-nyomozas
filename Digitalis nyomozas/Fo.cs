using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozas
{
	internal class Fo
	{
		private CentralDatabase adatbazis;
		public Fo(CentralDatabase adatbazis, DecisionEngine dontes)
		{
			this.Adatbazis = adatbazis;
		}
		internal CentralDatabase Adatbazis { get => adatbazis; set => adatbazis = value; }

		public void AddCase()
		{
			CaseManager ugykezelo = new CaseManager(adatbazis);
			Console.WriteLine("Adja meg az ügy címét:");
			string cim = Console.ReadLine();
			Console.WriteLine("Adja meg az ügy leírását:");
			string leiras = Console.ReadLine();
			Console.Clear();
			ugykezelo.UjUgy(cim, leiras);
			Console.ReadKey();
			string valasz;
			do
			{
				Console.WriteLine("Szeretne bizonyítékot hozzáadni? (igen/nem)");
				valasz = Console.ReadLine();
				if (valasz.ToLower() == "igen")
				{
					AddEvidence(true);
				}
			}
			while (valasz.ToLower() == "igen");

			do
			{
				Console.WriteLine("Szeretne személyeket hozzáadni?(igen/nem)");
				valasz = Console.ReadLine();
				Console.Clear();
				if (valasz.ToLower() == "igen")
				{
					this.AddPeople(true);
				}
			}
			while (valasz.ToLower() == "igen");
		}
		public void RemoveCase()
		{
			CaseManager ugykezelo = new CaseManager(adatbazis);
			Console.WriteLine("Adja meg a törölni kívánt ügy azonosítóját:");
			int ugyAzonosito = int.Parse(Console.ReadLine());
			adatbazis.Ugyek.RemoveAll(u => u.Azonosito == ugyAzonosito);
			Console.Clear();
			Console.WriteLine($"A(z) {ugyAzonosito} azonosítójú ügy törölve.");
			Console.ReadKey();
			Console.Clear();
		}
		public void AddPeople(bool newcase)
		{
			CaseManager ugykezelo = new CaseManager(adatbazis);
			Console.WriteLine("Adja meg a személy nevét:");
			string nev = Console.ReadLine();
			Console.WriteLine("Adja meg a személy életkorát:");
			int eletkor = int.Parse(Console.ReadLine());
			Console.WriteLine("Adja meg a személy nemét:");
			string nem = Console.ReadLine();
			Person szemely = new Person(nev, eletkor, nem);
			Console.Clear();
			if (!newcase)
			{
				Console.WriteLine("Melyik Ügyhöz kapcsolódik a személy (azonosító)?");
				int ugyAzonosito = int.Parse(Console.ReadLine());
				ugykezelo.UjSzemely(szemely, adatbazis.Ugyek[ugyAzonosito]);
			}
			else
			{
				ugykezelo.UjSzemely(szemely, adatbazis.Ugyek.Last());
			}
			Console.ReadKey();
			Console.Clear();
		}
		public void RemovePeople()
		{
			CaseManager ugykezelo = new CaseManager(adatbazis);
			Console.WriteLine("Adja meg a törölni kívánt személy nevét:");
			string nev = Console.ReadLine();
			foreach (Case ugy in adatbazis.Ugyek)
			{
				ugy.SzemelyLista.RemoveAll(s => s.Nev == nev);
			}
			Console.Clear();
			Console.WriteLine($"A(z) {nev} nevű személy törölve.");
			Console.ReadKey();
			Console.Clear();
		}
		public void AddEvidence(bool newcase)
		{
			CaseManager ugykezelo = new CaseManager(adatbazis);
			Console.WriteLine("Adja meg a bizonyíték típusát:");
			string tipus = Console.ReadLine();
			Console.WriteLine("Adja meg a bizonyíték leírását:");
			string bizonyitekLeiras = Console.ReadLine();
			Console.WriteLine("Adja meg a bizonyíték megbízhatóságát (1-10):");
			int megbizhatosag = int.Parse(Console.ReadLine());
			Console.Clear();
			if (!newcase)
			{
				Console.WriteLine("Melyik Ügyhöz kapcsolódik a bizonyíték (azonosító)?");
				int ugyAzonosito = int.Parse(Console.ReadLine());
				ugykezelo.UjBizonyitek(tipus, bizonyitekLeiras, megbizhatosag, adatbazis.Ugyek[ugyAzonosito]);
			}
			else
			{
				ugykezelo.UjBizonyitek(tipus, bizonyitekLeiras, megbizhatosag, adatbazis.Ugyek.Last());
			}
			Console.ReadKey();
			Console.Clear();

		}
		public void RemoveEvidence()
		{
			CaseManager ugykezelo = new CaseManager(adatbazis);
			Console.WriteLine("Adja meg a törölni kívánt bizonyíték leírását:");
			int bizAzonosito = int.Parse(Console.ReadLine());
			foreach (Case ugy in adatbazis.Ugyek)
			{
				ugy.BizonyitekLista.RemoveAll(b => b.Azonosito == bizAzonosito);
			}
			Console.Clear();
			Console.WriteLine($"A(z) {bizAzonosito} azonosítójú bizonyíték törölve.");
			Console.ReadKey();
			Console.Clear();
		}
	}
}
