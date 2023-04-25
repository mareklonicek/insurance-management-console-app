
using System;using System.Collections.Generic;

namespace Evidence_pojisteni
{
	
	public class Sprava
	{
		private Databaze databaze=new Databaze();
		
		private string ZjistiJmeno(){
		
			Console.Write("Zadejte jméno pojištěnce: ");string jmeno;
			while(String.IsNullOrWhiteSpace(jmeno=Console.ReadLine())){
			      	Console.Write("Chybně zadané jméno, zadejte prosím jméno znovu: ");
			      }
			 return jmeno;
		}
		private string ZjistiPrijmeni(){
		
			Console.Write("Zadejte příjmení pojištěnce: ");string prijmeni;
			while(String.IsNullOrWhiteSpace(prijmeni=Console.ReadLine())){
			      	Console.Write("Chybně zadané příjmení, zadejte prosím příjmení znovu: ");
			      }  
			return prijmeni;
			
		
		}
		public void PridejPojistence(){
			
		string jmeno=ZjistiJmeno();
		string prijmeni=ZjistiPrijmeni();
			     
			      Console.Write("Zadejte věk pojištěnce: ");byte vek;
			      while(!byte.TryParse(Console.ReadLine(),out vek)) {
			      	Console.Write("Chybně zadaný věk, zadejte prosím věk znovu: ");
			      }
			      if(vek<18 || vek>59){Console.WriteLine("Pro tuto věkovou skupinu je žádost odepřena.");
			      	Console.WriteLine("\nPokračujte libovolnou klávesou...");
			      	return;}
			      
			      
			Console.Write("Zadejte telefonní číslo pojištěnce: ");int telefon;
			while(!int.TryParse(Console.ReadLine(),out telefon)) {
			      	Console.Write("Chybně zadané tel. číslo, zadejte prosím tel. číslo znovu: ");
			      }
			if(telefon.ToString().Length !=9){Console.WriteLine("Tel. číslo musí mít 9 číslic. Opakujte prosím zadávání znovu.");
				Console.WriteLine("\nPokračujte libovolnou klávesou...");
				return;}
			//Console.WriteLine("\nPokračujte libovolnou klávesou...");
			
			
			
			databaze.PridejPojistence(jmeno,prijmeni,vek,telefon);
			Console.WriteLine("\nPojištenec byl přidán. Pokračujte libovolnou klávesou...");
			
			}
			
			
		
		
		public void NajdiPojistence(){
		
			string jmeno=ZjistiJmeno();string prijmeni=ZjistiPrijmeni();
			List<Pojistenec> nalezen=databaze.NajdiPojistence(jmeno,prijmeni);
			if(nalezen.Count>0){
				Console.WriteLine("\nNalezen pojištenec:");
				foreach(Pojistenec p in nalezen){
					Console.WriteLine(p);Console.WriteLine("\nPokračujte libovolnou klávesou...");}
			}
			 else 
			 	Console.WriteLine("\nPojištěnec nenalezen. Pokračujte libovolnou klávesou...");
		}
		public void VypisPojistencu(){
		
			if(databaze.VypisPojistencu().Count>0){
				Console.WriteLine("\nNalezeni pojišteneci:");
				foreach(Pojistenec p in databaze.VypisPojistencu()){Console.WriteLine(p);}	
				Console.WriteLine("\nPokračujte libovolnou klávesou...");
			}
			else
				Console.WriteLine("\nŽádní pojištenci nenalezeni. Pokračujte libovolnou klávesou...");
		}
		public void VymazPojistence(){
			
			string jmeno=ZjistiJmeno();
		string prijmeni=ZjistiPrijmeni();
		int pocet=databaze.VratPocetPojistencu;
		databaze.VymazPojistence(jmeno,prijmeni);
		if(databaze.VratPocetPojistencu<pocet){
			Console.WriteLine("\nPojištenec odstraněn.");Console.WriteLine("\nPokračujte libovolnou klávesou...");}
		else{
			Console.WriteLine("\nPojištence se nepodařilo najít.");Console.WriteLine("\nPokračujte libovolnou klávesou...");}

		}
		
}
}
