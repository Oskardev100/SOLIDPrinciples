
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Client
{
    class Program
    {
        static void Main(string[] args)
        {

           DesignPatterns.SOLID.LSP.After.Client lsp = new SOLID.LSP.After.Client();
            // DesignPatterns.SOLID.LSP.Before.Client lsp = new SOLID.LSP.Before.Client();


            DesignPatterns.SOLID.DIP.Scenario1.Client DipClient = new SOLID.DIP.Scenario1.Client();
            DipClient.RunProgram();

            DesignPatterns.SOLID.DIP.Scenario2.Client DipClient2 = new SOLID.DIP.Scenario2.Client();
            DipClient2.RunProgram();

            DesignPatterns.SOLID.DIP.Scenario3.Client DipClient3 = new SOLID.DIP.Scenario3.Client();
            DipClient3.RunProgram();
            Console.ReadLine();
        }


        /*OLD CODE
                private static void DoScenario0()
                {
                    Solid.Scenario0.Person p1 = new Solid.Scenario0.Person("John01", "Smith01");
                    p1.Eat();
                    p1.DoWork();
                    p1.Sleep();
                }
                private static void DoScenario1()
                {
                    //Do BA
                    Solid.Scenario1.Person ba = new Solid.Scenario1.Person("John BA", "Smith");
                    ba.GetRequirements();

                    //Build solution 
                    Solid.Scenario1.Person dev = new Solid.Scenario1.Person("John Dev", "Smith");
                    dev.BuildSolution();

                    //Test
                    Solid.Scenario1.Person tst = new Solid.Scenario1.Person("John Tst", "Smith");
                    tst.BuildSolution();

                    //Release
                    Solid.Scenario1.Person rm = new Solid.Scenario1.Person("John RM", "Smith");
                    rm.ReleaseSolution();

                    //Support
                    Solid.Scenario1.Person sup = new Solid.Scenario1.Person("John Sup", "Smith");
                    sup.SupportSolution();
                }
                private static void DO_SRP()
                {
                    Solid.SRP.Person ba = new Solid.SRP.BA("John", "Smith");
                    ba.NotifyNewPerson();

                    Solid.SRP.Person dev = new Solid.SRP.BA("John", "Smith");
                    dev.NotifyNewPerson();

                    Solid.SRP.Person tst = new Solid.SRP.BA("John", "Smith");
                    tst.NotifyNewPerson();

                    Solid.SRP.Person rm = new Solid.SRP.BA("John", "Smith");
                    rm.NotifyNewPerson();
                }

                private static void DO_OCP()
                {
                    Console.WriteLine("\n*** Before Open Closed Principle ***");
                    Solid.OCP.Previous.Person p = new Solid.OCP.Previous.Person("John", "Smith");
                    p.EngineerRole = Solid.OCP.Previous.Person.EngineerRoleOptions.Developer;
                    p.DoWork();

                    Console.WriteLine("*** After Open Closed Principle ***");
                    Solid.OCP.After.Person dev = new Solid.OCP.After.Dev("John", "Smith");
                    dev.DoWork();
                }
                private static void DO_LSP()
                {

                    Console.WriteLine("*** Liskov Substituion Principle ***");
                    Solid.LSP.After.Person dev = new Solid.LSP.After.Dev("John", "Smith");

                }

        */
    }
}
