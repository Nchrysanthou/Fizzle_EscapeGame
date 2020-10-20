using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzle_EscapeGame.Managers
{
    internal class InputManager
    {
        public MouseState ms, oldMs;
        public Rectangle msRect;

        internal void UpdateMouse(GameTime gameTime)
        {
            oldMs = ms;
            ms = Mouse.GetState();
            msRect = new Rectangle(ms.X, ms.Y, 1, 1);
        }


    }
}
