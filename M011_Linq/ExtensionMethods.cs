namespace M011_Linq
{
	public static class ExtensionMethods //static Klasse
	{
		public static int Quersumme(this int x) //mit this sich auf einen Typen beziehen
		{
			return x.ToString().Select(e => int.Parse(e.ToString())).Sum();
		}

		public static List<FahrzeugMarke> AlleAutomarken(this IEnumerable<Fahrzeug> fahrzeuge) //mit this sich auf einen Typen beziehen
		{
			return fahrzeuge.Select(e => e.Marke).Distinct().ToList();
		}
	}
}
