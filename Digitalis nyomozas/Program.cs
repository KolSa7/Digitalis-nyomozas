namespace Digitalis_nyomozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseManager ugyKezelo = new CaseManager();
			Case ugy = new Case(1, "Eltűnt macska", "Egy fekete macska eltűnt a kertből.", "Nyitott");
            Evidence bizonyitek = new Evidence(101, "Fénykép", "A macska fényképe a kertben.", 90);
            EvidenceManager bizonyitekKezelo = new EvidenceManager(ugy);
            bizonyitekKezelo.ujBizonyitek(bizonyitek);
            bizonyitekKezelo.bizonyitekListazas();
            ugyKezelo.ujUgy(ugy);
			Evidence bizonyitek1 = new Evidence(102, "Fénykép", "A macska fényképe a kertben.", 90);
            ugyKezelo.ujBizonyitek(bizonyitek1, 1);
            Person szemely = new Person("Kovács János", 35, "Tulajdonos");
            Suspect gyanusitott = new Suspect(szemely,99);
			ugyKezelo.ujSzemely(szemely, 1);
            ugyKezelo.ugylista();   
            DecisionEngine dontesMotor = new DecisionEngine(gyanusitott, ugyKezelo);
            dontesMotor.korozesEval();


		}
    }
}
