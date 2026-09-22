using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Vaisseau vaisseau = new Vaisseau();

            while (true)
            {

                vaisseau.Move();
                Console.Clear();
                vaisseau.Draw();
            }

        }
    }
}
