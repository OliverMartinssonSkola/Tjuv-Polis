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
            
            //Console.SetBufferSize(Console.BufferWidth, 200);
            //Console.SetBufferSize(Console.BufferHeight, 200);
            Console.CursorVisible = false;

            List<Person> people = new List<Person>();
            Helpers.CitienCreator(people);
            bool vy = true;

            //while (true)
            //{
            //    Console.Clear();

            //    if (vy)

            //        Place.Streets(people);
            //    else
            //        Developer.DeveloperMode(people);

            //    ConsoleKeyInfo key = Console.ReadKey(true);

            //    if (key.Key == ConsoleKey.Spacebar)
            //    {
            //        vy = !vy; // toggle mode
            //    }
            //    else if (key.Key == ConsoleKey.Escape)
            //    {
            //        break; // exit program
            //    }
            //}
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
            

bool running = true;

while (running) // main program loop
{

    if (vy)
    {
        // ---- STREET MODE LOOP ----
        bool inStreets = true;

        while (inStreets)
        {
            Console.Clear();
            Place.Streets(people);  // your drawing/update function
           
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Spacebar)
                {
                    vy = false;      // toggle to developer mode
                    inStreets = false; // exit this sub-loop
                }
                            else if (key.Key == ConsoleKey.Escape)
                            {
                                running = false; // exit the whole program
                                inStreets = false;
                            }
                        }

            Thread.Sleep(50); // small delay for smoother updates
        }
    }
    else
    {

        Console.Clear();
        Developer.DeveloperMode(people);
        

        ConsoleKeyInfo key = Console.ReadKey(true);
        if (key.Key == ConsoleKey.Spacebar)
        {
            vy = true; // switch back to street mode
        }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        running = false; // exit program
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
