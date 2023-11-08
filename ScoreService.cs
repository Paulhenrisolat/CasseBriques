using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D11;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasseBrique
{
    public interface IServiceScore
    {
        void Add(int pPoints);
        int Get();
    }

    class ScoreService : IServiceScore
    {
        private int Value;
        //SpriteFont fontMenu;
        public ScoreService() 
        {
            Value = 0;
            ServiceLocator.RegisterService<IServiceScore>(this);
        }

        public void Add(int pPoints)
        {
            Value += pPoints;
        }

        public int Get()
        {
            return Value;
        }

        public void Display()//SpriteBatch pBatch)
        {
            Debug.WriteLine(Value);
            //pBatch.DrawString(fontMenu, "Score : " + Get(), new Vector2(10, 30), Color.White);
        }
    }
}
