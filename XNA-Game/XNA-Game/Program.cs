using System;

namespace XNA_Game.GameElements
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (GameWorld game = new GameWorld())
            {
                game.Run();
            }
        }
    }
#endif
}

