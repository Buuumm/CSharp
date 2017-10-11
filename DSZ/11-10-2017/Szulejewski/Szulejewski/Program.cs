using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szulejewski
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Podaj cyfre");
            int a = Convert.ToInt32(Console.ReadLine());

            if ((a >= 1) && (a<= 31))
            {
                Console.WriteLine("Podana cyfra moze być dniem miesiaca");
            }
            else
                Console.WriteLine("Podana cyfra nie moze być dniem miesiaca");


            Console.ReadKey();
        }

    }
    
}
