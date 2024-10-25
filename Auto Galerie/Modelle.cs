using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;

namespace Auto_Galerie;

class Modelle
  {
	public string modellEingaben {  get; set; }
	public void Modellenachfragen()
{

	{ 
			Console.WriteLine("\nBitte wählen Sie Ihren interresierten Modell aus: ");
		    modellEingaben = Console.ReadLine();
			modellEingaben.ToLower();
			Console.ReadKey();
			Console.Clear();


		// opel modellen beschreibung


		if (modellEingaben.ToLower() == "meriva")
		{

			Console.WriteLine("Der Opel Meriva: Vielseitigkeit und Komfort für den Alltag");
			Console.WriteLine("\n Bietet\n\n-Motor:110kw\n-Farbe: Schwarz\n-preis 4000 Euro");
		}
		else if (modellEingaben.ToLower() == "astra")
		{
			Console.WriteLine(" Astra\n\n-Motor:140kw\n-Farbe: Blau\n-Preis 4000 Euro");
		}

		// mercedes modelle beschreibung

		else if (modellEingaben.ToLower() == "amg")
		{
			Console.WriteLine(" AMG\n\n-Motor:190kw\n-Farbe: Grün\n-Preis 40000 Euro");
		}
		else if (modellEingaben.ToLower() == "sklasse")
		{
			Console.WriteLine(" SKlasse\n\n-Motor:160kw\n-Farbe: Silber\n-Preis 35000 Euro");
		}

		// VW modelle beschreibung

		else if (modellEingaben.ToLower() == "polo")
		{
			Console.WriteLine(" Polo\n\n-Motor:90kw\n-Farbe: Rot\n-Preis 15000 Euro");
		}
		else if (modellEingaben.ToLower() == "golf")
		{
			Console.WriteLine(" Golf\n\n-Motor:130kw\n-Farbe: Matt Schwarz\n-Preis 19000 Euro");
		}

		// bmw modelle beschreibung

		else if (modellEingaben.ToLower() == "3er")
		{
			Console.WriteLine(" 3er\n\n-Motor:100kw\n-Farbe: Grau\n-Preis 18000 Euro");
		}
		else if (modellEingaben.ToLower() == "5er")
		{
			Console.WriteLine(" 5er\n\n-Motor:200kw\n-Farbe: \n-Preis 4000 Euro");
		}

		else
		{
			Console.WriteLine("Ungültige Eingabe");
			Console.ReadKey();
			Modellenachfragen();
		}

			
	}
}
}