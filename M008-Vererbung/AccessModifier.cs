namespace M008_Vererbung.AccessModifier
{
	public class Mensch
	{
		public string Name { get; set; } //Kann überall gesehen werden (auch außerhalb vom Projekt)

		private int Groesse { get; set; } //Kann nur in Lebewesen gesehen werden

		internal string Wohnort { get; set; } //Kann nur im eigenen Projekt gesehen werden


		protected string Lieblingsfarbe { get; set; } //Kann nur in Lebewesen UND Unterklassen gesehen werden (auch außerhalb vom Projekt)

		protected internal string Lieblingsnahrung { get; set; } //Kann nur im Projekt UND Unterklassen gesehen werden (internal und zusätzlich protected)

		protected private DateTime Geburtsdatum { get; set; } //Kann nur in Lebewesen und Unterklassen gesehen (nur im Projekt)
	}

	public class Kind : Mensch { }
}
