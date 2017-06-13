
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



            #region Design Patterns

            //Factory

            //Abstract Factory

            //Singleton
            DesignPatterns.Sample.Creational.Singleton.OOP.Client singletonClient = new Sample.Creational.Singleton.OOP.Client();
            singletonClient.RunSingleton();
            singletonClient.DestroyFirst();

            //Adapter
            DesignPatterns.Sample.Structural.Adapter.OOP.Client client1 = new Sample.Structural.Adapter.OOP.Client();
            DesignPatterns.Sample.Structural.Adapter.OOP.Client client2 = new Sample.Structural.Adapter.OOP.Client();
            client1.DefaultMethod();
            client2.AdapterMethod();

            //Chain Of Responsability
            DesignPatterns.Sample.Behavioral.ChainOfResposibility.OOP.Client chain1 = new Sample.Behavioral.ChainOfResposibility.OOP.Client();
            chain1.StartChainOfResp();
            

            #endregion

            Console.ReadLine();
        }        
    }
}
