using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvochPolis
{
    
    internal class Person
    {
        public string Name { get; set; }
        public int[] Location { get; set; }
        public int[] Direction { get; set; }
        
        public Person(string name, int[] location, int[] direction)
        {
            Name = name;
            Location = location;
            Direction = direction;
            

        }
    }

    class Citizen:Person
    {
       
        public List<string> Belongings= new List<string>();

        public Citizen( string name, int[] location, int[] direction, List <string> belongings) : base(name, location, direction)
        {
            Belongings = belongings;
        }
    }

    class Cop:Person
    {
        
        public List <string> Beslagtaget { get; set; }

        public Cop( string name, int[] location, int[] direction, List <string> beslagtaget) : base(name, location, direction)
        {
            Beslagtaget = beslagtaget;

        }
    }

    class Thief:Person
    {
        public bool InPrison { get; set; } = false;
        public int[] PrisonLocation { get; set; }

        public List <string> Stöldgods { get; set; }
        public int TimeInPrison { get; set; }

        public Thief( string name, int[] location, int[] direction, List <string> stöldgods, bool inPrison, int[] prisonLocation) : base ( name, location, direction)
        {
            Stöldgods = stöldgods;
            InPrison = inPrison;
            PrisonLocation = prisonLocation;
        }
    }

    



}
