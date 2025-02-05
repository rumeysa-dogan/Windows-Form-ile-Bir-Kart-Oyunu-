using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartoyunu
{
    public class Sifa :IKart
    {
        public string KartAdi { get; } = "Şifa Kartı";
        public int Enerji { get; set; } = 6;

        public void Aksiyon(Oyuncu kullanici, Oyuncu rakip)
        {
            if (Enerji > 0)
            {
                kullanici.CanPuani += 15;
                Enerji -= 3;
                MessageBox.Show(KartAdi+" seçildi. Kullanıcının canı 15 arttı.");
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