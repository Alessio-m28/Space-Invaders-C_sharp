using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Space_Invaders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
            Console.CursorVisible = false;
            Vaisseau vaisseau = new Vaisseau();

            while (true)
            {

                vaisseau.Move();
                Console.Clear();
                vaisseau.Draw();
            }

        }

        static void ShowMenu()

        {

            bool continuer = true;

            while (continuer)

            {

                Console.Clear();

                Console.WriteLine("=====================================================================================");

                Console.WriteLine("            S P A C E   I N V A D E R S (de Luca Pardo et Alessio Martino)           ");

                Console.WriteLine("=====================================================================================");

                Console.WriteLine();

                Console.WriteLine("[1] Lancer le jeu");

                Console.WriteLine("[2] Quitter");

                Console.Write("\nVotre choix : ");

                string choix = Console.ReadLine();

                switch (choix)
                {

                    case "1":

                        continuer = false;

                        Console.Clear();

                        break;

                    case "2":

                        Console.Clear();

                        Console.WriteLine("Merci d'avoir joué !");

                        Thread.Sleep(5000);

                        Environment.Exit(0);

                        break;

                    default:

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("\nChoix invalide !");

                        Console.ResetColor();

                        Console.WriteLine("Appuyez sur une touche pour continuer...");

                        Console.ReadKey();

                        break;

                }

            }

        }

        

        }

    }

