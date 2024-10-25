using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Galerie;


class Zahlungsart : KaufArt

{
	public string userKauffrage { get; set; }
	public string designFrage { get; set; }
	public int userInteriorwahl { get; set; }

	public string zurückZurStartseite { get; set; }

	// hier befindet das Struktur von Ende des Programmes. 
	public void InteriorZahlungart()
	{
		int luftungPreis = 1000;
		int lederPreis = 1500;
		int userInteriorwahl;

		Console.WriteLine("Möchten Sie das Auto Kaufen? ja/nein");
		userKauffrage = Console.ReadLine();
		userKauffrage.ToLower();

		if (userKauffrage == "ja")
		{
			Console.WriteLine("Möchten Sie Änderungen am Innenraum Ihres Autos vornehmen?ja/nein");
			designFrage = Console.ReadLine();
			designFrage.ToLower();

			if (designFrage == "ja")
			{
				Console.WriteLine("\nHier stehen Ihnen 2 möglichkeiten die wir am Innenraum anbieten.\n\n1.Leder sitzt.\n2.Ständig Frisches Luft durch Belüftungssystem");
				Console.WriteLine("\nGeben Sie Ihre Wahl durch Eingabe der entsprechenden Zahl ein");
				
				if  (int.TryParse(Console.ReadLine(), out userInteriorwahl) && (userInteriorwahl == 1 || userInteriorwahl == 2))
				{
					if (userInteriorwahl == 1)
					{
						Console.WriteLine("Steigern Sie den Luxus des Alltags mit echtenLeder für " + lederPreis + " Euro");
						Console.ReadKey();
						Console.Clear();
						
					}
			    	else if (userInteriorwahl == 2)
			    	{
					Console.WriteLine("Frisches beluftungssystem macht das Leben unterwegs angenehmer für " + luftungPreis + " Euro");
					
					}
				this.userInteriorwahl = userInteriorwahl;
				}

				else { Console.WriteLine("Ungültige eingabe"); this.userInteriorwahl = 0; }

			}
			else if (designFrage == "nein")
			{
				
			}

		}

		else if (userKauffrage == "nein")
		{
			Console.WriteLine("Möchten Sie zur Startseite zurückkehren? ja/nein");
			zurückZurStartseite = Console.ReadLine().ToLower();
			

			if (zurückZurStartseite == "ja")
			{
				this.zurückZurStartseite = zurückZurStartseite;
				// Hier simulieren wir die Rückkehr zur Startseite, indem wir die Main-Methode neu aufrufen
				Console.Clear();
				Program.Main(null);
			}
			else if (zurückZurStartseite=="nein")
			{
				Console.WriteLine("Auf Wiedersehen!");
				Environment.Exit(0);
			this.zurückZurStartseite = zurückZurStartseite;
			}
			else
			{
				Console.WriteLine("Bitte melden Sie den Fehler an der IT abteilung");
				Environment.Exit(0);
			}
	 
		}
		else
		{
			Console.WriteLine("Ungültige Eingabe. Versuchen Sie es erneut.");
		}


	}
}
