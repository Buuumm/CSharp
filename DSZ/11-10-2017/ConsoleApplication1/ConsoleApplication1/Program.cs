using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Osoba dyrektor = new Osoba();
            dyrektor.imie = "Jan";
            dyrektor.nazwisko = "Nowak";
            dyrektor.rokUrodzenia = 1980;

            Console.WriteLine(dyrektor.imie);
            Console.WriteLine(dyrektor.nazwisko);
            Console.WriteLine(dyrektor.ObliczWiek());


            Console.ReadKey();

        }
    }

}
