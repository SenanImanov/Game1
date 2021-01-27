using System;
using System.Collections.Generic;
using System.Text;

namespace Game1
{
    interface IPlayManager
    {
        void NewPlayerManager(Player player);
        void DeletePlayerManager(Player player);
        void UpdatePlayerManager(Player player);
    }
}
