using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiatZwierzat
{

    class Pies
    {
        public int waga = 12;
        public int wzrost = 12;
        public string imie = "nike";


    }

    class Program
    {
        static void Main(string[] args)
        {
            Pies jork = new Pies();
            Console.WriteLine("mój pies nazywa sie " + jork.imie);
            jork.imie = "stefan ty draniu oddaj buta";
            Console.WriteLine("pani krzyczala i powiedziala do psa " + jork.imie);
            Console.WriteLine("pies ma otylosc i wazy " + jork.waga);
            jork.waga = 11212;
            Console.WriteLine("pies zjadl osiem paczek karmy i wazy " + jork.waga);
            Console.WriteLine("mój pies jest ogromny na " + jork.wzrost + " metrów wysokosci");
            jork.wzrost = 345;
            Console.WriteLine("mój pies jest ogromny na " + jork.wzrost + " metrów wysokosci");
            Console.WriteLine("kluczem tej zagadki jest pies napisz a bedzie fajnie");
            jork.imie = Console.ReadLine();
            Console.WriteLine("zartuje niemusales nazywac go pies fajnie brzmi co nie " + jork.imie);
            Console.WriteLine("kluczem tej zagadki jest 100 napisz a bedzie fajnie");
            jork.waga = int.Parse(Console.ReadLine());
            Console.WriteLine("zartuje niemusales dawac mu 100 kilogramów fajnie brzmi co nie " + jork.imie);
            Console.WriteLine("kluczem tej zagadki jest danie mu 100 wzrostu, napisz a bedzie fajnie");
            jork.wzrost = int.Parse(Console.ReadLine());
            Console.WriteLine("zartuje niemusales dawac mu 100 wzrostu fajnie brzmi co nie " + jork.wzrost);



            Console.ReadLine();
;
        }
    }
}
