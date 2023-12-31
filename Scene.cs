﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.Direct2D1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using SpriteBatch = Microsoft.Xna.Framework.Graphics.SpriteBatch;

namespace CasseBrique
{
    public class Scene
    {
        private Texture2D textBackground;
        protected Game game;
        public Rectangle ScreenSize {  get; private set; }
        protected int CamShake;
        private Random rnd;

        public Scene(Game pGame)
        {
            game = pGame;
            ScreenSize = game.Window.ClientBounds;
            textBackground = game.Content.Load<Texture2D>("background1");
            rnd = new Random();
        }

        public virtual void Update()
        {

        }
        public virtual void Draw(SpriteBatch pBatch)
        {
            if (CamShake > 0)
            {
                int decal = rnd.Next(-4, 5);
                pBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, Matrix.CreateTranslation(decal, decal, 0));
                CamShake--;
            }
            else
            {
                pBatch.Begin();
            }

            pBatch.Draw(textBackground, new Vector2(0, 0), Color.White);
            pBatch.End();
            
        }
    }
}
