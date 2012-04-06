using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XNA_Game.Sprites;
using XNA_Game.Sprites.Blocks;
using XNA_Game.Sprites.Various;
using Microsoft.Xna.Framework;

namespace XNA_Game.Levels
{
    class Level
    {
        private SpriteBase[,] level;
        public SpriteBase[,] currentLevel;

        public Level(string file)
        {
            level=new SpriteBase[file.Split()[1].Length, file.Split().Length - 2];
            int row=-1;
            int column=0;
            foreach (string s in file.Split())
            {
                foreach (char c in s)
                {
                    if(c == '0')
                    level[column, row] = new SkyBlock();
                    else if (c == '1')
                        level[column, row] = new StaticBlock();
                    //else if (c == 'X')

                    column++;
                }
                column = 0;
                    row++;
            }
            int i = 0;
        }
    }
}
