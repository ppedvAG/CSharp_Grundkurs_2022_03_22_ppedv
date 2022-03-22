public class Program
{

	//svm -> Tab -> Tab: generiert Main Methode
	static void Main(string[] args)
	{
		AddiereAusgabe(5, 10); //Funktionsaufruf
		AddiereAusgabe(10, 20);

		int summe = Addiere(20, 10); //return Wert
		double summeD = Addiere(20.0, 10); //Spezifizieren welche Typen die Parameter haben um Double Methode zu benutzen

		int summeParams = Addiere(1, 2, 3, 54, 56, 76, 8, 7);

		int sub = Subtrahiere(10, 4); //optional z3

		int subtraktion;
		int addition = AddiereUndSubtrahiere(10, 5, out subtraktion); //out mit Feld verbinden
	}

	/// <summary>
	/// Addiert zwei Zahlen zusammen und gibt sie aus
	/// </summary>
	/// <param name="zahl1">Die erste Zahl</param>
	/// <param name="zahl2">Die zweite Zahl</param>
	static void AddiereAusgabe(int zahl1, int zahl2) //Funktionsdefinition: <Rückgabewert> <Name>(<Parameter1>, <Parameter2>, ...)
	{
		Console.WriteLine(zahl1 + zahl2);
	}

	static int Addiere(int zahl1, int zahl2)
	{
		return zahl1 + zahl2; //Gibt einen Wert zurück
	}

	//static int Addiere(int zahl1, int zahl2) { }

	static int Addiere(int zahl1, int zahl2, int zahl3) //3 Parameter statt 2
	{
		return zahl1 + zahl2 + zahl3;
	}

	static double Addiere(double z1, double z2) //2 Doubles statt 2 Ints
	{
		return z1 + z2;
	}

	static int Addiere(params int[] zahlen) //params: beliebig viele Parameter, muss der letzte Parameter sein
	{
		return zahlen.Sum();
	}

	static int Subtrahiere(int z1, int z2)
	{
		return z1 - z2;
	}

	static int Subtrahiere(int z1, int z2, int z3 = 0, int z4 = 5) //Standardwert für z3 (0), müssen die letzten Parameter sein
	{
		return z1 - z2 - z3 - z4;
	}

	static int AddiereUndSubtrahiere(int z1, int z2, out int sub) //out: funktioniert wie extra return Wert
	{
		sub = z1 - z2; //alle out Parameter zuweisen
		return z1 + z2; //return den eigentlichen Wert
	}
}