namespace M010_Interfaces;

public class Program
{

	static void Main(string[] args)
	{
		IArbeit mensch = new Mensch();
		mensch.Lohnauszahlung();
		mensch.Lohnauszahlung2(); //Don't

		int stunden = IArbeit.Wochenstunden; //Zugriff auf statische Resource

		Mensch m = mensch as Mensch;
		(m as IArbeit).Lohnauszahlung();  //Mensch hat die Lohnauszahlung Methode "geerbt"
		(m as ITeilzeitArbeit).Lohnauszahlung();

		m.Clone();
	}
}

public class Mensch : IArbeit, ITeilzeitArbeit, ICloneable, IComparable<Mensch>
{
	private int gehalt;

	public int Gehalt 
	{ 
		get => gehalt; 
		set => gehalt = value; 
	}

	private string job;

	public string Job
	{ 
		get => job;
		set => job = value;
	}

	void IArbeit.Lohnauszahlung()
	{
		Console.WriteLine($"Dieser Mensch hat ein Gehalt von {Gehalt} mit {IArbeit.Wochenstunden} Stunden für den Job {Job} verdient");
	}

	void ITeilzeitArbeit.Lohnauszahlung()
	{
		Console.WriteLine($"Dieser Mensch hat ein Gehalt von {Gehalt} mit {ITeilzeitArbeit.Wochenstunden} Stunden für den Job {Job} verdient");
	}

	public object Clone()
	{
		return new Mensch() { Gehalt = gehalt, Job = job };
	}

	public int CompareTo(Mensch? other)
	{
		//0 bedeutet gleich
		return gehalt.CompareTo(other.gehalt) == 0 && job.CompareTo(other.job) == 0 ? 0 : -1;
	}
}

public interface IArbeit
{
	static int Wochenstunden = 40; //Statische Resource

	int Gehalt { get; set; } //Keine Implementierung

	string Job { get; set; }

	void Lohnauszahlung(); //Kein Body

	void Lohnauszahlung2()
	{
		//Body in Interface möglich aber Bad Practice
	}
}

public interface ITeilzeitArbeit : IArbeit //Interface vererben
{
	static new int Wochenstunden = 20; //new um Member vom Überinterface zu überschreiben

	new void Lohnauszahlung();
}