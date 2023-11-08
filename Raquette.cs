using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasseBrique
{
    public class Raquette : Sprite
    {
        //Ball myBall;
        public Raquette(Texture2D pTexture, Rectangle pRectangle) : base(pTexture, pRectangle) 
        {
            Debug.WriteLine("Raquette is ready!");
        }
        public override void Update()
        {
            if (Mouse.GetState().Y < Screen.Height && Mouse.GetState().Y > 0)
            {
                SetPosition(Mouse.GetState().X - Width / 2, Position.Y);
            }
            if (Mouse.GetState().X > Screen.Width)
            {
                SetPosition(Screen.Width - Width, Position.Y);
            }
            if (Mouse.GetState().X < 0)
            {
                SetPosition(0, Position.Y);
            }
            base.Update();
        }
    }
}
