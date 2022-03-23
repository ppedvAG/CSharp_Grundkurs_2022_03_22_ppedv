using M006_OOP_Test; //NamespaceTest importieren
using M006_OOP.UnterNamespace;
using System; //Console importieren

namespace M006_OOP //Namespace
{
	public class Program //M006_OOP.Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(); //using System notwendig
			//NamespaceTest nt = new NamespaceTest(); //Klasse in anderem Namespace muss importiert werden
			UnterNamespace.NamespaceTest unt = new UnterNamespace.NamespaceTest(); //Speziell klassifizieren bei Namenskonflikt
			unt.Print(); //Methode in Objekt aufrufen
			unt.Test = 5; //Feld in Objekt angreifen

			PropertiesTest pt = new PropertiesTest(); //Konstruktor wird aufgerufen
			pt.Nachname = "Maier";

			PropertiesTest pt2 = new PropertiesTest("Max", "Mustermann");
		}
	}

	enum Wochentag //Enum im selben Namespace (M006_OOP.Wochentag)
	{
		Montag,
		Dienstag,
		Mittwoch,
		Donnerstag,
		Freitag,
		Samstag,
		Sonntag
	}
}

namespace M006_OOP.UnterNamespace
{
	public class NamespaceTest
	{
		public int Test;

		public void Print() { }
	}
}