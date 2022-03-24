using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class UnitTest
	{
		Rechner rechner;

		[TestInitialize] //Wird vor den Tests aufgerufen
		public void ErzeugeRechner()
		{
			rechner = new Rechner();
			System.Console.WriteLine("Rechner erzeugt");
		}

		[TestCleanup] //Wird nach allen Tests aufgerufen
		public void Cleanup()
		{
			rechner = null;
			System.Console.WriteLine("Rechner weggeworfen");
		}

		[TestCategory("Erfolg")] //Kategorie Erfolgstest
		[TestMethod]
		public void TesteAddiere()
		{
			int summe = rechner.Addiere(10, 20);
			Assert.AreEqual(30, summe);
		}

		[TestCategory("Erfolg")] //Kategorie Erfolgstest
		[TestMethod]
		public void TesteSubtrahiere()
		{
			int diff = rechner.Subtrahiere(10, 20);
			Assert.AreEqual(-10, diff);
		}

		[TestCategory("Fehler")] //Kategorie Fehlertest
		[TestMethod]
		public void TesteSubtrahiereFehler()
		{
			int diff = rechner.Subtrahiere(10, 20);
			Assert.AreNotEqual(10, diff);
		}
	}
}