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
        public virtual void Inventory()
        {
            List<string> inventory =new List<string>();
    
       }
        
    }

    class Citizen:Person
    {
       
        public List<string> Belongings= new List<string>();

        public Citizen( string name, int[] location, int[] direction, List <string> belongings) : base(name, location, direction)
        {
            Belongings = belongings;
        }
        public override void Inventory()
        {
            List <string>belongings= new List<string>();

        }
    }

    class Cop:Person
    {
        
        public List <string> Beslagtaget { get; set; }

        public Cop( string name, int[] location, int[] direction, List <string> beslagtaget) : base(name, location, direction)
        {
            Beslagtaget = beslagtaget;

        }
        public  void beslagtaget()
        {
            List<string> beslagtaget = new List<string>();
        }

    }

    class Thief:Person
    {
        
        public List <string> Stöldgods { get; set; }

        public Thief( string name, int[] location, int[] direction, List <string> stöldgods) : base ( name, location, direction)
        {
            Stöldgods = stöldgods;
        }
        public void stöldgods()
        {
            List<string> stöldgods = new List<string>();
        }

    }

    



}
