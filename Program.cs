using System.ComponentModel;
using System.Data.Common;

namespace TjuvochPolis
{
    internal class Program
    {
        public static char[,] streets = new char[26, 101];
        public static char[,] prison = new char[10, 20];
        
        static void Main(string[] args)
        {
            bool running = true;
            bool vy = true;
            //Console.SetBufferSize(Console.BufferWidth, 200);
            //Console.SetBufferSize(Console.BufferHeight, 200);
            Console.CursorVisible = false;

            List<Person> people = new List<Person>();
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

        while (inStreets)
        {
            Console.Clear();
            Place.Streets(people);  //växla till Streets
           
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

            Thread.Sleep(50); // spara GPU och snyggare övergång
        }
        }
            else
            {

            Console.Clear();
            Developer.DeveloperMode(people);
        

            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Spacebar)
            {
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
