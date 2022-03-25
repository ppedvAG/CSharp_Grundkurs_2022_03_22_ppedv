using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace M015_Files;

public class Program
{
	static void Main(string[] args)
	{
		//Desktop Folder
		string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

		//Path Klasse zum Pfade verbinden
		string folderPath = Path.Combine(desktop, "Test");

		if (!Directory.Exists(folderPath)) //Directory Klasse für alles mit Ordnern
			Directory.CreateDirectory(folderPath);

		string filePath = Path.Combine(folderPath, "Test.txt");
		//StreamWriterTest(filePath);
		//StreamReaderTest(filePath);
		//JsonTest(filePath);
		//XmlTest(filePath);
		//CSVTest(filePath);
	}

	public static void StreamWriterTest(string filePath)
	{
		StreamWriter sw = new StreamWriter(filePath);
		sw.WriteLine("Test1"); //Buffer beschreiben
		sw.WriteLine("Test2");
		sw.WriteLine("Test3");
		sw.Flush(); //Flush: Schreibe Inhalt auf die Festplatte
		sw.Dispose(); //Schließe Writer und den Stream


		//using um StreamWriter automatisch zu schließen
		//AutoFlush: schreibe nach jedem WriteLine den Stream auf die Festplatte
		using StreamWriter sw2 = new StreamWriter(filePath) { AutoFlush = true };
		sw.WriteLine("Test1");
		sw.WriteLine("Test2");
		sw.WriteLine("Test3");
	}

	public static void StreamReaderTest(string filePath)
	{
		if (File.Exists(filePath))
		{
			using StreamReader sr = new StreamReader(filePath);
			string[] str = sr.ReadToEnd().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries); //File Zeile für Zeile in einem String Array

			sr.BaseStream.Position = 0; //Stream zurücksetzen

			//Zeile für Zeile statt alles auf einmal
			List<string> lines = new List<string>();
			string currentLine = sr.ReadLine();
			lines.Add(currentLine);
			while (!sr.EndOfStream) //EndOfStream: Gibt das Ende vom File an
			{
				currentLine = sr.ReadLine();
				lines.Add(currentLine);
			}
		}
	}

	public static void JsonTest(string filePath)
	{
		Fahrzeug f = new Fahrzeug() { MaxGeschwindigkeit = 250, AutoMarke = "VW" };
		string json = JsonConvert.SerializeObject(f);
		File.WriteAllText(filePath, json);

		string readJson = File.ReadAllText(filePath);
		Fahrzeug readFahrzeug = JsonConvert.DeserializeObject<Fahrzeug>(readJson);
	}

	public static void XmlTest(string filePath)
	{
		Fahrzeug f = new Fahrzeug() { MaxGeschwindigkeit = 250, AutoMarke = "VW" };
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(Fahrzeug));
		Stream s = new FileStream(filePath, FileMode.Create);
		xmlSerializer.Serialize(s, f);
		s.Dispose();

		Stream readStream = new FileStream(filePath, FileMode.Open);
		Fahrzeug readFahrzeug = xmlSerializer.Deserialize(readStream) as Fahrzeug;
	}

	public static void CSVTest(string filePath)
	{
		TextFieldParser tfp = new TextFieldParser(filePath);
		tfp.SetDelimiters(";");
		List<string[]> lines = new List<string[]>();
		while (!tfp.EndOfData)
		{
			lines.Add(tfp.ReadFields());
		}
	}
}

public class Fahrzeug
{
	public int MaxGeschwindigkeit;

	public string AutoMarke;
}