using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        public static void Streets(List<Person>persons)
        {
            
            for (int i = 0; i < 102; i++)
            {
                  Console.Write('#');
            }

            
            Console.WriteLine();
            for (int row = 0; row < Program.streets.GetLength(0); row++)
            {
                Console.Write('#');
                for (int col = 0; col < Program.streets.GetLength(1); col++)
                {
                    foreach(Person person in persons)
                    {
                        //if ((person.Location[0] == row) && (person.Location[1] == col))
                        {

                            if (person is Citizen && (person.Location[0] == row) && (person.Location[1] == col))
                            {
                                Console.Write('M');
                            }
                            else if (person is Cop && (person.Location[0] == row) && (person.Location[1] == col))
                            {
                                Console.Write('P');
                            }
                            else if (person is Thief && (person.Location[0] == row) && (person.Location[1] == col))
                            {
                                Console.Write('T');
                            }
                            else 
                            {
                            Console.Write(Program.streets[row,col]== '\0');
                            }
                            
                        }
                        


                    }
                    
                  
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

       

    }
}