
using System;using System.Threading;

namespace Evidence_pojisteni
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Predstaveni projektu:				
			Uvod();
			//
			Sprava sprava=new Sprava();
			
			char volba = 'x';

    while (volba != '5')
    {
       
    	Console.Clear();
    	Console.WriteLine("\n----------------------");Console.BackgroundColor=ConsoleColor.DarkBlue;
    	Console.WriteLine(" Evidence pojištěných ");
    	Console.BackgroundColor=ConsoleColor.Black;
    	Console.WriteLine("----------------------");

    Console.WriteLine("\nVyberte si akci:");
        Console.WriteLine("1 - Přidat nového pojištence");
        Console.WriteLine("2 - Vypsat všechny pojištence");
        Console.WriteLine("3 - Vyhledat pojištěného");
        Console.WriteLine("4 - Vymazat pojištěného");
        Console.WriteLine("5 - Konec\n");
        volba = Console.ReadKey(true).KeyChar;int v=int.Parse(volba.ToString());int xx;int yy;
       
        switch (volba)
        {
            case '1':
        		xx=Console.CursorLeft;yy=Console.CursorTop;
        		Grafika(v,xx,yy);
        		sprava.PridejPojistence();Console.ReadKey(true);
                break;
            case '2':
                xx=Console.CursorLeft;yy=Console.CursorTop;
        		Grafika(v,xx,yy);
                sprava.VypisPojistencu();Console.ReadKey(true);
                break;
            case '3':
                xx=Console.CursorLeft;yy=Console.CursorTop;
        		Grafika(v,xx,yy);
                sprava.NajdiPojistence();Console.ReadKey(true);
                break;
            case '4':
                xx=Console.CursorLeft;yy=Console.CursorTop;
        		Grafika(v,xx,yy);
                sprava.VymazPojistence();Console.ReadKey(true);
                break;
            case '5':
                //Console.WriteLine("\nBylo zvoleno ukončení programu. Libovolnou klávesou ukončíte program.");
                Konec();
                break;
            default:
                Console.WriteLine("Neplatná volba. Stiskněte libovolnou klávesu a volbu dle nabídky opakujte.");
                break;
        }
    }
    
       
    
		
		}
		
		static void Grafika(int v,int xx,int yy){
		
			string[] nazvy= {" PŘIDÁVÁNÍ NOVÉHO POJIŠTĚNCE "," VÝPIS VŠECH POJIŠTENCŮ "," HLEDÁNÍ POJIŠTENCE "," ODSTRANĚNÍ POJIŠTENCE "};
        		Console.SetCursorPosition(50,8);Console.BackgroundColor=ConsoleColor.DarkGreen;
        		Console.WriteLine(nazvy[v-1]);Console.BackgroundColor=ConsoleColor.Black;
        		Console.SetCursorPosition(xx,yy);
		}
		static void Uvod(){
		
			Console.SetWindowSize(120,33);Console.CursorVisible=false;
		Console.Title="Evidence pojištění";Random nahoda=new Random();int nah;
			Console.SetCursorPosition(22,7);string nazev="APLIKACE NA EVIDENCI POJIŠTĚNÍ";
			
				string nazev2="konzolový program vytvořený v C#";
			foreach(char c in nazev){Console.Write(c+" ");Thread.Sleep(150);};Thread.Sleep(190);Console.ForegroundColor=ConsoleColor.Green;
						Console.SetCursorPosition(35,11);foreach(char c in nazev2){Console.Write(c+"");Thread.Sleep(90);};
						Console.ForegroundColor=ConsoleColor.DarkGray;Console.SetCursorPosition(10,25);Thread.Sleep(2000);
						Console.WriteLine("Program vytvořil: Marek Loníček");Console.SetCursorPosition(10,26);Thread.Sleep(2000);
						Console.WriteLine("e-mail: mark.lonicek@seznam.cz");Console.SetCursorPosition(10,27);Thread.Sleep(2000);
						Console.WriteLine("Vytvořeno dne: 27.6.2022");
						
						Thread.Sleep(4000);Console.Clear();Console.ForegroundColor=ConsoleColor.White;int z=2000;
						Console.BackgroundColor=ConsoleColor.DarkGray;Console.Clear();Thread.Sleep(z);Console.ForegroundColor=ConsoleColor.Gray;
			Console.SetCursorPosition(30,4);Console.WriteLine("Vytvořeno pro: ITnetwork.cz");Thread.Sleep(z);
			Console.SetCursorPosition(30,8);Console.WriteLine("Zjednodušená verze projektu ke zkoušce");Thread.Sleep(z);
			Console.SetCursorPosition(30,12);Console.WriteLine("Verze programu: \"Basic&Graphics\"");Thread.Sleep(z);
			
			
			Thread.Sleep(2*z);
			Console.BackgroundColor=ConsoleColor.Black;Console.Clear();
			Console.SetCursorPosition(25,22);Console.WriteLine("Extrahují se soubory, počkejte prosím...");Console.ForegroundColor=ConsoleColor.Blue;
			Thread.Sleep(2000);
			int i;for(i=5;i<=105;i++) {Console.SetCursorPosition(i,26);nah=nahoda.Next(1,350);Console.WriteLine("█");Thread.Sleep(nah);
				if(i%19==0){Thread.Sleep(nahoda.Next(600,2000));}
				if(i%34==0){Thread.Sleep(nahoda.Next(2000,3000));}
				if(i>=0){Console.SetCursorPosition(20,28);Console.ForegroundColor=ConsoleColor.White;Console.WriteLine(i-5+" % ");Console.ForegroundColor=ConsoleColor.Blue;}
			}Console.SetCursorPosition(26,28);Console.ForegroundColor=ConsoleColor.White;Console.WriteLine("HOTOVO");
			Thread.Sleep(300);
			
				
			
			Thread.Sleep(900);Console.Clear();Console.ForegroundColor=ConsoleColor.White;
			Console.SetCursorPosition(25,26);Console.WriteLine("Data načtena.");Thread.Sleep(2000);Console.Clear();
		}
		static void Konec(){
		Console.WriteLine("\n\nDěkujeme za použití aplikace.\nMůžete také vyzkoušet další verzi aplikace,\nkterá je cílená na ukládání dat do souborů CSV nebo XML.\nPřipravujeme také pokročilou verzi s ukládáním dat do databáze MS SQL.\n\nProgram bude za 60 sek UKONČEN.\n");
				                                                           Thread.Sleep(1000);
				                                                           for(int ii=0;ii<60;ii+=5){Console.ForegroundColor=ConsoleColor.DarkRed;Console.Write(" █"+ii+"s");Thread.Sleep(5000);}
				                                                           return;}
		
		
    }
	
}