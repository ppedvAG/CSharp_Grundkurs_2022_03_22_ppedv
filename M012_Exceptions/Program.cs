namespace M012_Exceptions;

public class Program
{
	static void Main(string[] args)
	{
		//ExceptionBasics();
		try
		{
			throw new CustomException("Eine Nachricht"); //throw: Exception werfen
		}
		catch (CustomException ce)
		{
			Console.WriteLine(ce.Message);
			Console.WriteLine(ce.StackTrace);
		}
	}

	public static void ExceptionBasics()
	{
		while (true)
		{
			try //Try-Catch Block
			{
				//Hier Fehleranfälliger Code
				int input = int.Parse(Console.ReadLine());
				Console.WriteLine("Zahl: " + input);
				break;
			}
			catch (FormatException fe) //Handeln einzelner Exceptions
			{
				Console.WriteLine("Zahl eingeben");
				Console.WriteLine(fe.Message); //Message: Input string was not in a correct format
				Console.WriteLine(fe.StackTrace); //Stack Trace: Zeigt wo der Fehler im Code aufgetreten ist
				continue;
			}
			catch (OverflowException oe)
			{
				Console.WriteLine("Zahl ist zu groß");
				continue;
			}
			catch (Exception e) //Handeln aller anderer Exceptions
			{
				Console.WriteLine("Anderer Fehler");
				continue;
			}
			finally //Wird IMMER am Ende eines Exception Handlings ausgeführt
			{
				Console.WriteLine("Eine Exception ist aufgetreten");
			}
		}
	}
}