using System.Collections;

namespace M016_Sonstiges;

public class Program
{
	static void Main(string[] args)
	{
		Zug zug1 = new Zug();
		Zug zug2 = new Zug();
		Zug newZug = zug1 + zug2;

		Wagon wagon1 = new Wagon();
		Wagon wagon2 = new Wagon();
		if (wagon1 == wagon2)
		{

		}

		if (wagon1 <= wagon2)
		{

		}

		foreach (Wagon wagon in zug1)
		{

		}

		zug1[2] = new Wagon();
	}
}
public class Zug : IEnumerable
{
	private List<Wagon> Wagons { get; set; } = new List<Wagon>();

	public IEnumerator GetEnumerator()
	{
		foreach (Wagon wagon in Wagons)
		{
			yield return wagon;
		}
	}

	public Wagon this[int index]
	{
		get => Wagons[index];
		set => Wagons[index] = value;
	}

	public static Zug operator +(Zug a, Zug b)
	{
		Zug zug = new Zug();
		zug.Wagons.AddRange(a.Wagons);
		zug.Wagons.AddRange(b.Wagons);
		return zug;
	}
}

public class Wagon
{
	public int Sitzplaetze { get; set; }

	public string Farbe { get; set; }

	public static bool operator <=(Wagon a, Wagon b)
	{
		return a.Sitzplaetze <= b.Sitzplaetze;
	}

	public static bool operator >=(Wagon a, Wagon b)
	{
		return a.Sitzplaetze >= b.Sitzplaetze;
	}

	public static bool operator ==(Wagon a, Wagon b)
	{
		return a.Sitzplaetze == b.Sitzplaetze && a.Farbe == b.Farbe;
	}

	public static bool operator !=(Wagon a, Wagon b)
	{
		return a.Sitzplaetze != b.Sitzplaetze || a.Farbe != b.Farbe;
	}
}