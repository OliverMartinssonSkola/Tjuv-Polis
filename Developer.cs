using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace TjuvochPolis
{
    internal class Developer
    {
        public static void DeveloperMode(List<Person>people, List<Person> prisoners)
        {
            int yCop = 0;
            int xCop = 45;
            int yCitizen = 0;
            int xCitizen = 0;
            int yThief = 0;
            int xThief = 90;
            foreach (Person person in people)
            {
                if (person is Thief thief)
                {

                    Console.SetCursorPosition(xThief, yThief++);
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (thief.InPrison)
                    {
                        Console.Write("T " + person.Name + " \n > Sitter i fängelset ");
                       
                    }
                    else
                    {
                        Console.Write("T " + person.Name + " ");

                        foreach (int location in person.Location)
                        {
                            Console.Write(location + " ");
                        }
                        Console.Write(',');
                        foreach (int direction in person.Direction)
                        {
                            Console.Write(direction + " ");
                        }

                        Console.Write(",");
                        Console.SetCursorPosition(xThief, yThief++);
                        if (thief.Stöldgods.Count == 0)
                        {
                            Console.Write("> Har ej rånat någon ännu");
                        }
                        else
                        {
                            foreach (string item in thief.Stöldgods)
                            {
                                Console.Write(item);
                                Console.Write(" ");
                            }
                        }
                    }
                    Console.ResetColor();
                }
                else if (person is Cop cop)
                {
                     
                        Console.SetCursorPosition(xCop, yCop++);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("| P " + person.Name + " ");
                        foreach (int location in person.Location)
                        {
                            Console.Write(location + " ");
                        }
                        Console.Write(',');

                        foreach (int direction in person.Direction)
                        {
                            Console.Write(direction + " ");
                        }
                        Console.Write(",");
                    Console.SetCursorPosition(xCop, yCop++);

                        if (cop.Beslagtaget.Count == 0)
                        {
                            Console.Write("> Inget beslagtaget");
                        }
                        else
                        {
                            foreach (string item in cop.Beslagtaget)
                            {
                                Console.Write(item);
                                Console.Write(" ");
                            }
                        }
                    
                        Console.ResetColor();
                    
                }
                else if (person is Citizen citizen)
                {
                    Console.SetCursorPosition(xCitizen, yCitizen++);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("M " + person.Name + " ");
                        foreach (int location in person.Location)
                        {
                            Console.Write(location + " ");
                        }
                        Console.Write(",");

                        foreach (int direction in person.Direction)
                        {
                            Console.Write(direction + " ");
                        }
                        Console.Write(",");
                    Console.SetCursorPosition(xCitizen, yCitizen++);

                        if (citizen.Belongings.Count == 0)
                        {
                            Console.Write("> Alla ägodelar stulna");
                        }
                        else
                        {
                            foreach (string item in citizen.Belongings)
                            {
                                Console.Write(item);
                                Console.Write(" ");
                            }
                        }
                        
                    
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Movement.CityMovement(people);
            Movement.PrisonMovement(prisoners);
            Helpers.Interaction(people, prisoners);
            Thread.Sleep(500);

        }
    }
}
