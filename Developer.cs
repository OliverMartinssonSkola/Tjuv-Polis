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
                if (person is Thief)
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
                    Console.ResetColor();
                }
                else if (person is Cop)
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
                    Console.ResetColor();
                }
                else if (person is Citizen citizen)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("C " + person.Name + " ");
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
                    foreach(string item in citizen.Belongings)
                    {
                        Console.Write(item);
                        Console.Write(" ");
                    }

                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        public static void Interaction(List <Person>people)
        {
            foreach (var person1 in people)
            {
                foreach(var person2 in people) // två personer som träffas
                {
                    if(person1!=person2 && person1.Location[0] == person2.Location[0] && person1.Location[1] == person2.Location[1])
                    { 
                        if (person1 is Citizen citizen1 && person2 is Cop cop1)
                        {
                            Console.WriteLine("Medborgaren "+person1.Name+ " träffar polisen "+person2.Name+ ", och hälsar på varandra.");
                        }

                        if (person1 is Citizen citizen2 && person2 is Thief thief1)
                        {
                            if (citizen2.Belongings != null)
                            {
                                Random rnd = new Random();
                                int index = rnd.Next(0, citizen2.Belongings.Count);
                                string item = citizen2.Belongings[index];  
                                citizen2.Belongings.RemoveAt(index);
                                thief1.Stöldgods.Add(item);
                                Console.WriteLine("Tjuven " + person2.Name + "rånar en " + item + " till medborgaren " + person1.Name);
                            }
                            else
                            {
                                Console.WriteLine("Medborgarens fickor var tomma och tjuven blir sur!!!");
                            }

                        }
                        else if (person1 is Cop cop2 && person2 is Thief thief2)
                        {
                            if(thief2.Stöldgods.Count>0)
                            {
                                cop2.Beslagtaget.AddRange(thief2.Stöldgods);
                                thief2.Stöldgods.Clear();
                                Console.WriteLine("polisen " + person1.Name + "griper tjuven " + person2.Name + " och beslagtar alla stulna saker.");
                            }
                             
                            
                        }
                       
                       
                        

                    }
               
                }           
            }

        }
    }
}
