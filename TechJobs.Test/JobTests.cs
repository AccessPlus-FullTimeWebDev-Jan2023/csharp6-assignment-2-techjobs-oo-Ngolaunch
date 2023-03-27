
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        //initalize your testing objects here
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {
            
            Assert.AreNotEqual(job1.Id,job2.Id); //testing equality with know nextId ++//
            Assert.IsTrue((job2.Id - job1.Id) == 1);// diff by subtraction//
            
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.IsTrue(job3.Name == "Product tester");
            //ref the .value of the object
            Assert.IsTrue(job3.EmployerName.Value == "ACME");
            Assert.IsTrue(job3.JobType.Value == "Quality control");
            Assert.IsTrue(job3.JobCoreCompetency.Value == "Persistence");

        }
        [TestMethod] 
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job1.Equals(job2));  
        }

    }

    
    
}

