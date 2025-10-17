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
            List<string> list = new List<string>();
        }
    }

    class Citizen:Person
    {
        public bool IsCitizen { get; set; }
        public Citizen(bool IsCitizens, string name, int[] location, int[] direction) : base(name, location, direction)
        {
            
        }
        public override void Inventory()
        {
            
            List<string> belongings = new List<string>();
            belongings.Add("Plånbok");
            belongings.Add("Klocka");
            belongings.Add("Nycklar");
            belongings.Add("Mobiltelefon");
        }
    }

    class Cop:Person
    {
        public bool IsCop {  get; set; }

        public Cop(bool IsCop, string name, int[] location, int[] direction) : base(name, location, direction)
        {


        }
        public override void Inventory()
        {
            List<string> beslagtaget = new List<string>();
        }

    }

    class Thief:Person
    {
        public bool IsThief { get; set; }

        public Thief(bool IsThief, string name, int[] location, int[] direction) : base ( name, location, direction)
        {

        }
        public override void Inventory()
        {
            List<string> stöldgods = new List<string>();
        }

    }

    



}
