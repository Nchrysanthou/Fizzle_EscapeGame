using Fizzle_EscapeGame.Core;
using Fizzle_EscapeGame.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Fizzle_EscapeGame.Scenes
{
    class GameScene : Component
    {
        private InputManager input = new InputManager();
        private List<Room> rooms = new List<Room>();

        internal override void Init(ContentManager Content)
        {

            rooms.Add(new Room("Door"));
            rooms.Add(new Room("Window"));
            rooms.Add(new Room("Wall"));
            rooms.Add(new Room("Test"));
            rooms.Add(new Room("Dildo"));

        }

        internal override void Update(GameTime gameTime)
        {

            input.UpdateMouse();
            input.UpdateKeyboard();
            ChangeRoom();
            int currentRoom = MathHelper.Clamp(Data.RoomNumber, 0, rooms.Count);

            Console.WriteLine(currentRoom);
        }
        internal void ChangeRoom()
        {
            if (input.kb.IsKeyDown(Keys.A) && input.oldKb.IsKeyUp(Keys.A))
                Data.RoomNumber--;
            else if (input.kb.IsKeyDown(Keys.D) && input.oldKb.IsKeyUp(Keys.D))
                Data.RoomNumber++;

            if (Data.RoomNumber > rooms.Count)
                Data.RoomNumber = 0;
            else if (Data.RoomNumber < 0)
                Data.RoomNumber = rooms.Count;
        }

        internal override void Draw(SpriteBatch spriteBatch)
        {

        }

    }
}
