using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacePongEngine
{
    public class Hangar : SpaceObject
    {
        public override char ConsoleChar { get { return 'H'; } }

        private List<XWing> fleet = new List<XWing>();

        public Hangar(int startFighter)
        {
            for (int i = 0; i < startFighter; i++)
            {
                fleet.Add(new XWing(X, Y, 0, 0));
            }
        }

        public override void Update()
        {
            foreach (var ship in fleet)
            {
                ship.X = X;
                ship.Y = Y;
            }
        }

        public List<XWing> Launch(int amount = 10)
        {

            var temp = new List<XWing>();
            if (amount != 0 && amount <= fleet.Count)
            {
                for (int i = 0; i < amount; i++)
                {
                    fleet[i].VectorX = rng.Next(-2, 3);
                    fleet[i].VectorY = rng.Next(-2, 3);
                    temp.Add(fleet[i]);
                }
                fleet.RemoveRange(0, amount - 1);
            }
            else
            {
                temp.AddRange(fleet);
                fleet.Clear();
            }
            return temp;
        }
    }
}
