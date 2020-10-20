using Fizzle_EscapeGame.Core;
using Fizzle_EscapeGame.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzle_EscapeGame.Managers
{
    internal class GameStateManager : Component
    {
        MenuScene ms = new MenuScene();
        internal override void Init(ContentManager Content)
        {
            ms.Init(Content);
        }

        internal override void Update(GameTime gameTime)
        {
            switch (Data.currentState)
            {
                case Data.GameStates.Menu:
                    ms.Update(gameTime);
                    break;
                case Data.GameStates.Game:
                    break;
                case Data.GameStates.Settings:
                    break;
            }
        }
        
        internal override void Draw(SpriteBatch spriteBatch)
        {
            switch (Data.currentState)
            {
                case Data.GameStates.Menu:
                    ms.Draw(spriteBatch);
                    break;
                case Data.GameStates.Game:
                    break;
                case Data.GameStates.Settings:
                    break;
            }
        }
    }
}
