using System.ComponentModel;
using System.Data.Common;

namespace TjuvochPolis
{
    internal class Program
    {
        public static char[,] streets = new char[26, 101];
        public static char[,] prison = new char[7, 20];
        public static bool happening = false;
        static void Main(string[] args)
        {
            bool running = true;
            bool vy = true;
            Console.SetBufferSize(300,300);
           // Console.SetWindowSize(120,80); //Gör inget om man kör med poweshell

            Console.CursorVisible = false;

            List<Person> people = new List<Person>();
            List<Person> prisoners = new List<Person>();
            Helpers.CitienCreator(people);

            while (running) // main loop
            {
                if (vy)
                {
                    //STREET LOOP
                    bool inStreets = true;
                    while (inStreets)
                    {
                        Place.Streets(people, prisoners); // växla till Streets  
                        Place.Prison(prisoners);
                        Helpers.PrisonersList(prisoners);
                        Helpers.InteractionList();

                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Spacebar)
                            {
                                vy = false;      //växla till developer mode
                                inStreets = false; //avsluta sub-loop
                            }
                            else if (key.Key == ConsoleKey.Escape)
                            {
                                running = false; // avsluta
                                inStreets = false;
                            }
                        }
                       // Thread.Sleep(500);
                    }
                }
                else if (!vy)
                {
                    bool inDeveloper = true;
                    while (inDeveloper)
                    {

                        
                        Developer.DeveloperMode(people, prisoners);
                       // Movement.PrisonMovement(prisoners);
                       // Movement.CityMovement(people);
                       if(Console.KeyAvailable)
                       { 
                            ConsoleKeyInfo key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Spacebar)
                            {
                                
                                inDeveloper = false;
                                vy = true; //växla till street
                            }
                            else if (key.Key == ConsoleKey.Escape)
                            {
                                running = false; //avsluta
                                inDeveloper = false;

                            }
                       }
                       Thread.Sleep(500);
                       Console.Write("\u001bc\x1b[3J");
                    }

                }
                
            }
        }
    }
}
