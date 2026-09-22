using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Space_Invaders
{
    internal class Shoot
    {
        string sprite = "  |";
        int top = 19;
        int left;

        public Shoot(Vaisseau vaisseau)
        {
            left = vaisseau.move;
        }
    }
}
