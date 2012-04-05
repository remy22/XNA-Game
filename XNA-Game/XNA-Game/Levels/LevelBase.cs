using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XNA_Game.Sprites;

namespace XNA_Game.Levels
{
    abstract class LevelBase
    {
        private static SpriteBase[][] level;
        public SpriteBase[][] currentLevel;

        public static void LoadLevel(string file)
        {
            //
        }
    }
}
