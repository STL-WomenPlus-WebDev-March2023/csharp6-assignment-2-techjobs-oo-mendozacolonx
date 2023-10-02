using System;
namespace TechJobsOOAutoGraded6
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

            // TODO: Task 3: Add the two necessary constructors.
            
        //this constuructor will set the id to hte nextID property and then increment it by 1
            public Job()
            {
                Id = nextId;
                nextId++;
            }

            //this contructor extends the first job constructor
            public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
            {
                Name = name;
                EmployerName = employerName;
                EmployerLocation = employerLocation;
                JobType = jobType;
                JobCoreCompetency = jobCoreCompetency;
            }

            public override bool Equals(object? obj)
            {
                return obj is Job job &&
                       Id == job.Id;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Id);
            }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  



        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            if ( Name == null)
            {
                Name = "Data not available";
            }

            return 
                $"{Environment.NewLine}Id: {Id}{Environment.NewLine}" +
                $"{Environment.NewLine}Name: {Name}{Environment.NewLine}" +
                $"{Environment.NewLine}Employer: {EmployerName}{Environment.NewLine}" +
                $"{Environment.NewLine}Location: {EmployerLocation}{Environment.NewLine}" +
                $"{Environment.NewLine}Position Type: {JobType}{Environment.NewLine}" +
                $"{Environment.NewLine}Core Competency: {JobCoreCompetency}{Environment.NewLine}" 
                ;
        }


    }
}

