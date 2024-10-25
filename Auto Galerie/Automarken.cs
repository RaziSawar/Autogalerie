using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Galerie;

class Automarken:Modelle
{
	

	public string marken;
	public string modell1;
	public string modell2;



	public Automarken(string markenName, string modellName1, string modellName2)
	{
		marken = markenName;
		modell1 = modellName1;
		modell2 = modellName2; 
	}




}
	
	

