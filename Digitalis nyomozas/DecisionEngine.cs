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
		private CaseManager ugyek;

		public DecisionEngine(Suspect gyanusitott, CaseManager ugyek)
		{
			this.Gyanusitott = gyanusitott;
			this.Ugyek = ugyek;
		}

		internal Suspect Gyanusitott { get => gyanusitott; set => gyanusitott = value; }
		internal CaseManager Ugyek { get => ugyek; set => ugyek = value; }

		public void korozesEval()
		{
			bool alreadyDisplayed = false;
			foreach (Case ugy in ugyek.Ugyek) { 
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
