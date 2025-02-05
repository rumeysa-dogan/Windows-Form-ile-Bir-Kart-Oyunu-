using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartoyunu
{
    public class Saldırı : IKart
    {
        public string KartAdi { get; } = "Saldırı Kartı";
        public int Enerji { get; set; } = 10;

        public void Aksiyon(Oyuncu kullanici, Oyuncu rakip)
        {
            if (Enerji > 0)
            {
                rakip.CanPuani -= 10;

                
                kullanici.CanPuani += 5;

                
                if (rakip.CanPuani < 0) rakip.CanPuani = 0;
                if (kullanici.CanPuani > 100) kullanici.CanPuani = 100;

                
                Enerji -= 2;

                MessageBox.Show(KartAdi +"seçildi. Rakibin canı 10 azaldı.");
            }
            else
            {
                MessageBox.Show(KartAdi+" için yeterli enerji yok!");
            }
        }
    }
}
//IKart interface'ini kullanan Saldırı, Savunma, ve Sifa sınıfları, aynı arayüzü paylaştığı için,
//her biri aynı Aksiyon() metodunu kendi farklı şekilde uygulayabilir. Bu, polimorfizmin bir örneğidir.