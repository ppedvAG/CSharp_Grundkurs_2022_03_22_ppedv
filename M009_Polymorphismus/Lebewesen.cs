namespace M009_Polymorphismus;

public abstract class Lebewesen //Abstrakte Klasse: Kann kein Objekt erstellen und dient als Struktur für Unterklassen
{
	public string Name { get; set; }

	public Lebewesen(string name)
	{
		Name = name;
	}

	public abstract void WasBinIch(); //Abstrakte Methode ohne Body, muss überschrieben werden

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

	public sealed override void WasBinIchVirtual()
	{
		Console.WriteLine("Mensch wurde erzeugt");
	}

	public override void WasBinIch()
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