using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvochPolis
{

    internal class City
    {

        //public static void CityRoofFloor()
        //{
        //    for (int i = 0; i < 102; i++)
        //    {
        //        Console.Write('#');
        //    }

        //}
        public static void Streets()
        {
            {
                for (int i = 0; i < 102; i++)
                {
                    Console.Write('#');
                }

            }
            Console.WriteLine();
            for (int row = 0; row < Program.streets.GetLength(0); row++)
            {
                Console.Write('#');
                for (int col = 0; col < Program.streets.GetLength(1); col++)
                {
                    Console.Write(' ');
                }
                Console.Write('#');
                Console.WriteLine();
            }
            {
                for (int i = 0; i < 102; i++)
                {
                    Console.Write('#');
                }

            }


        }

        public static void Prison()
        {
            {
                for (int i = 0; i < 22; i++)
                {
                    Console.Write('#');
                }

            }
            Console.WriteLine();
            for (int row = 0; row < Program.prison.GetLength(0); row++)
            {
                Console.Write('#');
                for (int col = 0; col < Program.prison.GetLength(1); col++)
                {
                    Console.Write(' ');
                }
                Console.Write('#');
                Console.WriteLine();
            }
            {
                for (int i = 0; i < 22; i++)
                {
                    Console.Write('#');
                }

            }


        }

        public static void Prison()
        {
            {
                for (int i = 0; i < 22; i++)
                {
                    Console.Write('#');
                }

            }
            Console.WriteLine();
            for (int row = 0; row < Program.prison.GetLength(0); row++)
            {
                Console.Write('#');
                for (int col = 0; col < Program.prison.GetLength(1); col++)
                {
                    Console.Write(' ');
                }
                Console.Write('#');
                Console.WriteLine();
            }
            {
                for (int i = 0; i < 22; i++)
                {
                    Console.Write('#');
                }

            }
        }





    }
}