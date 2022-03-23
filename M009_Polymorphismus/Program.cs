namespace M009_Polymorphismus;

public class Program
{
	static void Main(string[] args)
	{
		Lebewesen lw = new Mensch("Max", 45);
		if (lw.GetType() == typeof(Lebewesen)) //Laufzeittypvergleich
		{
			Console.WriteLine("lw ist Lebewesen");
		}

		if (lw.GetType() == typeof(Mensch)) //Laufzeittypvergleich
		{
			Console.WriteLine("lw ist Mensch");
		}

		if (lw is Lebewesen)
		{
			Console.WriteLine("lw ist Lebewesen");
		} //Typvergleich nur kurz

		if (lw is Mensch)
		{
			Console.WriteLine("lw ist Mensch");
		}

		Console.Write("1: ");
		lw.WasBinIchVirtual(); //Objekt vom Typ Methode -> Methode von Mensch
		Console.Write("2: ");
		lw.WasBinIch(); //Variable vom Typ Lebewesen -> Methode von Lebewesen

		Mensch m = (Mensch) lw;
		Console.Write("3: ");
		m.WasBinIchVirtual(); //Objekt vom Typ Methode -> Methode von Mensch
		Console.Write("4: ");
		m.WasBinIch(); //Variable vom Typ Mensch -> Methode vom Mensch

		List<Lebewesen> lebewesens = new List<Lebewesen>(); //Liste von Lebewesen, kann alle möglichen Lebewesen (Mensch, Kind) halten
		lebewesens.Add(m);
		lebewesens.Add(new Kind("Max", 11, 120));
		foreach (Lebewesen leb in lebewesens) //Liste iterieren und dem Typ entsprechende Methoden aufrufen
		{
			if (leb is Mensch)
			{
				Mensch mensch = (Mensch) leb;
				//...
			}

			if (leb is Kind)
			{
				Kind kind = (Kind)leb;
				//...
			}
		}
	}
}