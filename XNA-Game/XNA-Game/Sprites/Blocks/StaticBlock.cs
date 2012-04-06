using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XNA_Game.Sprites;
using XNA_Game.GameElements;
using Microsoft.Xna.Framework.Graphics;

namespace XNA_Game.Sprites.Blocks
{
    class StaticBlock : SpriteBase
    {
        new public static Texture2D image = GameWorld.images["Block"];

    }
}