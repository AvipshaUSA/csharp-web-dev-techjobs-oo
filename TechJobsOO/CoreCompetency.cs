using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        private int id;
        private static int nextId = 1;
        private string value;

        // TODO: Change the fields to auto-implemented properties.

        public int Id { get; }
        public static int NextId;
        public string Value { get; set; }




        public CoreCompetency()
        {
            id = nextId;
            nextId++;
        }

    
        public CoreCompetency(string value) : this()//  It ALSO initializes id for the object by calling the first constructor statement with the : this() syntax
        {
            
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   id == competency.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string ToString()
        {
            return value;
        }
    }
    }

