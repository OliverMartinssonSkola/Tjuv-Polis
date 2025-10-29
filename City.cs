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

        public static void Streets(List<Person>people)
        {
            while (true)
            {
                Console.Clear();
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
                        //if (Program.streets[row, col] == '\0')
                        //{
                            Console.ResetColor();
                            Program.streets[row, col] = ' ';

                        //}

                        foreach (Person person in people)
                        {
                            if ((person.Location[0] == row) && (person.Location[1] == col))
                            {

                                if (person is Citizen && (person.Location[0] == row) && (person.Location[1] == col))
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Program.streets[row, col] = 'C';
                                }
                                else if (person is Cop && (person.Location[0] == row) && (person.Location[1] == col))
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Program.streets[row, col] = 'P';
                                }
                                else if (person is Thief && (person.Location[0] == row) && (person.Location[1] == col))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Program.streets[row, col] = 'T';
                                }
                                
                            }

                        }
                        
                        Console.Write(Program.streets[row, col]);
                        Console.ResetColor();


                    }
                    Console.Write('#');
                    Console.WriteLine();
                    
                }
                
                    for (int i = 0; i < 102; i++)
                    {
                        
                        Console.Write('#');
                    }

                
                Movement.CityMovement(people);
                Thread.Sleep(500);
                Developer.Interaction(people);
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