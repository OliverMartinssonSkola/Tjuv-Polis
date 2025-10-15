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
        public bool IsCitizen { get; set; }
        public Citizen(bool IsCitizens, string name, int[] location, int[] direction) : base(name, location, direction)
        {
            
        }
    }

    class Cop:Person
    {
        public bool IsCop {  get; set; }

        public Cop(bool IsCop, string name, int[] location, int[] direction) : base(name, location, direction)
        {


        }


    }

    class Thief:Person
    {
        public bool IsThief { get; set; }

        public Thief(bool IsThief, string name, int[] location, int[] direction) : base (name, location, direction)
        {

        }


    }

    



}
