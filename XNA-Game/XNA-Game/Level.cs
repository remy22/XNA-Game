using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XNA_Game.Sprites;
using XNA_Game.Sprites.Blocks;
using Microsoft.Xna.Framework;

namespace XNA_Game.Levels
{
    class Level
    {
        private SpriteBase[][] level;
        public SpriteBase[][] currentLevel;

        public Level(string file)
        {
            int row=-1;
            int column=0;
            foreach (string s in file.Split())
            {
                foreach (char c in s)
                {
                    if(c == '0')
                    level[row][column] = new ;
                    else if (c == '1')
                        level[row][column] =new StaticBlock();
                    else if (c == 'X')

                    column++;
                }
                    row++;
            }
            int i = 0;
        }
    }
}
