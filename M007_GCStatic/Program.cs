namespace M007_GCStatic
{
	public class Program
	{
		static void Main(string[] args)
		{
			Fahrzeug fzg = new Fahrzeug();
			//Hier wird das Objekt nicht mehr benötigt und wird eingesammelt

			int sum = 0;
			Fahrzeug.FahrzeugZähler(); //Statische Methode in Fahrzeug
			Addiere(10, ref sum); //Hier mit ref die Referenzvariable angeben
			Addiere(10, ref sum);
			Addiere(10, ref sum);
			Addiere(10, ref sum);
			Console.WriteLine(sum);
		}

		public static void Addiere(int z1, ref int refInt) //ref: Referenz zu einer Variable herstellen
		{
			refInt += z1; //Auf die Variable zugreifen
		}
	}

	public class Fahrzeug
	{
		public string Name { get; set; }

		public int Geschwindigkeit { get; set; }

		//Statisches Feld
		public static int AnzahlFahrzeuge;

		//Statische Methode
		public static void FahrzeugZähler() => AnzahlFahrzeuge++;

		~Fahrzeug() //Desktruktor
		{
			Console.WriteLine("Fahrzeug wurde eingesammelt");
		}

		public Fahrzeug()
		{
			FahrzeugZähler();
		}
	}
}