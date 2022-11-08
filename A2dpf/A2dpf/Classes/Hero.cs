using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct2D1;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SpriteBatch = Microsoft.Xna.Framework.Graphics.SpriteBatch;

namespace A2dpf.Classes
{
    internal class Hero : IGameObject
    {
        private Texture2D texture;
        private Rectangle deelRectangle;
        private int schuifOp_X = 0;

        public Hero(Texture2D texture)
        {
            this.texture = texture;
            deelRectangle = new Rectangle(schuifOp_X, 0, 48, 48);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Vector2(0, 0), deelRectangle, Color.White);
        }
        public void Update()
        {
            schuifOp_X += 48;
            if (schuifOp_X > 240)
            {
                schuifOp_X = 0;
            }
            deelRectangle.X = schuifOp_X;
        }
    }
}
