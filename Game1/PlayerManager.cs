using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    class PlayerManager : IPlayManager
    {
        public void DeletePlayerManager(Player player)
        {
            Console.WriteLine( player.Adi + "  bu kayd silindi. ");
        }

        public void NewPlayerManager(Player player)
        {
            Console.WriteLine(player.Adi + "  bu kayd ugurla qeyd edildi.");
        }

        public void UpdatePlayerManager(Player player)
        {
            Console.WriteLine(player.Adi + " bu kayd guncellendi. ");
        }
    }
}
