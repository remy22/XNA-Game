using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XNA_Game.Sprites
{
    abstract class SpriteBase
    {
        public string texture;
        public Rectangle location;

        public SpriteBase(int x, int y, int width, int height)
        {
            location = new Rectangle(x, y, width, height);
        }
    }
}
