using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using TechJobsOO;
using System;



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
        string toString;

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


        //Test Blank line before and after the job information means need to check for \n at begining and \n at the End
        [TestMethod]
        public void ToStringBlanckLine()
        {
            //job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

                toString =job1.ToString();
            Assert.AreEqual(toString[0], '\n'); // \n at begining at index 0



            //Assert.AreEqual(toString[^1], '\n');// \n at the end of a sequence(i)

            Assert.AreEqual(toString[toString.Length-1], '\n');// \n check at the end of sequence(ii), (i)&(ii)both are same indifferent way
                                               
                                                 

        }


    }
}
