﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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
        public  string EmptyString(string value)
        {
            string newValue;

            if (value == "" || value == null)
            {
                newValue = "Data not available";
                //Console.WriteLine("Empty: " + newValue);
            }
            else
            {
                newValue =  value;
            }
            return newValue;
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




        public override string ToString()
        {
            if ( Name == "" && EmployerName.Value == "" && EmployerLocation.Value == "" && JobType.Value == "" && JobCoreCompetency.Value == "")
                return "OOPS! This job does not seem to exist.";

            return $"\nId: {Id}\nName: {EmptyString(Name)}\nEmployer: {EmptyString(EmployerName.Value)}\nLocation: {EmptyString(EmployerLocation.Value)}\nPosition Type: {EmptyString(JobType.Value)}\nCore Competency: {EmptyString(JobCoreCompetency.Value)}\n";

            //return $"\nId: {Id} {result}\n\nId: {Id}\nName: {Name}\nEmployer: {EmployerName}\nLocation: {EmployerLocation}\nPosition Type: {JobType}\nCore Competency: {JobCoreCompetency}\n";
        }


    }
}
