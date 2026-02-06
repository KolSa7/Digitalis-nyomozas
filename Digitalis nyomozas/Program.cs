namespace Digitalis_nyomozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CentralDatabase kozpont=new CentralDatabase();
            CaseManager ugykezelo=new CaseManager(kozpont);
            ugykezelo.UjUgy("Eltűnt személy", "Egy 30 éves férfi eltűnt a városban.");
            ugykezelo.UgyLista();


		}
    }
}
