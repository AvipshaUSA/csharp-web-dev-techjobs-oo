using System;
namespace TechJobsOO
{
    public class PositionType
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this() // It ALSO initializes id for the object by calling the first constructor statement with the : this() syntax
        {  
                Value = value;
            
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
        

        public override string ToString()
        {
            return Value ; // just returning a valu
        }

        // using generatte optin by right clicking the class name and check box select id.
        public override bool Equals(object obj)
        {
            return obj is PositionType type &&
                   Id == type.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
