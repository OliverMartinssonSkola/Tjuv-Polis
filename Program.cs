using System.ComponentModel;
using System.Data.Common;

namespace TjuvochPolis
{
    internal class Program
    {
        public static char[,] streets = new char[26, 101];//ARRAY FÖR STADEN
        public static char[,] prison = new char[7, 20];//ARRAY FÖR FÄNGELSE
        static void Main(string[] args)
        {
            bool running = true;
            bool vy = true;
            Console.SetBufferSize(300,300);//MÖJLIGGÖR START OM STARTSKÄRMEN ÄR FÖR LITEN
            Console.CursorVisible = false;

            List<Person> people = new List<Person>();//LISTA FÖR INVÅNARE
            List<Person> prisoners = new List<Person>();//LISTA FÖR INTERNER
            Helpers.CitienCreator(people);//SKAPAR INVÅNARE

            while (running)//HUVUD LOOP FÖR ATT KÖRA KODEN
            {
                if (vy)//SUB-LOOP FÖR ATT VÄLJA VY
                {
                    
                    bool inStreets = true;
                    while (inStreets)//STREET lOOP
                    {
                        Place.Streets(people, prisoners);//VISAR STADEN
                        Place.Prison(prisoners);//VISA FÄNGELSE
                        Helpers.PrisonersList(prisoners);//LISTAR INTERNER
                        Helpers.InteractionList();//LISTAR HÄNDELSER

                        if (Console.KeyAvailable)//VÄNTAR PÅ INMATNING
                        {
                            ConsoleKeyInfo key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Spacebar)//VILLKOR FÖR ATT VÄXLA VY ELLER AVSLUTA PROGRAM
                            {
                                vy = false;
                                inStreets = false;
                            }
                            else if (key.Key == ConsoleKey.Escape)
                            {
                                running = false;
                                inStreets = false;
                            }
                        }

                    }
                }
                else if (!vy)
                {
                    bool inDeveloper = true;
                    while (inDeveloper)
                    {
                        Developer.DeveloperMode(people, prisoners);//VISAR DEVELOPERMODE
                       if(Console.KeyAvailable)
                       { 
                            ConsoleKeyInfo key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Spacebar)//VILLKOR FÖR ATT VÄXLA VY ELLER AVSLUTA PROGRAM
                            {
                                
                                inDeveloper = false;
                                vy = true;
                            }
                            else if (key.Key == ConsoleKey.Escape)
                            {
                                running = false;
                                inDeveloper = false;

                            }
                       }
                       
                        Console.Write("\u001bc\x1b[3J");//KRAFTIGARE VERSION AV Console.Clear OCH Console.SetCursorPosition
                    }

                }
                
            }
        }
    }
}
