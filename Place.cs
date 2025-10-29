using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvochPolis
{

    internal class Place
    {

        public static void Streets(List<Person> people)
        {

            int width = 100;//larghezza
            int height = 25; // altezza

            for (int i = 0; i <= width; i++) // taket
            {
                Console.SetCursorPosition(i, 0);
                Console.Write('#');
            }
            for (int i = 0; i <= height; i++) // vänster vägg
            {
                Console.SetCursorPosition(0, i);
                Console.Write('#');
            }
            for (int i = 0; i <= height; i++) //höger vägg
            {
                Console.SetCursorPosition(width, i);
                Console.Write('#');
            }

            for (int i = 0; i <= width; i++) // golvet
            {
                Console.SetCursorPosition(i, height);
                Console.Write('#');
            }
            Program.streets = new char[height + 1, width + 1]; // tom array

            while (true)
            {

                foreach (Person person in people)
                {

                    if (person.Location[0] > 0 && person.Location[0] < height && person.Location[1] > 0 && person.Location[1] < width)
                    {
                        Console.SetCursorPosition(person.Location[1], person.Location[0]);

                        Console.Write(' ');
                    }
                }

                Movement.CityMovement(people); // rörelse

                foreach (Person person in people)
                {
                    if (person.Location[0] > 0 && person.Location[0] < height && person.Location[1] > 0 && person.Location[1] < width)
                    {
                        Console.SetCursorPosition(person.Location[1], person.Location[0]);
                        if (person is Citizen)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write('C');
                        }
                        else if (person is Cop)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write('P');
                        }
                        else if (person is Thief)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write('T');
                        }
                        Console.ResetColor();

                    }
                }
                Thread.Sleep(500);
            }
        }
    }
}

           
            

    








    //  Console.Clear();
    //    int width = 100;
    //    int height = 25;
    //    for (int col = 0; col <= width+2; col++) // taket
    //    {
    //        Console.SetCursorPosition(col, 0);
    //        Console.Write('#');
    //        // Console.SetCursorPosition(i, 27);
    //        // Console.Write('#');
    //    }

    //    for (int row = 0; row < height + 1; row++)
    //    {
    //        Console.SetCursorPosition(0, row); // höger vägg
    //        Console.Write('#');
    //    }
    //            for (int row = 0;row<height + 2; row++)
    //            { 
    //                 for (int col = 0; col<width; col++)
    //                 {
    //                        //if (Program.streets[row, col] == '\0')
    //                        //{
    //                        Console.ResetColor();
    //                        Program.streets[row, col] = ' ';

    //                        //}

    //                        foreach (Person person in people)
    //                        {
    //                            if ((person.Location[0] == row) && (person.Location[1] == col))
    //                            {

    //                                if (person is Citizen && (person.Location[0] == row) && (person.Location[1] == col))
    //                                {
    //                                    Console.ForegroundColor = ConsoleColor.Yellow;
    //                                    Program.streets[row, col] = 'C';
    //                                }
    //                                else if (person is Cop && (person.Location[0] == row) && (person.Location[1] == col))
    //                                {
    //                                    Console.ForegroundColor = ConsoleColor.Blue;
    //                                    Program.streets[row, col] = 'P';
    //                                }
    //                                else if (person is Thief && (person.Location[0] == row) && (person.Location[1] == col))
    //{
    //    Console.ForegroundColor = ConsoleColor.Red;
    //    Program.streets[row, col] = 'T';
    //}

    //                            }

    //                        }
    //                        Console.SetCursorPosition(col + 1, row + 1);
    //Console.Write(Program.streets[row, col]);
    //Console.ResetColor();
    //         }
    //         for( row = 0; row <height+1; row++)
    //         {
    //            Console.SetCursorPosition(row, width);
    //            Console.Write('#');
    //         }

    //        //Console.SetCursorPosition(Program.streets.GetLength(1)+1, row +1);
    //        //Console.Write('#');
    //    }
    //    for (int col = 0; col <= width+2; col++) // golv
    //    {

    //        Console.SetCursorPosition(height,col);
    //        Console.Write('#');
    //    }


    //}




    //Console.Clear();
    //for (int i = 0; i < 102; i++)
    //{
    //    Console.Write('#');
    //}

    //Console.WriteLine();
    //for (int row = 0; row < Program.streets.GetLength(0); row++)
    //{
    //    Console.Write('#');
    //    for (int col = 0; col < Program.streets.GetLength(1); col++)
    //    {
    //        //if (Program.streets[row, col] == '\0')
    //        //{
    //        Console.ResetColor();
    //        Program.streets[row, col] = ' ';

    //        //}

    //        foreach (Person person in people)
    //        {
    //            if ((person.Location[0] == row) && (person.Location[1] == col))
    //            {

    //                if (person is Citizen && (person.Location[0] == row) && (person.Location[1] == col))
    //                {
    //                    Console.ForegroundColor = ConsoleColor.Yellow;
    //                    Program.streets[row, col] = 'C';
    //                }
    //                else if (person is Cop && (person.Location[0] == row) && (person.Location[1] == col))
    //                {
    //                    Console.ForegroundColor = ConsoleColor.Blue;
    //                    Program.streets[row, col] = 'P';
    //                }
    //                else if (person is Thief && (person.Location[0] == row) && (person.Location[1] == col))
    //                {
    //                    Console.ForegroundColor = ConsoleColor.Red;
    //                    Program.streets[row, col] = 'T';
    //                }

    //            }

    //        }

    //        Console.Write(Program.streets[row, col]);
    //        Console.ResetColor();


    //    }
    //    Console.Write('#');
    //    Console.WriteLine();

    //}

    //for (int i = 0; i < 102; i++)
    //{

    //    Console.Write('#');
    //}


    //Movement.CityMovement(people);
    //        Thread.Sleep(500);
    //Developer.Interaction(people);



    //}

//public static void Prison()
//        {
//            {
//                for (int i = 0; i < 22; i++)
//                {
//                    Console.Write('#');
//                }

//            }
//            Console.WriteLine();
//            for (int row = 0; row < Program.prison.GetLength(0); row++)
//            {
//                Console.Write('#');
//                for (int col = 0; col < Program.prison.GetLength(1); col++)
//                {
//                    Console.Write(' ');
//                }
//                Console.Write('#');
//                Console.WriteLine();
//            }
//            {
//                for (int i = 0; i < 22; i++)
//                {
//                    Console.Write('#');
//                }

//            }


//        }



    //
