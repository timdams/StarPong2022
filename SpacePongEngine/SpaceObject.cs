using System;

namespace SpacePongEngine
{
    abstract public class SpaceObject
    {
        static protected Random rng = new Random();
        public int X { get; set; }
        public int Y { get; set; }

        public static int WorldWidth { get; set; }
        public static int WorldHeight { get; set; }

        public abstract void Update();

    }
}
