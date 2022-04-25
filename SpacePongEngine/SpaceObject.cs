using System;

namespace SpacePongEngine
{
    abstract public class SpaceObject
    {
        static protected Random rng = new Random();

        private int x = 0;
        public int X
        {
            get { return x; }
            set
            {
                if (value < 0)
                    x = 0;
                else if (value >= WorldWidth)
                    x = WorldWidth-1;
                else
                    x = value;
            }
        }
        private int y = 0;
        public int Y
        {
            get { return y; }
            set
            {
                if (value < 0)
                    y = 0;
                else if (value >= WorldHeight)
                    y = WorldHeight-1;
                else
                    y = value;
            }
        }

        public static int WorldWidth { get; set; }
        public static int WorldHeight { get; set; }

        public abstract void Update();

    }
}
