#region Schleifen
int a = 0;
int b = 10;
while (a < b) //While: läuft bis die Bedingung false ist
{
	a++;
	Console.WriteLine("while: " + a);
}

//while (true) { } //Endlosschleife

int c = 20;
int d = 10;
do //läuft mindestens einmal
{
	c++;
	Console.WriteLine("do-while: " + c);
}
while (c < d);

int e = 0;
int f = 10;
while (e < f)
{
	e++;
	if (e == 5)
		continue; //continue: Springt zurück in den Schleifenkopf
	Console.WriteLine("while mit continue: " + e);
}

int g = 0;
int h = 10;
while (g < h)
{
	g++;
	if (g == 5)
		break; //break: Beendet die Schleife
	Console.WriteLine("while mit break: " + g);
}

for (int i = 0; i < 10; i++) //Schleife mit Zähler <Zähler>; <Bedingung>; <Inkrement>
{
	Console.WriteLine("for: " + i);
}

for (int i = 9; i >= 0; i--) //for-Schleife Rückwärts
{
	Console.WriteLine("for-minus: " + i);
}

for (int i = 0; i < 50; i += 5) //Inkrement kann auch mehr als ++ sein
{
	Console.WriteLine("for + 5:" + i);
}

int[] Zahlen = { 23, 63, 14, 92, 47 };
for (int i = 0; i < Zahlen.Length; i++) //Array durchgehen
{
	Console.WriteLine("for mit Array: " + Zahlen[i]);
}

foreach (int zahl in Zahlen) //sicherer, da nicht daneben greifen kann
{
	Console.WriteLine("foreach: " + zahl);
}
#endregion

#region Enums
string[] WochentageArray = { "Montag", "Dienstag", "Mittwoch", "Donnerstag" }; //unpraktisch

Wochentag heute = Wochentag.Dienstag; //Wochentag Definition mit Zuweisung
Console.WriteLine(heute);

Wochentag castTag = (Wochentag) 3; //Int zu Enum Cast
Console.WriteLine(castTag);

Wochentag lieblingsTag = (Wochentag) int.Parse(Console.ReadLine()); //Int Input zu Enum Cast
Console.WriteLine(lieblingsTag);

Wochentag lieblingsTagString = (Wochentag) Enum.Parse(typeof(Wochentag), Console.ReadLine());
Console.WriteLine(lieblingsTagString);
#endregion

#region Switch
Wochentag tag = Wochentag.Sonntag;
if (tag == Wochentag.Montag) //Negativbeispiel
	Console.WriteLine("Wochenanfang");
else if (tag == Wochentag.Dienstag || tag == Wochentag.Mittwoch || tag == Wochentag.Donnerstag)
	Console.WriteLine("Wochenmitte");
else
	Console.WriteLine("Wochenende");

switch (tag) //If-Else von oben nur übersichtlicher
{
	case Wochentag.Montag:
		Console.WriteLine("Wochenanfang");
		break;
	case Wochentag.Dienstag:
	case Wochentag.Mittwoch:
	case Wochentag.Donnerstag:
		Console.WriteLine("Wochenmitte");
		break;
	case Wochentag.Freitag:
	case Wochentag.Samstag:
	case Wochentag.Sonntag:
		Console.WriteLine("Wochenende");
		break;
	default: //Wenn kein case gefunden
		Console.WriteLine("Etwas ist schief gelaufen");
		break;
}

switch (tag) //switch mit Boolscher Logik
{
	case Wochentag.Montag:
		Console.WriteLine("Wochenanfang");
		break;
	case >= Wochentag.Dienstag and <= Wochentag.Donnerstag:
		Console.WriteLine("Wochenmitte");
		break;
	case >= Wochentag.Freitag and <= Wochentag.Sonntag:
		Console.WriteLine("Wochenende");
		break;
	default:
		Console.WriteLine("Etwas ist schief gelaufen");
		break;
}
#endregion

enum Wochentag
{
	Montag = 1, //selber int Wert festlegen
	Dienstag,
	Mittwoch,
	Donnerstag = 10, //Werte danach schieben sich auch hier auf
	Freitag,
	Samstag,
	Sonntag
}