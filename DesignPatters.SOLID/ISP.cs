using DesignPatterns.SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.ISP
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

                JuniorDev netDeveloper = new JuniorDev();
                netDeveloper.AddCientEmailAccount();

                Employee netDeveloper2 = new Employee();
                netDeveloper.AddCientEmailAccount();

                SeniorDev awsDeveloper = new SeniorDev();
                awsDeveloper.AddCientEmailAccount();

                PM javaDeveloper = new PM();
            }
        }
        public interface IOnSite
        {
            void AddCientEmailAccount();
        }
        public interface ITask
        {
            void Build();
            void Test();
            void Review();
            void Deploy();
            void DoPMStuff();
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

        public class JuniorDev : Employee, IOnSite, ITask
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

            public void AddCientEmailAccount()
            {
                //Create Client Email Account
            }

            public void Build()
            {
                throw new NotImplementedException();
            }

            public void Test()
            {
                throw new NotImplementedException();
            }

            public void Review()
            {
                throw new NotImplementedException();
            }

            public void Deploy()
            {
                throw new NotImplementedException();
            }

            public void DoPMStuff()
            {
                throw new NotImplementedException();
            }

            public JuniorDev() { }


        }
        public class SeniorDev : Employee, IOnSite, ITask
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

            public void AddCientEmailAccount()
            {
                //Create Client Email Account
            }

            public void Build()
            {
                throw new NotImplementedException();
            }

            public void Test()
            {
                throw new NotImplementedException();
            }

            public void Review()
            {
                throw new NotImplementedException();
            }

            public void Deploy()
            {
                throw new NotImplementedException();
            }

            public void DoPMStuff()
            {
                throw new NotImplementedException();
            }
        }
        public class PM : Employee, ITask
        {
            public override string Skills { get => base.Skills; set => base.Skills = value; }
            public override void AddSkills()
            {
                base.AddSkills();
            }

            public void Build()
            {
                throw new NotImplementedException();
            }

            public void Deploy()
            {
                throw new NotImplementedException();
            }

            public void DoPMStuff()
            {
                throw new NotImplementedException();
            }

            public void Review()
            {
                throw new NotImplementedException();
            }

            public override void StartProject()
            {
                base.StartProject();
            }

            public void Test()
            {
                throw new NotImplementedException();
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

                JuniorDev netDeveloper = new JuniorDev();
                netDeveloper.AddClientEmailAccount();

                //Employee netDeveloper2 = new Employee();
                //netDeveloper2.add

                SeniorDev awsDeveloper = new SeniorDev();
                awsDeveloper.AddClientEmailAccount();

                PM javaDeveloper = new PM();
            }
        }
        public interface IOnSite
        {
            void AddClientEmailAccount();
        }
        public interface ITask
        {
            void TakeVacations();
            void SubmittMyTE();
        }
        public interface IJuniorDevTask
        {
            void Build();
            void Test();
        }
        public interface ISeniorDevTask
        {
            void Review();
            void Deploy();
        }
        public interface IPMTask
        {
            void DoPMStuff();
        }

        public class Employee : Person, ITask
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

            public void TakeVacations()
            {
                throw new NotImplementedException();
            }

            public void SubmittMyTE()
            {
                throw new NotImplementedException();
            }
        }

        public class JuniorDev : Employee, IOnSite, IJuniorDevTask
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

            public void Build()
            {
                throw new NotImplementedException();
            }

            public void Test()
            {
                throw new NotImplementedException();
            }

            public JuniorDev() { }


        }
        public class SeniorDev : Employee, IOnSite, IJuniorDevTask, ISeniorDevTask
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

            public void Build()
            {
                throw new NotImplementedException();
            }

            public void Test()
            {
                throw new NotImplementedException();
            }

            public void Review()
            {
                throw new NotImplementedException();
            }

            public void Deploy()
            {
                throw new NotImplementedException();
            }
        }
        public class PM : Employee, IPMTask
        {
            public override string Skills { get => base.Skills; set => base.Skills = value; }
            public override void AddSkills()
            {
                base.AddSkills();
            }

            public void Build()
            {
                throw new NotImplementedException();
            }

            public void DoPMStuff()
            {
                throw new NotImplementedException();
            }
        }

    }
}
