using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacePongEngine
{
    public class Cruiser:XWing
    {
        public override char ConsoleChar => 'C';

        private Hangar mainHangar = new Hangar(10);

        public override void Update()
        {
            base.Update();
            mainHangar.X = X;
            mainHangar.Y = Y;
            mainHangar.Update();
        }

        public List<XWing> EmptyHangars()
        {
           var toLaunch = mainHangar.Launch(10);
            foreach (var ship in toLaunch)
            {
                ship.VectorX = -VectorX;
            }
            return toLaunch;
        }
    }
}
