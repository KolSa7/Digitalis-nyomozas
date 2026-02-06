using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozas
{
	internal class DecisionEngine
	{
		private Suspect gyanusitott;
		private CentralDatabase kozpont;

		public DecisionEngine(Suspect gyanusitott, CaseManager ugyek, CentralDatabase kozpont)
		{
			this.Gyanusitott = gyanusitott;
			this.Kozpont = kozpont;
		}

		internal Suspect Gyanusitott { get => gyanusitott; set => gyanusitott = value; }
		internal CentralDatabase Kozpont { get => kozpont; set => kozpont = value; }

		public void korozesEval()
		{
			bool alreadyDisplayed = false;
			foreach (Case ugy in Kozpont.Ugyek) { 
				foreach (Person szemely in ugy.SzemelyLista)
				{
					if (szemely.Nev == Gyanusitott.GyanusitottAdat.Nev)
					{
						foreach (Evidence b in ugy.BizonyitekLista) 
						{
							Gyanusitott.KorozottSzint+= b.Megbizhatosag;
							if(Gyanusitott.KorozottSzint >= 100&& !alreadyDisplayed)
							{
								Console.WriteLine($"A gyanúsított, {Gyanusitott.GyanusitottAdat.Nev} ellen körözés lett kiadva.");
								alreadyDisplayed = true;
							}
						}
					}
				}
			}
		}
	}
}
