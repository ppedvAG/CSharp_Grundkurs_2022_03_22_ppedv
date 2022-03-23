namespace M006_OOP_Test
{
	public class PropertiesTest
	{
		#region Alte Schreibweise
		private string vorname;
		
		public void SetVorname(string vorname)
		{
			this.vorname = vorname;
		}

		public string GetVorname()
		{
			return vorname;
		}
		#endregion

		private string nachname; //Versteckte Variable

		public string Nachname //Property mit Get und Set und Check im Set
		{
			get => nachname; //=> sind eigentlich { }
			set
			{
				if (!string.IsNullOrEmpty(value))
					nachname = value;
			}
		}

		private int gehalt = 3000; //Standardwert bei privater Variable

		public int Gehalt
		{
			get => gehalt; //Get-only Property
		}

		public string GehaltString => gehalt + "€";

		public DateTime Geburtsdatum { get; set; } = DateTime.Now; //Standardwert nur bei { get; set; }

		public PropertiesTest() //Standardkonstruktor
		{
			vorname = "Max";
			nachname = "Mustermann";
		}

		public PropertiesTest(string vorname, string nachname) //Konstruktor mit Parametern
		{
			this.vorname = vorname;
			this.nachname = nachname;
		}
	}
}
