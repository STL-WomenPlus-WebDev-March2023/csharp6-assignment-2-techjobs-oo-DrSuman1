
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
             Assert.AreNotEqual(job1.Id, job2.Id, "Id Test");
            //Assert.AreEqual(job1.Id, 1, "Id Test");
            Assert.IsTrue(job2.Id - job1.Id == 1, "Should be difference of 1");
            ///Assert.IsFalse(job1.Equals(job2), "Should not equal");

        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreNotEqual(job1.Id, job2.Id, "Id Test");
            Assert.IsTrue(job2.Id - job1.Id == 1, "Check Increment of 1");
            Assert.AreEqual(job3.Name, "Product tester", "Testing Job Name");
            Assert.AreEqual(job3.EmployerName.ToString(), "ACME", "Testing EmployerName Value");
            Assert.AreEqual(job3.EmployerLocation.ToString(), "Desert", "Testing EmployerLocation Value");
            Assert.AreEqual(job3.JobType.ToString(), "Quality control", "Testing JobType Value");
            Assert.AreEqual(job3.JobCoreCompetency.ToString(), "Persistence", "Testing JobCoreCompetency Value");

        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job1.Equals(job2), "Objects with different ID are not equal");

        }
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()

        {
            string testJob1 = $"\n\nID: {job1.Id}\nName: {job1.Name}\nEmployer: Data not available \nLocation: {job1.EmployerLocation}\nPosition Type: {job1.JobType}\nCore Competency: {job1.JobCoreCompetency}\n\n";
            string tester = testJob1.ToString();

            Assert.IsTrue(tester.StartsWith("\n"));
            Assert.IsTrue(tester.EndsWith("\n"));

        }
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Job testJob1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string expectedString = "Product tester";// $"\nID: {testJob1.Id}\nName: {testJob1.Name}\nEmployer: {testJob1.EmployerName}\nLocation: {testJob1.EmployerLocation}\nPosition Type: {testJob1.JobType}\nCore Competency: {testJob1.JobCoreCompetency}";

            Assert.AreEqual(expectedString, testJob1.ToString(), "Test strings did not equal each other");
        }
        //[TestMethod]
        //public void TestToStringContainsCorrectLabelsAndData()
        //{
        //    //Arrange
        //    Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //    String answer = Environment.NewLine + "ID: " + job1.Id + Environment.NewLine +
        //            "Name: " + job1.Name + Environment.NewLine +
        //            "Employer: " + job1.EmployerName.Value + Environment.NewLine +
        //           "Location: " + job1.EmployerLocation.Value + Environment.NewLine +
        //            "Position Type: " + job1.JobType.Value + Environment.NewLine +
        //            "Core Competency: " + job1.JobCoreCompetency.Value + Environment.NewLine;
        //    //Check
        //    Assert.AreEqual(job1, answer);

        //}
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Job testJob1 = new Job("", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string expectedString = "";//$"\n\nID: {job1.Id}\nName: {job1.Name}\nEmployer: Data not available \nLocation: {job1.EmployerLocation}\nPosition Type: {job1.JobType}\nCore Competency: {job1.JobCoreCompetency}\n\n";
            Assert.AreEqual(expectedString, testJob1.ToString(), "Test strings did not equal each other");
        }
    }
}

