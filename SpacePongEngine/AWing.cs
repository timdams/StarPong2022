using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacePongEngine
{
    public class AWing: XWing
    {
        public override char ConsoleChar
        {
            get
            {
                return 'A';
            }
        }
        public override void Update()
        {
            base.Update();

            //Specifieke AWing strategie van update toevoegen
            if(rng.Next(0,21)== 0)
            {
                VectorX = rng.Next(-2, 3);
                VectorY = rng.Next(-2, 3);   
            }

        }
    }
}
