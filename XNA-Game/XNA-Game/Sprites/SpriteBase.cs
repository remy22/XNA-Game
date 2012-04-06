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
        public Texture2D image;
        public Vector2 position;
        public Vector2 relativeSize;
    }
}
