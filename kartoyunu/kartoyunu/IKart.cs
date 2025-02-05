using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartoyunu
{
    public interface IKart
    {
        string KartAdi { get; }
        int Enerji { get; set; }
        void Aksiyon(Oyuncu kullanici, Oyuncu rakip);
    }
   
}
//IKart interface'i, kart sınıflarının (Saldırı, Savunma, Sifa) hepsinin Aksiyon() metodunu içerdiğinden,
//bu kartlar farklı türdeki eylemleri gerçekleştirebilirler.


