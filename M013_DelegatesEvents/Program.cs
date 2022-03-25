namespace M013_DelegatesEvent;

public class Program
{
	static void Main2(string[] args)
	{
		Vorstellungen vorstellungen = new Vorstellungen(VorstellungDE);
		vorstellungen += new Vorstellungen(VorstellungEN);
		vorstellungen("Max");

		foreach (Delegate dg in vorstellungen.GetInvocationList()) //Alle Methoden die dranhängen
		{
			Console.WriteLine(dg.Method); //Die derzeitige Methode ausgeben
		}

		vorstellungen -= VorstellungEN;
		vorstellungen("Max");

		vorstellungen = null;
	}

	//Speichert Referenzen zu anderen Methoden, können zur Laufzeit hinzugefügt oder weggenommen werden
	public delegate void Vorstellungen(string name);

	public static void VorstellungDE(string name)
	{
		Console.WriteLine($"Hallo mein Name ist {name}");
	}

	public static void VorstellungEN(string name)
	{
		Console.WriteLine($"Hello my name is {name}");
	}
}