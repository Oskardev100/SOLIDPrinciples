using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.OCP
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
    }

    namespace Before
    {
        public class Employee : Person
        {
            #region Properties
            public string Skills { get; set; }
            public string Certifications { get; set; }
            public string CareerLevel { get; set; }
            #endregion

            #region Methods
            public void StartProject() { }
            public void AddCertification() { }
            public void AddSkills() { }



            public void JoinJavaProject() { }
            public void JoinNetProject() { }
            public void JoinAWSProject() { }
            public void JoinScrumMasterProject() { }
            #endregion
        }
    }

    


    namespace After
    {
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

            public void JoinJavaProject() { }
            public void JoinNetProject() { }
            public void JoinAWSProject() { }
            public void JoinScrumMasterProject() { }
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

        }
    }
}
