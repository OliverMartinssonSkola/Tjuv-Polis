using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TjuvochPolis
{
    internal class Developer
    {
        public static void DeveloperMode(List<Person>people)
        {
            foreach (Person person in people)
            {
                if (person is Thief thief)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
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
                    Console.WriteLine(",");
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
                    Console.ResetColor();
                }
                else if (person is Cop cop)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("P " + person.Name + " ");
                    foreach (int location in person.Location)
                    {
                        Console.Write(location + " ");
                    }
                    Console.Write(',');
                    foreach (int direction in person.Direction)
                    {
                        Console.Write(direction + " ");
                    }
                    Console.WriteLine(",");
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
                    Console.WriteLine(",");
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
        }


    }
}
