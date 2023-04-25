
using System;using System.Collections.Generic;

namespace Evidence_pojisteni
{
	
	public class Databaze
	{
		private List<Pojistenec> pojistenci=new List<Pojistenec>();
		public int VratPocetPojistencu{get{return pojistenci.Count;}}
		
		public void PridejPojistence(string jmeno,string prijmeni,byte vek,int telefon){
		
			pojistenci.Add(new Pojistenec(jmeno,prijmeni,vek,telefon));
		}
		
		public List<Pojistenec> NajdiPojistence(string jmeno,string prijmeni){
		
			List<Pojistenec> nalezen=new List<Pojistenec>();
			foreach(Pojistenec p in pojistenci){
				if((p.Jmeno==jmeno) && (p.Prijmeni==prijmeni)){nalezen.Add(p);}
				}
			return nalezen;
			
			
		}
		
		public List<Pojistenec> VypisPojistencu(){
		
			return pojistenci;
		}
		public void VymazPojistence(string jmeno,string prijmeni){
		
			List<Pojistenec> nalezen=NajdiPojistence(jmeno,prijmeni);
			foreach(Pojistenec p in nalezen){pojistenci.Remove(p);}
				
			
		}
	}
}
