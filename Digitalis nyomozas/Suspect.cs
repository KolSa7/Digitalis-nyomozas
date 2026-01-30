using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozas
{
	internal class Suspect
	{
		private Person suspectData;
		private int wantedLevel;

		public Suspect(Person suspectData, int wantedLevel)
		{
			this.suspectData = suspectData;
			this.wantedLevel = wantedLevel;
		}

		public int WantedLevel { get => wantedLevel; set => wantedLevel = value; }
		internal Person SuspectData { get => suspectData; set => suspectData = value; }
	}
}
