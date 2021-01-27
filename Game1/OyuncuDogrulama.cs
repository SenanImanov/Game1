using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class OyuncuDogrulama
    {
        public void oyuncuDogrulama(Player player1, EgovPlayerInfo egovPlayerInfo1)
        {
            if (player1.Adi  == egovPlayerInfo1.Adi)
            {
                Console.WriteLine("dogru giris");
            }
            else
            {
                Console.WriteLine("giris yanlis");
            }
        }
    }
}
