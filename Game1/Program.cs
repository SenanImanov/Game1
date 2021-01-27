using System;

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player() 
            {Adi = "Senan", SoyAdi = "Imanov", TcNo = "123456", DogumTarixi = "3 aralik 1999"};
            Player player2 = new Player() 
            { Adi = "Ayse", SoyAdi = "goyturk", TcNo = "8910", DogumTarixi = "4 ocak 1598" };
            Console.WriteLine(player1.SoyAdi);
            Console.WriteLine(player2.Adi);

            EgovPlayerInfo egovplayerinfo2 = new EgovPlayerInfo()
            { Adi = "Ayse", SoyAdi = "goyturk", TcNo = "8910", DogumTarixi = "4 ocak 1598", ID = 123};
            EgovPlayerInfo egovPlayerInfo1 = new EgovPlayerInfo
            { Adi = "Senan", SoyAdi = "Imanov", TcNo = "123456", DogumTarixi = "3 aralik 1999"};
            Console.WriteLine(egovplayerinfo2.TcNo);
            Console.WriteLine(egovPlayerInfo1.Adi);

            Oyun oyun1 = new Oyun()
            {OyunAdi = "Blur-2012", OyunPrice = "12 $"};
            Oyun oyun2 = new Oyun() { OyunAdi = "Pes-2013", OyunPrice = "10 $" };
            Console.WriteLine(oyun1.OyunPrice);
            Console.WriteLine(oyun2.OyunAdi);

            IKompaniya kompaniyaManager1 = new KompaniyaManager();
            kompaniyaManager1.Newkompaniya(oyun1);
            kompaniyaManager1.DeleteKompaniya(oyun1);
            kompaniyaManager1.UpdateKompaniya(oyun2);
            Console.WriteLine(  "'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''");

            IPlayManager playManager = new PlayerManager() { };
            playManager.DeletePlayerManager(player1);
            playManager.NewPlayerManager(player2);
            playManager.UpdatePlayerManager(player1);

            SatisManager satismanager = new SatisManager();
            satismanager.satisManager(player2, oyun2);
            satismanager.satisManager(player1, oyun1);

            OyuncuDogrulama oyuncuDogrulama = new OyuncuDogrulama();
            oyuncuDogrulama.oyuncuDogrulama(player1, egovPlayerInfo1);






        }
    }
}
