using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacePongEngine
{
    public class MilFalcon: XWing
    {

        public override char ConsoleChar
        {
            get
            {
                return 'M';
            }
        }

        private const int HYPERSPACEDISTANCE = 15;
        public override void Update()
        {
            base.Update();
            if (rng.Next(0, 21) == 0)
            {
                X = rng.Next(X- HYPERSPACEDISTANCE, X+ HYPERSPACEDISTANCE);
                Y = rng.Next(Y- HYPERSPACEDISTANCE, Y+ HYPERSPACEDISTANCE);
            }
        }
    }
}
