using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacePongEngine
{
    public class XWing : SpaceObject
    {

        public XWing()
        {
            X = rng.Next(3, WorldWidth - 2);
            Y = rng.Next(3, WorldHeight - 2);
            VectorX = rng.Next(-2, 3);
            VectorY = rng.Next(-2, 3);
        }

        public XWing(int x, int y, int vx, int vy)
        {
            X = x;
            Y = y;
            VectorX = vx;
            VectorY = vy;
        }

        public int VectorX { get; set; }
        public int VectorY { get; set; }

        public override char ConsoleChar
        {
            get
            {
                return 'X';
            }
        }
        override public void Update()
        {
            if (X + VectorX >= WorldWidth || X + VectorX < 0)
            {
                VectorX = -VectorX;
            }
            X = X + VectorX;

            if (Y + VectorY >= WorldHeight || Y + VectorY < 0)
            {
                VectorY = -VectorY;
            }
            Y = Y + VectorY;
        }


    }
}
