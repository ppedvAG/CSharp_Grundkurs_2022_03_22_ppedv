namespace M011_Linq;

public class Program
{
	static void Main(string[] args)
	{
		#region Einfaches Linq
		//Erstellt eine Liste von Start mit einer bestimmten Anzahl Elemente
		//(5, 20): gibt eine Liste mit 5-24 zurück (Start:5, 20 Elemente)
		List<int> linqTest = Enumerable.Range(1, 20).ToList(); //Konvertiert das IEnumerable<T> zu List<T>

		Console.WriteLine(linqTest.Average());
		Console.WriteLine(linqTest.Min());
		Console.WriteLine(linqTest.Max());

		Console.WriteLine(linqTest.Sum());

		Console.WriteLine(linqTest.First()); //Erstes Element der Liste, Exception wenn kein Element
		Console.WriteLine(linqTest.FirstOrDefault()); //null zurück wenn kein Element

		Console.WriteLine(linqTest.Last());
		Console.WriteLine(linqTest.LastOrDefault());
		#endregion

		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		#region Vergleich Schreibweisen
		//Schleifenform um alle BMWs zu finden
		List<Fahrzeug> bmwsForEach = new List<Fahrzeug>();
		foreach (Fahrzeug auto in fahrzeuge)
			if (auto.Marke == FahrzeugMarke.BMW)
				bmwsForEach.Add(auto);

		//Standard Linq: SQL-ähnliche Schreibweise (alt)
		List<Fahrzeug> bmws = (from auto in fahrzeuge
							   where auto.Marke == FahrzeugMarke.BMW
							   select auto).ToList(); //Für ToList() keine eigene Funktionalität

		//Methodenkette: Neueste Schreibweise
		List<Fahrzeug> bmwsNeu = fahrzeuge.Where(auto => auto.Marke == FahrzeugMarke.BMW).ToList();
		#endregion

		//Holt die höchste Geschwindigkeit (selbiges w.o. mit Min und Average)
		Console.WriteLine(fahrzeuge.Max(auto => auto.MaxGeschwindigkeit));

		//OrderBy sortiert aufsteigend
		//Schnellste Auto
		Fahrzeug fzg = fahrzeuge.OrderByDescending(auto => auto.MaxGeschwindigkeit).First();
		Console.WriteLine($"Das schnellste Fahrzeug ist ein {fzg.Marke} und die Höchstgeschwindigkeit ist {fzg.MaxGeschwindigkeit}");

		//Select: Projiziert die originale anhand einer Bedingung auf eine neue Liste
		List<FahrzeugMarke> alleMarken = fahrzeuge.Select(auto => auto.Marke).ToList();

		//Distinct: Jeder Wert nur einmal
		List<FahrzeugMarke> distinct = alleMarken.Distinct().ToList();

		//Summiert alle Geschwindigkeiten
		int summeGeschwindigkeiten = fahrzeuge.Sum(auto => auto.MaxGeschwindigkeit);

		//Durchschnittsgeschwindigkeit aller VWs
		double avgVW = fahrzeuge
			.Where(auto => auto.Marke == FahrzeugMarke.VW)
			.Average(fzg => fzg.MaxGeschwindigkeit);

		//Mehrere Bedingungen im Where
		double avgVWueber200 = fahrzeuge.Where(auto => auto.Marke == FahrzeugMarke.VW && auto.MaxGeschwindigkeit >= 200).Average(auto => auto.MaxGeschwindigkeit);

		//Checkt ob ALLE Elemente eine Bedingung erfüllen
		bool alleAutosSchnell = fahrzeuge.All(auto => auto.MaxGeschwindigkeit >= 150);

		//Checkt ob mindestens ein Element die Bedingung erfüllt
		bool einAutoSchnell = fahrzeuge.Any(auto => auto.MaxGeschwindigkeit >= 150);

		//Gruppiert die Fahrzeuge nach Automarke
		//BMW -> 4 Fahrzeuge
		//Audi -> 4 Fahrzeuge
		//VW -> 4 Fahrzeuge
		var groupedFahrzeug = fahrzeuge.GroupBy(auto => auto.Marke);

		//Einfacher Pagingalgorithmus
		List<Fahrzeug> pagedFahrzeuge;
		int elementsPerPage = 4;

		for (int i = 0; i < fahrzeuge.Count / elementsPerPage; i++)
			pagedFahrzeuge = fahrzeuge.Skip(i * elementsPerPage).Take(elementsPerPage).ToList();

		//Chunk: teilt Liste in gleich große Stücke
		var allPages = fahrzeuge.Chunk(elementsPerPage);

		//ToDictionary: Erstellt ein Dictionary 
		Dictionary<FahrzeugMarke, IEnumerable<int>> autoDict = distinct.ToDictionary(marke => marke, marke => fahrzeuge.Where(e => e.Marke == marke).Select(e => e.MaxGeschwindigkeit));

		//Schöne Ausgabe
		string ausgabe = "";
		foreach (Fahrzeug fahrzeug in fahrzeuge)
			ausgabe += $"Marke: {fahrzeug.Marke}, Maximalgeschwindigkeit: {fahrzeug.MaxGeschwindigkeit}\n";
		Console.WriteLine(ausgabe);

		//Schöne Ausgabe mit Aggregate
		string agg = fahrzeuge.Aggregate("", (str, fzg) => str + $"Marke: {fzg.Marke}, Maximalgeschwindigkeit: {fzg.MaxGeschwindigkeit}\n");
		Console.WriteLine(agg);

		//Aggregate mit Summe (statt Sum)
		int aggSum = fahrzeuge.Aggregate(0, (sum, fzg) => sum += fzg.MaxGeschwindigkeit);
		Console.WriteLine(aggSum);
		
		//Erweiterungsmethode (eigene Linq Funktion)
		List<FahrzeugMarke> alleMarken2 = fahrzeuge.AlleAutomarken();

		//Alle Fahrzeugmarken mit den entsprechenden Höchstgeschwindigkeiten
		Dictionary<FahrzeugMarke, int> gFahrzeuge = fahrzeuge
			.GroupBy(e => e.Marke)
			.ToDictionary(e => e.Key, e => e.Select(x => x.MaxGeschwindigkeit).Max());
	}
}

public class Fahrzeug
{
	public int MaxGeschwindigkeit;

	public FahrzeugMarke Marke;

	public List<Sitzplatz> Sitze;

	public Fahrzeug(int v, FahrzeugMarke fm)
	{
		MaxGeschwindigkeit = v;
		Marke = fm;

		Sitze = new List<Sitzplatz>();
		int sitze = v <= 150 ? 6 : v <= 250 ? 5 : 4;
		for (int i = 0; i < sitze; i++)
			Sitze.Add(new Sitzplatz());

		for (int i = 0; i < v % (sitze + 1); i++)
			Sitze[i].IstBesetzt = true;
	}
}

public class Sitzplatz
{
	public bool IstBesetzt;
}

public enum FahrzeugMarke
{
	BMW,
	Audi,
	VW
}