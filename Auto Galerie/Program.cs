using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace Auto_Galerie;

public class Program
{
	public static void Main(string[] args)
	{

		
			
	    Begrüßung websiteBegrüßung = new Begrüßung();

		Benutzerdaten benutzer = new Benutzerdaten();
			


			// hier wird die Klasse mit einem objekt errstellt und danach Mefthod aufgerufen.
		MarkenSwitsch markenSwitsch = new MarkenSwitsch();
		markenSwitsch.MarkenSwitchMethod();
		// variable marke(der in die Klasse  Benutzerdaten ist) hat den wert von dem Klasse Markenswitsch den variable markeneingabe.
		benutzer.marke = markenSwitsch.markeneingabe;
		Console.ReadKey();
		Console.Clear();
			
					
		// hier werden die Modellen information gespeichert
	    Modelle Markenobj = new Modelle();
		Markenobj.Modellenachfragen();
		// die zuweisung von variable modelleingaben (klasse Modelle) zu variable modell (klasse Benutzerdaten):
	    benutzer.modell = Markenobj.modellEingaben;
		Console.ReadKey();
		Console.Clear();
			
		   
		// hier zahlungart und weise
		Zahlungsart zahlungobj = new Zahlungsart();
		zahlungobj.InteriorZahlungart();
		// die drei variablen mit einem Obj erstellt und wert zugewisen.
	    benutzer.Kaufstatus = zahlungobj.userKauffrage;
	    benutzer.Designanpassung = zahlungobj.designFrage;
	    benutzer.Interioraenderung = zahlungobj.userInteriorwahl;

		// hier befindet sich das Fehler bei der Json speicherung.
		benutzer.Startseitegelandet = zahlungobj.zurückZurStartseite;



	    // für Json speicherung die Klasse und Method hier aufgerufen.
	    KaufArt kaufArtObj = new KaufArt();
		kaufArtObj.KaufMethod();
	    benutzer.zahlWeise = kaufArtObj.userZahlungeingabe;

		Console.ReadKey();

		// json spreicher struktur
		string json = JsonSerializer.Serialize(benutzer, new JsonSerializerOptions { WriteIndented = true });
		JsonSerializer.Deserialize<Benutzerdaten>(json);
		string dateipfad = "Benutzerdaten.json";
		File.WriteAllText(dateipfad,json);



	}

}


  


