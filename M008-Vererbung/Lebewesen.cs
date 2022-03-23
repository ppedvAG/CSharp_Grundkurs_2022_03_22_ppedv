namespace M008_Vererbung;

public class Lebewesen
{
	public string Name { get; set; }

	public Lebewesen(string name)
	{
		Name = name;
	}

	public void WasBinIch() //Methode wird auch mitgebenen nach unten
	{
		Console.WriteLine("Lebewesen wurde erzeugt");
	}

	public virtual void WasBinIchVirtual() //virtual wird auch weitergegeben
	{
		Console.WriteLine("Lebewesen wurde erzeugt");
	}
}

public class Mensch : Lebewesen //Mensch ist Lebewesen
{
	//Name Feld übernommen

	public int Alter { get; set; }

	public Mensch(string name, int alter) : base(name)
	{
		Alter = alter;
		WasBinIchVirtual();
	}

	public void WasBinIch() //2 WasBinIch Methoden
	{
		Console.WriteLine("Mensch wurde erzeugt");
	}

	public sealed override void WasBinIchVirtual()
	{
		Console.WriteLine("Mensch wurde erzeugt");
	}
}

public class Kind : Mensch //sealed funktioniert auch bei Klassen
{
	public int Groesse { get; set; }

	public Kind(string name, int alter, int groesse) : base(name, alter)
	{
		Groesse = groesse;
		Console.WriteLine("Kind wurde erzeugt");
	}

	//public override void WasBinIchVirtual() //sealed: kann nicht weitervererbt werden
	//{
	//	Console.WriteLine("Kind wurde erzeugt");
	//}
}