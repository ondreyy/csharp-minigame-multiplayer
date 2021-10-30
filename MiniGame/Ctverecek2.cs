using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniGame
{
    class Ctverecek2 : Ctverecek
    {
        public Ctverecek2(int velikost, int rychlost, Vector2 pozice, SmeroveOvladani ovladaniPohybu, Rectangle omezeniPohybu, Color barva, GraphicsDevice zobrazovac) : base(velikost, rychlost, pozice, ovladaniPohybu, omezeniPohybu, barva, zobrazovac)
        {
        }
    }
}
