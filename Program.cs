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
                int[] location = new int[] { (rnd.Next(0, streets.GetLength(0))), (rnd.Next(0, streets.GetLength(1)))};
                int[] direction = { (rnd.Next(-1, 2)), (rnd.Next(-1, 2)) };
                persons.Add(new Citizen(true, name, location, direction));
            }
            for (int i = 0; i < 10; i++)
            {
                string name = firstName[rnd.Next(firstName.Length)];
                int[] location = new int[] { (rnd.Next(0, streets.GetLength(0))), (rnd.Next(0, streets.GetLength(1))) };
                int[] direction = { (rnd.Next(-1, 2)), (rnd.Next(-1, 2)) };
                persons.Add(new Cop(true, name, location, direction));
            }
            for(int i = 0;i < 20;i++)
            {
                string name = firstName[rnd.Next(firstName.Length)];
                int[] location = new int[] { (rnd.Next(0, streets.GetLength(0))), (rnd.Next(0, streets.GetLength(1))) };
                int[] direction = { (rnd.Next(-1, 2)), (rnd.Next(-1, 2)) };
                persons.Add(new Thief(true, name, location, direction));
            }


            
            
                
                //string[] names = { };
                //City.CityRoofFloor();
                //Console.WriteLine();
                City.Streets(persons);
                Console.WriteLine();
                Console.WriteLine();
                City.Prison();
                Console.WriteLine();
                Developer.DeveloperMode(persons);
                
            
            

        }
    }
}
