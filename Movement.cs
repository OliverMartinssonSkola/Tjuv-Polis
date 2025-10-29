using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvochPolis
{
    internal class Movement
    {
        public static void CityMovement(List<Person> people)
        {
            foreach (Person person in people)
            {
                person.Location[0] += person.Direction[0];
                if (person.Location[0] < 0)
                {
                    person.Location[0] = Program.streets.GetLength(0)-1;
                }
                else if (person.Location[0] >= Program.streets.GetLength(0))
                {
                    person.Location[0] = 0;
                }
                    person.Location[1] += person.Direction[1];
                if (person.Location[1] < 0)
                {
                    person.Location[1] = Program.streets.GetLength(1) - 1;
                }
                else if (person.Location[1] >= Program.streets.GetLength(1))
                {
                    person.Location[1] = 0;
                }
            }
            
        }
    }
}
