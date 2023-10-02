
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        //initalize your testing objects here

        //Testing objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {
            //instructions say to use AreEqual, but they will not be equal?
            // Assert.AreEqual();

            //check that the difference between job ids is equal to 1
            Assert.AreEqual(job2.Id - job1.Id, 1);
            //job1 and job2 should not have equal values
            Assert.IsTrue(job1 != job2);
            //job1 and job2 should not have equal values
            Assert.IsFalse(job1 == job2);

        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(job3.Name, "Product tester");
            Assert.AreEqual(job3.EmployerName.Value, "ACME");
            Assert.AreEqual(job3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job3.JobType.Value, "Quality Control");
            Assert.AreEqual(job3.JobCoreCompetency, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3 == job4);
        }
        [TestMethod]


        //[TestMethod]
        //public void TestMethod()
        //{
        //    //TODO: Task 4: remove this method before you create your first test method 
        //}
    }
}

