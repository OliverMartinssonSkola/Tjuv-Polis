using System.ComponentModel;
using System.Data.Common;

namespace TjuvochPolis
{
    internal class Program
    {
        public static char[,] streets = new char[25, 100];
        public static char[,] prison = new char[10, 20];
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
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
                int[] direction = {0,0};
                int[] location = { (rnd.Next(0, streets.GetLength(0))), (rnd.Next(0, streets.GetLength(1)))};
                List<string> belongings = new List<string>();
                belongings.Add("Plånbok");
                belongings.Add("Klocka");
                belongings.Add("Nycklar");
                belongings.Add("Mobiltelefon");
                while (direction[0]==0 && direction[1] == 0)
                {
                    direction[0] = rnd.Next(-1, 2);
                    direction[1]=rnd.Next(-1, 2);
                }
                persons.Add(new Citizen(true, name, location, direction, belongings));
                
            }
            for (int i = 0; i < 10; i++)
            {
                string name = firstName[rnd.Next(firstName.Length)];
                int[] direction = { 0, 0 };
                int[] location = { (rnd.Next(0, streets.GetLength(0))), (rnd.Next(0, streets.GetLength(1))) };
                while (direction[0] == 0 && direction[1] == 0)
                {
                    direction[0] = rnd.Next(-1, 2);
                    direction[1] = rnd.Next(-1, 2);
                }

                persons.Add(new Cop(true, name, location, direction));
            }
            for(int i = 0;i < 20;i++)
            {
                string name = firstName[rnd.Next(firstName.Length)];
                int[] direction = { 0, 0 };
                int[] location = { (rnd.Next(0, streets.GetLength(0))), (rnd.Next(0, streets.GetLength(1))) };
                while (direction[0] == 0 && direction[1] == 0)
                {
                    direction[0] = rnd.Next(-1, 2);
                    direction[1] = rnd.Next(-1, 2);
                }
                persons.Add(new Thief(true, name, location, direction));
            }

  

                City.Streets(persons);
                Console.WriteLine();
                Console.WriteLine();
                City.Prison();
                Console.WriteLine();
                Developer.DeveloperMode(persons);
                
            
            

        }
    }
}
