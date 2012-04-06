using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace XNA_Game.Sprites.Blocks
{
    class PuzzleBlock : SpriteBase
    {
        public PuzzleBlock(int x, int y, int width, int height)
            : base(x, y, width, height)
        {
            texture = "Block";
            color = Color.White;
        }
    }
}
