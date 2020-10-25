using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
   public abstract class JobField   // 6- Finally, to prevent the creation of a JobField object, make this class abstract.
    {

        // 1-What fields do ALL FOUR of the classes have in common?
        // these 3 fields are common, exacly same in Employer, Location, CoreCompetency, and PositionType. 
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }



        // 2- Which constructors are the same in ALL FOUR classes?
        // empty constructor and the value arg constructors are same in all Employer, Location, CoreCompetency, and PositionType classes

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()  //  It ALSO initializes id for the object by calling the first constructor statement with the : this() syntax
        {
            Value = value;
        }


        //3-Which custom methods are identical in ALL of the classes?
        // Equals() , GetHashCode(), ToSring() custom methods are common all Employer, Location, CoreCompetency, and PositionType classes

        public override bool Equals(object obj)
        {
            return obj is JobField field &&
                   Id == field.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
