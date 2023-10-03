
using System.Data;
using System.Xml.Linq;

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
            //why does job not have .value append?
            Assert.AreEqual(job3.Name, "Product tester");
            Assert.AreEqual(job3.EmployerName.Value, "ACME");
            Assert.AreEqual(job3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job3.JobType.Value, "Quality control");
            Assert.AreEqual(job3.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3 == job4);
        }


        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));
            Assert.IsTrue(job4.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job4.ToString().EndsWith(Environment.NewLine));

        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.AreEqual(
                job3.ToString(),
                $"{Environment.NewLine}Id: {job3.Id}{Environment.NewLine}" +
                $"{Environment.NewLine}Name: Product tester{Environment.NewLine}" +
                $"{Environment.NewLine}Employer: ACME{Environment.NewLine}" +
                $"{Environment.NewLine}Location: Desert{Environment.NewLine}" +
                $"{Environment.NewLine}Position Type: Quality control{Environment.NewLine}" +
                $"{Environment.NewLine}Core Competency: Persistence{Environment.NewLine}"
                
            );
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Assert.AreEqual(
                job3.ToString(),
                $"{Environment.NewLine}Id: {job3.Id}{Environment.NewLine}" +
                $"{Environment.NewLine}Name: {job3.Name}{Environment.NewLine}" +
                $"{Environment.NewLine}Employer: {job3.EmployerName}{Environment.NewLine}" +
                $"{Environment.NewLine}Location: {job3.EmployerLocation}{Environment.NewLine}" +
                $"{Environment.NewLine}Position Type: {job3.JobType}{Environment.NewLine}" +
                $"{Environment.NewLine}Core Competency: {job3.JobCoreCompetency}{Environment.NewLine}" 
               
            );
        }
            //[TestMethod]
            //public void TestMethod()
            //{
            //    //TODO: Task 4: remove this method before you create your first test method 
            //}
        }
}

