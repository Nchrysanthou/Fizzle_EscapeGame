using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzle_EscapeGame.Core
{
    public static class Data
    {
        public static bool? Exit { get; set; } = null;

        public static int ScreenW { get; set; } = 1600;
        public static int ScreenH { get; set; } = 900;
    
        public enum GameStates {Menu = 0, Game = 1, Settings = 2 }
        public static GameStates currentState { get; set; } = GameStates.Menu;
    
    
    }
}
