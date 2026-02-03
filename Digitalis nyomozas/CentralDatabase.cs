using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_nyomozas
{
    internal class CentralDatabase
    {
        private List<Case> ugyek;
        private List<Person> szemelyek;
        private List<Evidence> bizonyitekok;
        private List<User> felhasznalok;
        public CentralDatabase()
        {
            this.Ugyek = new List<Case>();
            this.Szemelyek = new List<Person>();
            this.Bizonyitekok = new List<Evidence>();
            this.Felhasznalok = new List<User>();
        }

        internal List<Case> Ugyek { get => ugyek; set => ugyek = value; }
        internal List<Person> Szemelyek { get => szemelyek; set => szemelyek = value; }
        internal List<Evidence> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
        internal List<User> Felhasznalok { get => felhasznalok; set => felhasznalok = value; }

        public void AddUgy(Case ugy)
        {
            this.Ugyek.Add(ugy);
        }
        public void AddSzemely(Person szemely)
        {
            this.Szemelyek.Add(szemely);
        }
        public void AddBizonyitek(Evidence bizonyitek)
        {
            this.Bizonyitekok.Add(bizonyitek);
        }
        public void AddFelhasznalo(User felhasznalo)
        {
            this.Felhasznalok.Add(felhasznalo);
        }
    }
}
