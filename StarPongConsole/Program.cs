using System;
using SpacePongEngine;


namespace StarPongConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceObject.WorldHeight = Console.WindowHeight;
            SpaceObject.WorldWidth = Console.WindowWidth;

            Console.CursorVisible = false;
            MilFalcon xw = new MilFalcon();

            while(true)
            {
                //update
                xw.Update();
                //draw
                DrawObject(xw);
                System.Threading.Thread.Sleep(50);
                Console.Clear();
            }
        }

        static void DrawObject(SpaceObject toDraw)
        {
            Console.SetCursorPosition(toDraw.X, toDraw.Y);
            Console.Write("X");
        }
    }
}
