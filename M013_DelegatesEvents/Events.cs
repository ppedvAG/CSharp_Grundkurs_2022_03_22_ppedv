namespace M013_DelegatesEvents
{
	internal class Events
	{
		static event EventHandler<EventArgs> Event;

		static void Main(string[] args)
		{
			Event += Event1; //Kein new
			Event(null, new EventArgs()); //Generische EventArgs, spezielle Args: MouseEventArgs, KeyEventArgs, ...
			Event = Event2;
			Event(null, new EventArgs());
		}

		private static void Event1(object? sender, EventArgs e) => Console.WriteLine("Event 1 wurde aufgerufen");

		private static void Event2(object? sender, EventArgs e) => Console.WriteLine("Event 2 wurde aufgerufen");
	}
}
