using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Crawled.Logic.Models
{
    public class Character
    {
        #region Properties

        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }

        public string Name { get; set; }
        public int MoveSpeed { get; set; }

        #endregion

        public Character(Texture2D texture, Vector2 position)
        {
            this.Texture = texture;
            this.Position = position;

            this.MoveSpeed = 5;
        }

        public void Update()
        {
            
        }

        public void ManualMove(KeyboardState keyboardState)
        {
            if (keyboardState.IsKeyDown(Keys.Up))
            {
                Position = new Vector2(Position.X, Position.Y - MoveSpeed);
            }
            else if (keyboardState.IsKeyDown(Keys.Down))
            {
                Position = new Vector2(Position.X, Position.Y + MoveSpeed);
            }
            if (keyboardState.IsKeyDown(Keys.Left))
            {
                Position = new Vector2(Position.X - MoveSpeed, Position.Y);
            }
            else if (keyboardState.IsKeyDown(Keys.Right))
            {
                Position = new Vector2(Position.X + MoveSpeed, Position.Y);
            }
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Texture, this.Position, Color.White);
        }
    }
}
