namespace Digitalis_nyomozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Case ugy = new Case(1, "Eltűnt macska", "Egy fekete macska eltűnt a kertből.", "Nyitott");
            Evidence bizonyitek = new Evidence(101, "Fénykép", "A macska fényképe a kertben.", 90);
            EvidenceManager bizonyitekKezelo = new EvidenceManager(ugy);
            bizonyitekKezelo.ujBizonyitek(bizonyitek);
            bizonyitekKezelo.bizonyitekListazas();
            bizonyitekKezelo.bizonyitekTorles(10);
		}
    }
}
