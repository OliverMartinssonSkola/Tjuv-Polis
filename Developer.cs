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
        public static void DeveloperMode(List<Person>persons)
        {
            foreach (Person person in persons)
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
                else if (person is Citizen)
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
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
