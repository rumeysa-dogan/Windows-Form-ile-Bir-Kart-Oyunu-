using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartoyunu
{
    public class Oyuncu
    {

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int CanPuani { get; set; }
        public int Savunma { get; set; }

        public Oyuncu(string adi, string soyadi)
        {
            Adi = adi;
            Soyadi = soyadi;
            CanPuani = 100;
            Savunma = 0;

        }
    }
}
