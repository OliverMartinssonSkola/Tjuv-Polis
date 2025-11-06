using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvochPolis
{
    internal class Movement
    {
        public static void CityMovement(List<Person> people) //VILLKOR FÖR RÖRELSEMÖNSTER I CITY
        {
            foreach (Person person in people)
            {
                person.Location[0] += person.Direction[0];
                if (person.Location[0] < 1)
                {
                    person.Location[0] = Program.streets.GetLength(0)-2;
                }
                else if (person.Location[0] >= Program.streets.GetLength(0))
                {
                    person.Location[0] = 1;
                }
                person.Location[1] += person.Direction[1];
                if (person.Location[1] < 1)
                {
                    person.Location[1] = Program.streets.GetLength(1) - 2;
                }
                else if (person.Location[1] >= Program.streets.GetLength(1))
                {
                    person.Location[1] = 1;
                }
            }      
        }
        public static void PrisonMovement(List<Person>prisoners) //VILLKOR FÖR RÖRELSEMÖNSTER I PRISON
        {
            foreach(Thief prisoner in prisoners)
            {
                if (prisoner is Thief thief && thief.InPrison)
                {
                    prisoner.PrisonLocation[0] += prisoner.Direction[0];
                    if (prisoner.PrisonLocation[0] < 1)
                    {
                        prisoner.PrisonLocation[0] = Program.prison.GetLength(0) - 1;
                    }
                    else if (prisoner.PrisonLocation[0] >= Program.prison.GetLength(0))
                    {
                        thief.PrisonLocation[0] = 1;
                    }
                    thief.PrisonLocation[1] += prisoner.Direction[1];
                    if (thief.PrisonLocation[1] < 1)
                    {
                        thief.PrisonLocation[1] = Program.prison.GetLength(1) - 1;
                    }
                    else if (thief.PrisonLocation[1] >= Program.prison.GetLength(1))
                    {
                        thief.PrisonLocation[1] = 1;
                    }
                }
            }
        }
    }
}
