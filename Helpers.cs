using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvochPolis
{
    internal class Helpers
    { 
        public static void CitienCreator(List<Person>people)
        {
            
            Random rnd = new Random();
            string[] firstName = new string[]
            {
                "Alen", "Alice", "Alina", "Amadeus", "Alex", "Alexandra", "Anton", "Bakr", "David", "Dzelila",
                "Edin", "Erik", "Filip", "Hamed", "Hussein", "Isak", "Jakob", "Johan", "Johan", "Joel",
                "Jonas", "Julia", "Kristofer", "Mikael T", "Mikael S", "Nemer", "Oliver M", "Oliver L", "Oscar", "Patrik",
                "Qudsia", "Ramoee", "Robin", "Tobias", "Wafae", "Yevheniia"
            };

            for (int i = 0; i < 30; i++)
            {
                string name = firstName[rnd.Next(firstName.Length)];
                int[] direction = { 0, 0 };
                int[] location = { (rnd.Next(0, Program.streets.GetLength(0))), (rnd.Next(0, Program.streets.GetLength(1))) };
                List<string> belongings = new List<string>() { "Plånbok", "Klocka", "Nycklar", "Mobiltelefon" };
                while (direction[0] == 0 && direction[1] == 0)
                {
                    direction[0] = rnd.Next(-1, 2);
                    direction[1] = rnd.Next(-1, 2);
                }
                people.Add(new Citizen(name, location, direction, belongings));
            }
            for (int i = 0; i < 10; i++)
            {
                string name = firstName[rnd.Next(firstName.Length)];
                int[] direction = { 0, 0 };
                int[] location = { (rnd.Next(0, Program.streets.GetLength(0))), (rnd.Next(0, Program.streets.GetLength(1))) };
                List<string> beslagtaget = new List<string>();
                while (direction[0] == 0 && direction[1] == 0)
                {
                    direction[0] = rnd.Next(-1, 2);
                    direction[1] = rnd.Next(-1, 2);
                }

                people.Add(new Cop(name, location, direction, beslagtaget));
            }
            for (int i = 0; i < 20; i++)
            {
                string name = firstName[rnd.Next(firstName.Length)];
                int[] direction = { 0, 0 };
                int[] location = { (rnd.Next(0, Program.streets.GetLength(0))), (rnd.Next(0, Program.streets.GetLength(1))) };
                List<string> stöldgods = new List<string>();
                while (direction[0] == 0 && direction[1] == 0)
                {
                    direction[0] = rnd.Next(-1, 2);
                    direction[1] = rnd.Next(-1, 2);
                }
                people.Add(new Thief(name, location, direction, stöldgods));
            }
        }
        public static void Interaction(List<Person> people)
        {
            foreach (var person1 in people)
            {
                foreach (var person2 in people) // två personer som träffas
                {
                    if (person1 != person2 && person1.Location[0] == person2.Location[0] && person1.Location[1] == person2.Location[1])
                    {
                        if (person1 is Citizen citizen1 && person2 is Cop cop1)
                        {
                            Console.WriteLine("Medborgaren " + person1.Name + " träffar polisen " + person2.Name + ", och hälsar på varandra.");
                        }

                        if (person1 is Citizen citizen2 && person2 is Thief thief1)
                        {
                            if (citizen2.Belongings != null) // om medborgaren har något
                            {
                                Random rnd = new Random();
                                int index = rnd.Next(0, citizen2.Belongings.Count);
                                string item = citizen2.Belongings[index];
                                citizen2.Belongings.RemoveAt(index); // ta bort item från medborgarens inventory
                                thief1.Stöldgods.Add(item); // lägga den i tjuvens inventory
                                Console.WriteLine("Tjuven " + person2.Name + "rånar en " + item + " till medborgaren " + person1.Name);
                            }
                            else
                            {
                                Console.WriteLine("Medborgarens fickor var tomma och tjuven blir sur!!!");
                            }

                        }
                        else if (person1 is Cop cop2 && person2 is Thief thief2)
                        {
                            if (thief2.Stöldgods.Count > 0)
                            {
                                cop2.Beslagtaget.AddRange(thief2.Stöldgods); // lägga alla grejer i polisens iventory
                                thief2.Stöldgods.Clear(); // tomma tjuvens inventory
                                Console.WriteLine("polisen " + person1.Name + "griper tjuven " + person2.Name + " och beslagtar alla stulna saker.");
                            }


                        }




                    }

                }
            }

        }

        //        public static (string name, int[]location, int[]direction) CreatePersons (Random rnd, string[]firstName, char[,] streets)
        //        {
        //            string name = firstName[rnd.Next(firstName.Length)];
        //            int[] location = { rnd.Next(0, streets.GetLength(0)), rnd.Next(0, streets.GetLength(1)) };
        //            int[] direction = { 0, 0 };

        //            while (direction[0] == 0 && direction[1]==0)
        //            {
        //                direction[0] = rnd.Next(-1, 2);
        //                direction[1] = rnd.Next(-1, 2);
        //            }


        //            return (name, location, direction);
        //        }
    }
}
