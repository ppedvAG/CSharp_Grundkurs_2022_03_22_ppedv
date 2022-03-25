namespace M011_Linq
{
	public static class ExtensionMethods //static Klasse
	{
		public static int Quersumme(this int x) //mit this sich auf einen Typen beziehen
		{
			return x.ToString().ToCharArray().Sum(c => c.ToNumber());
		}

		public static int ToNumber(this char c) => (int) char.GetNumericValue(c);

		public static List<FahrzeugMarke> AlleAutomarken(this IEnumerable<Fahrzeug> fahrzeuge) //mit this sich auf einen Typen beziehen
		{
			return fahrzeuge.Select(e => e.Marke).Distinct().ToList();
		}

		public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> e)
		{
			return e.OrderBy(x => Random.Shared.Next());
		}
	}
}
