using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.LSP
{
    public abstract class Person
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Skills { get; set; }
        public string Certifications { get; set; }
        public string CareerLevel { get; set; }
        #endregion

        public Person() { }
    }
    namespace Before
    {
        public class Client
        {
            public void StartProcess()
            {

                Employee netDeveloper = new DotNet();
                netDeveloper.AddClientEmailAccount();
                Employee javaDeveloper = new Java();
                javaDeveloper.AddClientEmailAccount();
            }
        }
        public class Employee : Person
        {
            #region Properties
            public virtual string Skills { get; set; }
            public virtual string Certifications { get; set; }
            public string CareerLevel { get; set; }
            #endregion

            #region Methods
            public virtual void StartProject() { }
            public void AddCertification() { }
            public virtual void AddSkills() { }
            #endregion

            public Employee() { }
            public void JoinJavaProject() { }
            public void JoinNetProject() { }
            public void JoinAWSProject() { }
            public void JoinScrumMasterProject() { }
            public virtual void AddClientEmailAccount() { }
        }

        public class DotNet : Employee
        {
            public override string Skills { get => base.Skills; set => base.Skills = value; }
            public override void AddSkills()
            {
                base.AddSkills();
            }
            public override void StartProject()
            {
                base.StartProject();
            }
            public override void AddClientEmailAccount()
            {
                base.AddClientEmailAccount(); 
            }
            public DotNet() { }

        }
        public class AWS : Employee
        {
            public override string Skills { get => base.Skills; set => base.Skills = value; }
            public override void AddSkills()
            {
                base.AddSkills();
            }
            public override void StartProject()
            {
                base.StartProject();
            }
        }
        public class Java : Employee
        {
            public override string Skills { get => base.Skills; set => base.Skills = value; }
            public override void AddSkills()
            {
                base.AddSkills();
            }
            public override void StartProject()
            {
                base.StartProject();
            }
            public override void AddClientEmailAccount()
            {
                //throw new Exception();
            }

        }
    }
    namespace Live
    {

    }
   namespace After
    {

        public class Client
        {
            public void StartProcess()
            {

                DotNet netDeveloper = new DotNet();
                netDeveloper.AddClientEmailAccount();
                

                AWS awsDeveloper = new AWS();
                awsDeveloper.AddClientEmailAccount();
                
                Java javaDeveloper = new Java();
            }
        }
        public interface IOnSite
        {
            void AddClientEmailAccount();
        }
        public class Employee : Person
        {
            #region Properties
            public virtual string Skills { get; set; }
            public virtual string Certifications { get; set; }
            public string CareerLevel { get; set; }
            #endregion

            #region Methods
            public virtual void StartProject() { }
            public void AddCertification() { }
            public virtual void AddSkills() { }
            #endregion

            public Employee() { }
            public void JoinJavaProject() { }
            public void JoinNetProject() { }
            public void JoinAWSProject() { }
            public void JoinScrumMasterProject() { }
            
        }

        public class DotNet : Employee, IOnSite
        {
            public override string Skills { get => base.Skills; set => base.Skills = value; }
            public override void AddSkills()
            {
                base.AddSkills();
            }
            public override void StartProject()
            {
                base.StartProject();
            }

            public void AddClientEmailAccount()
            {
                //Create Client Email Account
            }

            public DotNet() { }


        }
        public class AWS : Employee, IOnSite
        {
            public override string Skills { get => base.Skills; set => base.Skills = value; }
            public override void AddSkills()
            {
                base.AddSkills();
            }
            public override void StartProject()
            {
                base.StartProject();
            }

            public void AddClientEmailAccount()
            {
                //Create Client Email Account
            }
        }
        public class Java : Employee
        {
            public override string Skills { get => base.Skills; set => base.Skills = value; }
            public override void AddSkills()
            {
                base.AddSkills();
            }
            public override void StartProject()
            {
                base.StartProject();
            }
        }

    }
}
