using System;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

       public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName , Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this() // :this() will initialize an id for that constructor too
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }


        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj) // right click on the class name and generate by Id
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }


        


    }
}
