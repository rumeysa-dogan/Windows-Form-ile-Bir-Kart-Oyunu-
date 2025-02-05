using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartoyunu
{
    public class Savunma :IKart
    {
        public string KartAdi { get; } = "Savunma Kartı";
        public int Enerji { get; set; } = 8;

        public void Aksiyon(Oyuncu kullanici, Oyuncu rakip)
        {
            if (Enerji > 0)
            {
                kullanici.Savunma += 5;
                Enerji -= 1;
                MessageBox.Show(KartAdi+" seçildi. Kullanıcının savunması 5 arttı.");
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