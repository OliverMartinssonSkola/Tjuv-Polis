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
            Console.SetBufferSize(Console.BufferWidth, 200);
            Console.SetBufferSize(Console.BufferHeight, 200);
            Console.CursorVisible = false;
            List<Person> people = new List<Person>();
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
                List<string> belongings = new List<string>() { "Plånbok", "Klocka", "Nycklar", "Mobiltelefon" };
                while (direction[0]==0 && direction[1] == 0)
                {
                    direction[0] = rnd.Next(-1, 2);
                    direction[1]=rnd.Next(-1, 2);
                }
                people.Add(new Citizen( name, location, direction, belongings));
            }
            for (int i = 0; i < 10; i++)
            {
                string name = firstName[rnd.Next(firstName.Length)];
                int[] direction = { 0, 0 };
                int[] location = { (rnd.Next(0, streets.GetLength(0))), (rnd.Next(0, streets.GetLength(1))) };
                List<string> beslagtaget = new List<string>();
                while (direction[0] == 0 && direction[1] == 0)
                {
                    direction[0] = rnd.Next(-1, 2);
                    direction[1] = rnd.Next(-1, 2);
                }

                people.Add(new Cop( name, location, direction, beslagtaget));
            }
            for(int i = 0;i < 20;i++)
            {
                string name = firstName[rnd.Next(firstName.Length)];
                int[] direction = { 0, 0 };
                int[] location = { (rnd.Next(0, streets.GetLength(0))), (rnd.Next(0, streets.GetLength(1))) };
                List<string> stöldgods= new List<string>();
                while (direction[0] == 0 && direction[1] == 0)
                {
                    direction[0] = rnd.Next(-1, 2);
                    direction[1] = rnd.Next(-1, 2);
                }
                people.Add(new Thief( name, location, direction, stöldgods));
            }

  

                //City.Streets(people);
                //Console.WriteLine();
                //Console.WriteLine();
                //City.Prison();
                //Console.WriteLine();
                //Developer.DeveloperMode(people);
                Place.Streets(people);
            
              
            

                
            
            

        }
    }
}
