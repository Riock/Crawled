using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Crawled.Logic.Models
{
    public class Character
    {
        #region Properties

        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }

        public string Name { get; set; }

        #endregion

        public void Initialize(Texture2D texture, Vector2 position)
        {
            this.Texture = texture;
            this.Position = position;
        }

        public void Update()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Texture, this.Position, Color.White);
        }
    }
}
