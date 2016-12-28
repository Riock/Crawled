using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Crawled.Logic.Models
{
    public class Camera2D
    {
        private Matrix Transform;
        public Vector2 Pos { get; set; }

        public Camera2D()
        {
            Pos = Vector2.Zero;
        }

        public void Move(Vector2 amount)
        {
            Pos += amount;
        }

        public Matrix GetTransformation(GraphicsDevice graphicsDevice)
        {
            Transform = Matrix.CreateTranslation(new Vector3(Pos.X, Pos.Y, 0)) * Matrix.CreateTranslation(
                new Vector3(graphicsDevice.Viewport.Width * 0.5f, graphicsDevice.Viewport.Height * 0.5f, 0));

            return Transform;
        }
    }
}
