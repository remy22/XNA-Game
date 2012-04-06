using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XNA_Game.Sprites;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace XNA_Game.Sprites.Blocks
{
    class StaticBlock : SpriteBase
    {
        public StaticBlock(int x, int y, int width, int height)
            : base(x, y, width, height)
        {
            texture = "Block";
        }
    }
}