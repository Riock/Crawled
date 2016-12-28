using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Crawled.Logic.Models
{
    public class Map
    {
        public Texture2D GroundTexture { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Map(Texture2D texture, int width, int height)
        {
            this.GroundTexture = texture;
            this.Width = width * texture.Width;
            this.Height = height * texture.Height;

        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int x = 0; x < Width / GroundTexture.Width; x++)
            {
                for (int y = 0; y < Height / GroundTexture.Height; y++)
                {
                    spriteBatch.Draw(GroundTexture, new Vector2(x * GroundTexture.Height, y * GroundTexture.Height), Color.White);
                }
            }
        }
    }
}
