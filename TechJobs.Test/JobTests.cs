
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

        [TestMethod]

        public void TestToStringStartsAndEndsWithNewLine()
        {
            var actual = job3.ToString();

            Assert.AreEqual("\n", (actual[0]).ToString());
            Assert.AreEqual("\n", (actual[actual.Length-1]).ToString());

            //Assert.AreEqual("\n", actual.First());
            //Assert.AreEqual("\n", actual.Last());

        }
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            var expected = 
                "\n"
                +"ID: 1\n"
                + "Name: Data not available\n"
                + "Employer: Data not available\n"
                + "Location: Data not available\n"
                + "Position Type: Data not available\n"
                + "Core Competency: Data not available\n"
                + "\n";

            Assert.AreEqual(expected, job1.ToString());
        }
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            var expected =
               "\n"
               + "ID: 3\n"
               + "Name: Product tester\n"
               + "Employer: ACME\n"
               + "Location: Desert\n"
               + "Position Type: Quality control\n"
               + "Core Competency: Persistence\n"
               + "\n";

            Assert.AreEqual(expected, job3.ToString());
        }
    }

    
    
}

