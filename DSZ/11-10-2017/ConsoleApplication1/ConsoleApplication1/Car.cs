using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Car
    {
        public string marka;
        internal int rokProd;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        public double srednieSpalanie;
        public double cenapaliwa;

        public double ObliczSpalanie(double dlugosctrasy)
        {
            return srednieSpalanie * dlugosctrasy;


        }

        public double ObliczKosztPrzejazdu(double dlugosctrasy)
        {
            return ObliczSpalanie(dlugosctrasy) * cenapaliwa;
        }
    }
}
