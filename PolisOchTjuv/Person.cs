using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolisOchTjuv
{
    internal class Person
    {
        public string[] Name { get; set; }
        public int[] Location { get; set; } 
        public int[] Direction { get; set; }
        public List <string> Inventory { get; set; }


        public Person(string[] name, int[] location, int[] direction, List<string> inventory )
        {
            Name = name;
            Location = location;    
            Direction = direction;
            Inventory = inventory;

        }



    }
}
