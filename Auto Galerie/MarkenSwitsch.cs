using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Auto_Galerie;

public class MarkenSwitsch

	{
	   public string markeneingabe  {  get; set; }
	     // AutoMarken in einem Method im  Array gespeichert.
	   public void MarkenSwitchMethod()
	  
	   {
		string[] automarken = { "Opel", "Mercedes", "Volkswagen", "BMW" };
		Console.WriteLine("\nVerfügbare Automarken");
		Array.Sort(automarken);

		foreach (string marke in automarken)
		{

			Console.WriteLine("\n-" + marke);
		}

        //AutoMarken auswahl angebten mit der switch Funktion.

		Console.WriteLine("\nSchreiben Sie bitte die Auto marke ein:");
		markeneingabe = Console.ReadLine();
		Console.ReadKey();
		
		
		// Konstructor von der Klasse Automarken in switsch rein genommen
		switch (markeneingabe.ToLower())
		{
			case "opel":
				Automarken Opel = new Automarken("Opel", "Meriva", "Astra");
				Console.WriteLine(Opel.marken + " bietet\n\n- " + Opel.modell1 + "\n- " + Opel.modell2);

				break;

			case "mercedes":
				Automarken Mercedes = new Automarken("Mercedes", "AMG", "SKlasse");
				Console.WriteLine(Mercedes.marken + " bietet\n \n-" + Mercedes.modell1 + "\n-" + Mercedes.modell2);
				break;

			case "volkswagen":
				Automarken VW = new Automarken("Volkswagen", "Polo", "Golf");
				Console.WriteLine(VW.marken + " bietet\n \n-" + VW.modell1 + "\n-" + VW.modell2);
				break;

			case "bmw":
				Automarken BMW = new Automarken("BMW", "3er", "5er");
				Console.WriteLine(BMW.marken + " bietet\n\n-" + BMW.modell1 + "\n-" + BMW.modell2);
				break;

			default:
				Console.WriteLine("Unbekannte Eingabe.\n\n");
				Console.ReadKey();
				Console.Clear();

				MarkenSwitchMethod();
				return;
		}

	    
	}

	
    }



