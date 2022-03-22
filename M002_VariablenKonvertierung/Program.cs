#region Variablen
//Variable: <Typ> <Name>
int Zahl; //Definition
Zahl = 10; //Zuweisung mit =
		   //cw -> Tab -> Tab: Console.WriteLine
Console.WriteLine(Zahl);

//Variable mit Zuweisung
int ZahlMitZuweisung = 10;
Console.WriteLine(ZahlMitZuweisung);

//Arithmetik
int ZahlMitArithmetik = Zahl * 2;
Console.WriteLine(ZahlMitArithmetik);

//Zeichenkette
string Stadt = "Berlin";
Console.WriteLine(Stadt);

/*
 * Mehrzeilige
 * Kommentare
 */

//Einzelnes Zeichen
char Zeichen = 'A';
Console.WriteLine(Zeichen);

#region Gleitkommazahlen
//Kommazahlen
float Float = 123.45f;
Console.WriteLine(Float);

Console.WriteLine(0.1f + 0.2f); //Gleitkommaungenauigkeit: 0.1 + 0.2 = 0.3000000000000000000004

double Double = 123.45;
Console.WriteLine(Double);

//Decimal für Geldwerte
//0.30000000000000000000000000000000000000000004
decimal Geld = 3.50m;
Console.WriteLine(Geld);

//_ in Numerischen Werten = Trennzeichen
decimal Trennzeichen = 235_324.24_36_74_23_95m;
Console.WriteLine(Trennzeichen);
#endregion

//Wahr/Falsch Wert
bool WahrFalsch = false;
Console.WriteLine(WahrFalsch);
#endregion

//Strg + K -> Strg + C: Markierte Zeilen auskommentieren
//Strg + K -> Strg + U: Markierte Zeilen einkommentieren

#region Stringoperationen
//https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=msvc-170

//\n: Umbruch
string Umbruch = "Hallo ich bin \nein String";
Console.WriteLine(Umbruch);

//\t: Tab
string Tab = "Hallo ich bin \tein String";
Console.WriteLine(Tab);

//+: Strings verbinden
Console.WriteLine(Umbruch + Tab);

//Platzhalter
string Platzhalter = "Test";
Console.WriteLine("Platzhalter: {0} {1}", Platzhalter, Umbruch);

//String Interpolation: $ am Anfang
string StringInterpolation = $"Interpolated: {Platzhalter}";
Console.WriteLine(StringInterpolation);

//Pfad mit \\ -> \
string Pfad = "C:\\Users";
Console.WriteLine(Pfad);

//Verbatim String: Keine Escapesequenzen, nimmt alles wie es da steht
string VerbatimString = @"C:\Users
Umb	ruch";
Console.WriteLine(VerbatimString);
#endregion

#region Eingabe
string Eingabe = Console.ReadLine(); //Eingabe bis Enter
Console.WriteLine(Eingabe);

char EingabeChar = Console.ReadKey().KeyChar; //Einzelne Zeicheneingabe (ohne Enter)
Console.WriteLine(EingabeChar);

string EingabeZahl = Console.ReadLine();
int ParseZahl = int.Parse(EingabeZahl); //int.Parse: String in Int umwandeln
Convert.ToInt32(EingabeZahl); //Convert ist die alte Methode (statt Parse)
Console.WriteLine(ParseZahl * 10);

string EingabeDouble = Console.ReadLine(); //Beistrich = Kommazeichen, Punkt = Tausendertrennzeichen
double ParseDouble = double.Parse(EingabeDouble);
Console.WriteLine(ParseDouble * 5.0);
#endregion

#region Konvertierungen
//Impliziter Cast
int Implizit = 30;
double ImplizitCast = Implizit;

//Expliziert Cast (Typ muss angegeben werden)
double Konvert = 20.5;
int ZuInt = (int) Konvert; //Kommastellen abgeschnitten
Console.WriteLine(ZuInt);

char CharCast = (char) 72;
Console.WriteLine(CharCast);

//double KonvertPretty = 20.5;
//int ZuIntPretty = KonvertPretty as int; //Auch ein Cast (funktioniert nur wenn Typ nicht nullable)
#endregion

#region Arithmetik
int Zahl1 = 7;
int Zahl2 = 3;
Console.WriteLine(Zahl1 % Zahl2); //Modulo (%): Gibt den Rest einer Division zurück

Console.WriteLine(Zahl1 + 1); //Keine Zuweisung

Zahl1++; //Erhöhe Zahl um 1
Zahl1--; //Verringere Zahl um 1
Zahl1 += 3; //Erhöhe Zahl um X
Console.WriteLine(Zahl1);

Console.WriteLine(Math.Min(Zahl1, Zahl2)); //Kleinere Zahl
Console.WriteLine(Math.Max(Zahl1, Zahl2)); //Größere Zahl

double ToRound = 2.5;
Console.WriteLine(Math.Round(ToRound)); //Round rundet auf oder ab, .5 rundet auf die nächste gerade Zahl
Console.WriteLine(Math.Floor(ToRound)); //Floor: immer abrunden
Console.WriteLine(Math.Ceiling(ToRound)); //Ceiling: immer aufrunden
#endregion