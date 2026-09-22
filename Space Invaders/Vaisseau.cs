using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Space_Invaders
{
    internal class Vaisseau
    {

        string sprite = "_-^-_";
        
        public int move = 1;
        const int top = 20;
        const int wait = 100;
        int max = Console.LargestWindowWidth;
        
        

        public Vaisseau()
        {
            Console.SetCursorPosition(move, top);
            Console.Write(sprite);
        }

        public void Move()
        {
            var key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.D || key == ConsoleKey.RightArrow)
            {
                move++;

                
                if (move + sprite.Length > Console.WindowWidth)
                {
                    move = 0;
                }
            }
            else if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow)
            {
                move--;

                
                if (move < 0)
                {
                    move = Console.WindowWidth - sprite.Length;
                }
            }
            else if(key == ConsoleKey.Spacebar)
            {             
            }

            Thread.Sleep(wait);
            
        }

        public void Draw()
        {

            Console.SetCursorPosition(move, top);
            Console.Write(sprite);
        }
        
    }
}
