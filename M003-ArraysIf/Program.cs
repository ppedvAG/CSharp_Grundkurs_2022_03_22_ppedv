#region Array
int[] Zahlen = new int[5]; //Array mit Länge 5 (0-4)
Zahlen[1] = 5; //Stellen fangen bei 0 an (und endet bei 4)
Console.WriteLine(Zahlen[1]);

int[] ZahlenDirekt = new int[] { 1, 2, 3, 4, 5 }; //Direkte Initialisierung

int[] ZahlenDirektKurz = new[] { 1, 2, 3, 4, 5 }; //Kurzschreibweise

int[] ZahlenDirektNochKuerzer = { 1, 2, 3, 4, 5 }; //Noch kürzer

Console.WriteLine(ZahlenDirekt.Length);

Console.WriteLine(ZahlenDirektKurz.Sum());

bool HatDrei = Zahlen.Contains(3); //Checkt ob der Wert in dem Array ist

/*	Array Darstellung:
 *	| 0, 0, 0 |
 *	| 0, 3, 0 |
 *	| 0, 0, 0 |
 */
int[,] ZweiDArray = new int[3, 3]; //Matrix (3x3), beliebig viele Dimensionen mit Beistrichen
ZweiDArray[1, 1] = 3;
Console.WriteLine(ZweiDArray[1, 1]);
Console.WriteLine(ZweiDArray.Length); //Gibt die Anzahl an Feldern zurück
Console.WriteLine(ZweiDArray.Rank); //Gibt die Anzahl an Dimensionen zurück
Console.WriteLine(ZweiDArray.GetLength(1)); //GetLength(Dimension): gibt die Länge einer Dimension zurück

int[,] ZweiDArrayDirekt = //Direkt initialisiert
{
	{ 1, 2, 3 },
	{ 4, 5, 6 }
};
#endregion

#region Bedingungen
int Zahl1 = 5;
int Zahl2 = 7;

bool IstGleich = Zahl1 == Zahl2; //false
bool IstUngleich = Zahl1 != Zahl2; //true

bool Kleiner = Zahl1 < Zahl2;
bool Groeßer = Zahl1 > Zahl2;

//KleinerGleich (<=), GrößerGleich (>=)

if (Zahl1 == 5) //Wenn Bedingung (Zahl1 gleich 5)
{
	Console.WriteLine("Zahl1 ist 5");
}
else //Wenn nicht Bedingung (Zahl1 ungleich 5)
{
	Console.WriteLine("Zahl1 ist nicht 5");
}

if (Zahl2 == 7) //Einzeiliger Code kann ohne Klammern geschrieben werden
	Console.WriteLine("Zahl2 ist 7");
else if (Zahl2 == 8) //Else If
	Console.WriteLine("Zahl2 ist 8");

if (Zahl2 == 7) { }
else //Else If ausgeschrieben
{
	if (Zahl2 == 8) { }
}

//&& ist true wenn beide Werte true sind
//|| ist true wenn einer von Werten oder beide true ist

/* Beide Inputs sind false
 * A ist false, B ist true
 * A ist true, B ist false
 * Beide Inputs sind true
 */
bool IstMittwoch = false;
bool IstSonnig = true;
if (IstMittwoch && IstSonnig)
	Console.WriteLine("Es ist ein sonniger Mittwoch");

if (!IstMittwoch && IstSonnig)
	Console.WriteLine("Es ist nicht Mittwoch und Sonnig");

if (IstMittwoch || IstSonnig)
	Console.WriteLine("Es ist Mittwoch oder Sonnig");

if (Zahl1 == 5 && Zahl2 == 7) //Mehrere Bedingungen
	Console.WriteLine("Zahl1 ist 5 und Zahl2 ist 7");

//Fragezeichen Operator (?, :) ? ist if, : ist else
//Fragezeichen Operator braucht immer ein else
Console.WriteLine(Zahl1 == 5 && Zahl2 == 7 ? "Zahl1 ist 5 und Zahl2 ist 7" : "");
#endregion