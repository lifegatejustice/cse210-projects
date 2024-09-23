sing System;
using System.Reflection.Metadata;

public class Resume
        {
            public string _personName;
            public List<Job> _jobs = new List<Job>();


            public void DisplayJobDetails()
            {
                Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
            }
            
        }