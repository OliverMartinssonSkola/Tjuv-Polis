namespace TjuvochPolis
{
    internal class Program
    {
        public static char[,] streets = new char[25, 100];
        public static char[,] prison = new char[10, 20];
        static void Main(string[] args)
        {
            string[] firstName = new string[]
            {
                "Alen", "Alice", "Alina", "Amadeus", "Alex", "Alexandra", "Anton", "Bakr", "David", "Dzelila",
                "Edin", "Erik", "Filip", "Hamed", "Hussein", "Isak", "Jakob", "Johan", "Johan", "Joel",
                "Jonas", "Julia", "Kristofer", "Mikael T", "Mikael S", "Nemer", "Oliver M", "Oliver L", "Oscar", "Patrik",
                "Qudsia", "Ramoee", "Robin", "Tobias", "Wafae", "Yevheniia"
            };

            //string[] names = { };
            //City.CityRoofFloor();
            //Console.WriteLine();
            City.Streets();
            Console.WriteLine();
            Console.WriteLine();
            City.Prison();
            //City.CityRoofFloor();

        }
    }
}
