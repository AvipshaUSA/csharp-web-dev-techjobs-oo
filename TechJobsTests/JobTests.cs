using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using TechJobsOO;



namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {

        // Test empty constructor
        
        [TestMethod]
        
        public void TestSettingJobId()
        {
        job1 = new Job();
        job2 = new Job();
        Assert.AreNotEqual(job1.Id, job2.Id);
        Assert.IsFalse(job1.Id.Equals(job2.Id));
        Assert.IsTrue(job1.Id.Equals(job1.Id));

        }


        // initialize object. it will initialize first then will go to other methods
        Job job1;
        Job job2;
        [TestInitialize]

        //Test the full constructor
       
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
         job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Assert.AreEqual(job1.Name, "Product tester");
        Assert.AreEqual(job1.EmployerName.Value, "ACME");
        Assert.AreEqual(job1.EmployerLocation.Value, "Desert");
        Assert.AreEqual(job1.JobType.Value, "Quality control");
        Assert.AreEqual(job1.JobCoreCompetency.Value, "Persistence");

        }

        //Test the Equals() Method

        [TestMethod]
        public void TestJobsForEquality()
        {
            job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse (job1.Equals(job2)) ;
        }




    }
}
