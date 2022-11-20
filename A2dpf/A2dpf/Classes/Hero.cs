using A2dpf.Interfaces;
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
        public Animation animation;

        public Hero(Texture2D texture)
        {
            this.texture = texture;
            animation = new Animation();
            animation.AddFrame (new AnimationFrame (new Rectangle(0, 0, 48, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(48, 0, 48, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(96, 0, 48, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(144, 0, 48, 48)));
            animation.AddFrame(new AnimationFrame(new Rectangle(192, 0, 48, 48)));

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Vector2(0, 0), animation.CurrentFrame.SourceRectangle, Color.White);

        }
        public void Update(GameTime gametime)
        {
            animation.Update(gametime);
        }
    }
}
