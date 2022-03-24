namespace M011_GenerischeListen;

public class Program
{
	static void Main(string[] args)
	{
		List<string> staedte = new List<string>(); //Generischer Typ: Gibt an Methoden den Typ weiter
		staedte.Add("Hamburg"); //Add hat jetzt string statt T
		staedte.Add("Wien");
		staedte.Add("Berlin");
		staedte.Add("Köln");

		Console.WriteLine(staedte[1]); //Element angreifen wie bei einem Array

		Console.WriteLine(staedte.Count); //Count statt Length

		staedte[2] = "Dresden"; //Wie beim Array Elemente ändern mit []

		staedte.Remove("Hamburg"); //Schiebt Elemente nach

		staedte.RemoveAt(2);

		foreach (string s in staedte) //Liste iterieren
		{
			Console.WriteLine(s);
		}

		staedte.ForEach(s => Console.WriteLine(s));

		staedte.Sort(); //Sortiert die Liste

		staedte.Find(stadt => stadt.StartsWith("B")); //Find mit Prädikat (e => ...)

		Stack<string> staedteStack = new Stack<string>();
		staedteStack.Push("Hamburg");
		staedteStack.Push("Wien");
		staedteStack.Push("Berlin");
		staedteStack.Push("Köln");

		Console.WriteLine(staedteStack.Peek()); //Köln

		Console.WriteLine(staedteStack.Pop()); //Köln zurückgeben

		Queue<string> staedteQueue = new Queue<string>();
		staedteQueue.Enqueue("Hamburg");
		staedteQueue.Enqueue("Wien");
		staedteQueue.Enqueue("Berlin");
		staedteQueue.Enqueue("Köln");

		Console.WriteLine(staedteQueue.Peek()); //Hamburg

		Console.WriteLine(staedteQueue.Dequeue()); //Hamburg zurückgeben

		Dictionary<string, int> einwohnerzahlen = new Dictionary<string, int>(); //Dictionary: Liste von KeyValuePairs, Keys müssen eindeutig sein
		einwohnerzahlen.Add("Wien", 2_000_000);
		einwohnerzahlen.Add("Berlin", 3_650_000);
		einwohnerzahlen.Add("Paris", 2_160_000);

		if (einwohnerzahlen.ContainsKey("Wien")) //ContainsKey: Checken ob Key existiert
			Console.WriteLine(einwohnerzahlen["Wien"]); //Key in [] verwenden um entsprechenden Value zu holen

		Console.WriteLine(einwohnerzahlen.ContainsValue(2_000_000));

		einwohnerzahlen.Remove("Berlin"); //Entfernt KeyValuePair anhand des Keys

		foreach (KeyValuePair<string, int> kv in einwohnerzahlen)
		{
			Console.WriteLine($"Die Stadt {kv.Key} hat {kv.Value} Einwohner");
		}
	}

	public static void PrintType<T>() //Methode mit generischem Argument
	{
		Console.WriteLine(typeof(T).Name);
	}

	public static void PrintTypeRestricted<T>() where T : Program //where T : ...: restriktiert den möglichen Übergabewert
	{
		Console.WriteLine(typeof(T).Name);
	}
}