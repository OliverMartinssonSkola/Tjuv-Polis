using System.ComponentModel;
using System.Data.Common;

namespace TjuvochPolis
{
    internal class Program
    {
        public static char[,] streets = new char[26, 101];
        public static char[,] prison = new char[10, 20];
        public static bool happening = false;
        static void Main(string[] args)
        {
            bool running = true;
            bool vy = true;
            Console.SetBufferSize(120,120);
            Console.SetWindowSize(120,35); //Gör inget om man kör med poweshell

            Console.CursorVisible = false;

            List<Person> people = new List<Person>();
            List<Person> prisoners = new List<Person>();
            Helpers.CitienCreator(people);
            
            //while (true)
            //{

            //    ConsoleKeyInfo key = Console.ReadKey();

            //    if (key.Key == ConsoleKey.Spacebar)
            //    {
            //        Console.Clear();
            //        vy = !vy;



            //        switch (vy)
            //        {
            //            case true:
            //                Console.Clear();
            //                while (vy)
            //                {
            //                    Place.Streets(people);
            //                }
            //                break;
            //            case false:

            //                Console.Clear();
            //                Developer.DeveloperMode(people);
            //                break;
            //        }
            //    }
            //}
            

        

        while (running) //main loop
        {

        if (vy)
        {
        //STREET LOOP
        bool inStreets = true;
        bool interactionsVisible = false;
        while (inStreets)
        {
        
        Place.Streets(people);  //växla till Streets
        Place.Prison(prisoners);
        if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Spacebar)
                {
                    //Console.Write("\u001bc\x1b[3J");
                    vy = false;      //växla till developer mode
                    inStreets = false; //avsluta sub-loop
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                running = false; // avsluta
                inStreets = false;
                }
            }
                        //if (happening)
                        {
                            //Console.Write("\u001bc\x1b[3J");
                            //Console.SetCursorPosition(0, 27);
                            Helpers.InteractionList();
                            happening = false;
                            interactionsVisible = true;
                        }
                        //else if (interactionsVisible)
                        {
                            Helpers.InteractionList();
                        }
                            Thread.Sleep(50); // spara GPU och snyggare övergång
                
                    }

                }
        
            else
            {
            Console.Clear();
            //Console.Write("\u001bc\x1b[3J");
            Developer.DeveloperMode(people);
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Spacebar)
            {
                        Console.Write("\u001bc\x1b[3J");
                        vy = true; //växla till street
            }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        running = false; //avsluta
                    }
            }
        }
        
            
            //City.Streets(people);
            //Console.WriteLine();
            //Console.WriteLine();
            //City.Prison();
            //Console.WriteLine();
            //Place.Streets(people);
            //Developer.DeveloperMode(people);








        }
    }
}
