
using System;using System.Collections.Generic;

namespace Evidence_pojisteni
{
	
	public class Pojistenec
	{
		public string Jmeno{get;private set;}
		public string Prijmeni{get;private set;}
		public byte Vek{get;private set;}
		public int Telefon{get;private set;}
		
		public Pojistenec(string jmeno,string prijmeni,byte vek,int telefon){
		
		Jmeno=jmeno;
		Prijmeni=prijmeni;
		Vek=vek;
		Telefon=telefon;
		
		}
		
		public override string ToString(){
		
			return String.Format(Jmeno+" "+Prijmeni+" "+Vek+" "+Telefon);
		}
	}
}
