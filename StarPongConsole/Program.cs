using System;
using System.Collections.Generic;
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

            List<SpaceObject> allObjects = new List<SpaceObject>();

            allObjects.Add(new XWing());
            allObjects.Add(new MilFalcon());
            allObjects.Add(new AWing());

            allObjects.Add(new XWing(5, 5, 1, -1));
            allObjects.Add(new XWing(5, 7, 1, -1));
            allObjects.Add(new XWing(5, 9, 1, -1));


            while (true)
            {
                //update
                foreach (var so in allObjects)
                {
                    so.Update();
                }
                //draw
                foreach (var so in allObjects)
                {
                    DrawObject(so);
                }
                System.Threading.Thread.Sleep(50);
                Console.Clear();
            }
        }

        static void DrawObject(SpaceObject toDraw)
        {
            Console.SetCursorPosition(toDraw.X, toDraw.Y);
            Console.Write(toDraw.ConsoleChar);

          
        }
    }
}
