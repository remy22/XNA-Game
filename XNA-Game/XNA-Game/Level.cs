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
        private char[,] level;
        public HashSet<SpriteBase> currentLevel;

        public Level(string file)
        {
            string[] level = file.Split('\n');
            int maxRowLength = 0;

            foreach (string row in level)
                if (row.Length > maxRowLength)
                    maxRowLength = row.Length;

            this.level = new char[maxRowLength, level.Length - 2];

            for (int row = 1; row < level.Length - 1; row++)
                for (int column = 0; column < level[row].Length; column++)
                    this.level[column, row - 1] = level[row][column];

            resetLevel();
        }

        public void resetLevel()
        {
            currentLevel = new HashSet<SpriteBase>();
            for (int column = 0; column < level.GetLength(0); column++)
                for (int row = 0; row < level.GetLength(1); row++)
                    if (level[column, row] == '1')
                        currentLevel.Add(new StaticBlock(column * 100, row * 100, 100, 100));
        }
    }
}
