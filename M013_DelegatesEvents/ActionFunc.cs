namespace M013_DelegatesEvents
{
	public class ActionFunc
	{
		static void Main2(string[] args)
		{
			Action<int, int> action = Addiere; //Action mit Parametern <int, int>, Addiere Method drangehängt
			action += Subtrahiere; //Subtrahiere Methode hinzufügen
			action.Invoke(5, 9); //Aufruf

			Action<int, int> anon = (x, y) => Console.WriteLine(x + y); //Wie bei Aggregate

			Predicate<int> checkZero = CheckForZero;
			Console.WriteLine(checkZero.Invoke(0)); //Gibt bool zurück

			Func<int, int, int> func = Multipliziere; //Dritter Wert ist return Wert
			func += delegate (int x, int y) { return x * y; }; //Anonyme Methode (alte Schreibweise)
			func += (x, y) => x * y; //Anonyme Methode (neue Schreibweise)
			Console.WriteLine(func.Invoke(5, 9)); //Invoke gibt return Wert zurück (int)
		}

		public static void Addiere(int a, int b) => Console.WriteLine(a + b);

		public static void Subtrahiere(int a, int b) => Console.WriteLine(a - b);

		public static bool CheckForZero(int x) => x == 0;

		public static int Multipliziere(int x, int y) => x * y;
	}
}
