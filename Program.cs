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
                    Console.Write("C " + person.Name + " " );
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
            //string[] names = { };
            //City.CityRoofFloor();
            //Console.WriteLine();
            City.Streets();
            Console.WriteLine();
            Console.WriteLine();
<<<<<<< HEAD
=======
            City.Prison();
>>>>>>> 24a727114b701eff41203a05a9f25705e4ca87f0
            //City.CityRoofFloor();
            City.Prison();
            

            

        }
    }
}
