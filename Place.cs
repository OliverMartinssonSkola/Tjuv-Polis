using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvochPolis
{

    internal class Place
    {
        public static void Streets(List<Person> people, List<Person>prisoners) //RITAR UPP STADEN OCH INVÅNARES POSSITIONER
        {
            Console.CursorVisible = false;
            int width = 100;
            int height = 25;
           
            for (int i = 0; i <= width; i++)//LOOPAR FÖR RAM
            {
                Console.SetCursorPosition(i, 0);
                Console.Write('#');
            }
            for (int i = 0; i <= height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('#');
            }
            for (int i = 0; i <= height; i++)
            {
                Console.SetCursorPosition(width, i);
                Console.Write('#');
            }

            for (int i = 0; i <= width; i++)
            {
                Console.SetCursorPosition(i, height);
                Console.Write('#');
            }
            Movement.CityMovement(people);
            Helpers.Interaction(people, prisoners);
            Movement.PrisonMovement(prisoners);
            
            foreach (Person person in people) //RITAR UPP INVÅNARE
            {
                    if (person.Location[0] > 0 && person.Location[0] < height && person.Location[1] > 0 && person.Location[1] < width)
                    {
                        Console.SetCursorPosition(person.Location[1], person.Location[0]);
                    if (person is Citizen)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write('M');
                    }
                    else if (person is Cop)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write('P');
                    }
                    else if (person is Thief && ((Thief)person).InPrison == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write('T');
                        if (((Thief)person).TimeInPrison <= 0 && ((Thief)person).InPrison)
                        {
                            ((Thief)person).InPrison = false;
                        }
                    }
                        Console.ResetColor();
                    }
            }
            Thread.Sleep(500);
            Console.Write("\u001bc\x1b[3J");    
        }
        public static void Prison(List<Person> prisoners)//RITAR UPP FÄNGELSE OCH INTERNER
        {
            
            int width = 20;
            int height = 7;
            
            Console.SetCursorPosition(0, 26);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Fängelse:");
            Console.ResetColor();
            for (int i = 0; i <= width; i++)//LOOPAR FÖR RAM
            {
                Console.SetCursorPosition(i, 27);
                Console.Write('#');
            }
            for (int i = 27; i <= height + 27; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('#');
            }
            for (int i = 27; i <= height + 27; i++)
            {
                Console.SetCursorPosition(width, i);
                Console.Write('#');
            }

            for (int i = 0; i <= width; i++)
            {
                Console.SetCursorPosition(i, height + 27);
                Console.Write('#');
            }

            foreach (Thief prisoner in prisoners)//RITAR UPP INTERNER
            {
                Console.SetCursorPosition(prisoner.PrisonLocation[1], prisoner.PrisonLocation[0] + 27); 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write('T'); 
                Console.ResetColor();

            }
        }
    }
}
