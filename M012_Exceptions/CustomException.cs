namespace M012_Exceptions;

public class CustomException : Exception
{
	public CustomException(string? message) : base(message)
	{
		Console.WriteLine("CustomException wurde geworfen");
	}
}
