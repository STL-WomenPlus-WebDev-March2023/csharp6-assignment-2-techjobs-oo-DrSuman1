﻿using System;
using System.Numerics;
using System.Xml.Linq;

namespace TechJobsOOAutoGraded6
{
    public class RunTechJobs
    {
        public void RunProgram()
        {
            //TODO: Task 4: Remove this line to uncomment the RunProgram method once you complete the Job class

                Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
                Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
                Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));

                List<Job> jobs = new List<Job>();
                    jobs.Add(job1);
                    jobs.Add(job2);
                    jobs.Add(job3);

                foreach (Job job in jobs)
                {
                //Console.WriteLine(job);
                Console.WriteLine("ID: " + job.Id);
                Console.WriteLine("Name: " + job.Name);
                Console.WriteLine("Employer: " + job.EmployerName);
                Console.WriteLine("Location: " + job.EmployerLocation);
                Console.WriteLine("Position Type: " + job.JobType);
                Console.WriteLine("Core Competency: " + job.JobCoreCompetency + Environment.NewLine);
            }

           // TODO: Task 4: Remove this line to uncomment the RunProgram method once you complete the Job class */

        }
    }
}

