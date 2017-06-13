using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.SRP
{
    namespace Before
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public void Work() { }
            public void Eat() { }
            public void Sleep() { }
            public void Excercise() { }
            public void StartProject() { }
            public void AddCertification() { }
            public void AddSkills() { }
            public void CreateInvoide() { }
            public void SendInvoide() { }
        }
    }

    namespace Live
    {

    }

    
    namespace After
    {
        //Consumer class
        public class Client
        {
            public void SendPersonToProject()
            {
                Employee peter = new Employee();
                peter.FirstName = "peter";
                peter.LastName = "godinez";

                Project myProject = new Project();
                myProject.StartDate = DateTime.Now;
                myProject.Team.Add(peter);
            }
        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Skills { get; set; }
            public string Certifications { get; set; }
            public string CareerLevel { get; set; }
        }
        public class Employee : Person
        {
            public string Skills { get; set; }
            public string Certifications { get; set; }
            public string CareerLevel { get; set; }

            public void StartProject() { }
            public void AddCertification() { }
            public void AddSkills() { }
        }
        public class Project
        {
            public string Client { get; set; }
            public List<Employee> Team { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }


            public void StartProject() { }

        }
        public class Invoice
        {
            public string Client { get; set; }
            public double Amount { get; set; }
            public string WBS { get; set; }
            public string Contract { get; set; }


            public void CreateInvoide() { }
            public void SendInvoide() { }
        }
    }
    
}
