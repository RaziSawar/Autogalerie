using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class KaufArt
{
	public string userZahlungeingabe {  get; set; }

	// hier ist nur die detallierte info wegen Karte und BAR zahlung:
	public void KaufMethod()
	{
		Console.WriteLine("Mochten Sie den Betrag Bar oder mit der Karte zahlen?");
		userZahlungeingabe = Console.ReadLine();
		userZahlungeingabe.ToLower();
		if (userZahlungeingabe == "bar")
		{
			Console.WriteLine("Bitte zahlen Sie an der Kasse bei der Frau MusterFrau");
			Console.WriteLine("\n Danke für den einkauf und Gute Reise");

		}
		else if (userZahlungeingabe == "karte")
		{
			Console.WriteLine("Bitte geben Sie den Pin ein: ");
			int pin = int.Parse(Console.ReadLine());
			Console.WriteLine("\n Danke und eine angenehmer Fahrt");
		}
		this.userZahlungeingabe = userZahlungeingabe;
	}
}				