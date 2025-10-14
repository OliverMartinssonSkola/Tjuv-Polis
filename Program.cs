namespace TjuvochPolis
{
    internal class Program
    {
        public static char[,] streets = new char[25, 100];
        public static char[,] prison = new char[10, 20];
        static void Main(string[] args)
        {
            //string[] names = { };
            //City.CityRoofFloor();
            //Console.WriteLine();
            City.Streets();
            Console.WriteLine();
            Console.WriteLine();
            //City.CityRoofFloor();
            City.Prison();
            

            

        }
    }
}
