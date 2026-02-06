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

		public void createCase()
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
			do {
				Console.WriteLine("Szeretne bizonyítékot hozzáadni? (igen/nem)");
				valasz = Console.ReadLine();
				if (valasz.ToLower() == "igen")
				{
					Console.WriteLine("Adja meg a bizonyíték típusát:");
					string tipus = Console.ReadLine();
					Console.WriteLine("Adja meg a bizonyíték leírását:");
					string bizonyitekLeiras = Console.ReadLine();
					Console.WriteLine("Adja meg a bizonyíték megbízhatóságát (1-10):");
					int megbizhatosag = int.Parse(Console.ReadLine());
					Console.Clear();
					ugykezelo.UjBizonyitek(tipus, bizonyitekLeiras, megbizhatosag, adatbazis.Ugyek.Last());
					Console.ReadKey();
					Console.Clear();
				}
			}
			while (valasz.ToLower()=="igen");

			do
			{
				Console.WriteLine("Szeretne személyeket hozzáadni?(igen/nem)");
				valasz = Console.ReadLine();
				Console.Clear();
				if (valasz.ToLower() == "igen")
				{
					Console.WriteLine("Adja meg a személy nevét:");
					string nev = Console.ReadLine();
					Console.WriteLine("Adja meg a személy életkorát:");
					int eletkor = int.Parse(Console.ReadLine());
					Console.WriteLine("Adja meg a személy nemét:");
					string nem = Console.ReadLine();
					Person szemely = new Person(nev, eletkor, nem);
					Console.Clear();
					ugykezelo.UjSzemely(szemely, adatbazis.Ugyek.Last());
					Console.ReadKey();
					Console.Clear();
				}
			}
			while (valasz.ToLower() == "igen");
		}

	}
}
