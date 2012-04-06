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
        protected string texture;
        protected Rectangle location;
        protected Color color;

        public string Texture { get { return texture; } private set { } }
        public Rectangle Location { get { return location; } private set { } }
        public Color Color { get { return color; } private set { } }

        public SpriteBase(int x, int y, int width, int height)
        {
            location = new Rectangle(x, y, width, height);
        }
    }
}
