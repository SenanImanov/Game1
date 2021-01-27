using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class KompaniyaManager : IKompaniya
    {
        public void DeleteKompaniya(Oyun oyun)
        {
            Console.WriteLine(oyun.OyunAdi + "  Kompaniya bitmisdir");
        }

        public void Newkompaniya(Oyun oyun)
        {
            Console.WriteLine(oyun.OyunAdi + " Oyunda 40% endirim vardir");
            Console.WriteLine("Oyunun qiymeti: " + oyun.OyunPrice);
        }

        public void UpdateKompaniya(Oyun oyun)
        {
            Console.WriteLine(oyun.OyunAdi + " oyunu guncellendi");
        }
    }
}
