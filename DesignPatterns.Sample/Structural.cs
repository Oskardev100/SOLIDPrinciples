using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Sample.Structural
{
    namespace Adapter
    {
        namespace OOP
        {

            /// <summary>
            /// defines the domain-specific interface that Client uses.
            /// </summary>
            public class Target
            {
                public virtual void ClientRequest()
                {
                    Console.WriteLine("Default method invoked");
                }
            }

            /// <summary>
            /// Adapts the interface Adaptee to the Target interface
            /// </summary>
            public class Adapter : Target
            {
                public Adaptee _adaptee = new Adaptee();
                public override void ClientRequest()
                {
                    _adaptee.CustomRequest();
                }
            }

            /// <summary>
            /// Defines an existing interface that needs adapting.
            /// </summary>
            public class Adaptee
            {
                public void CustomRequest()
                {
                    Console.WriteLine("Custom method invoked");
                }
            }


            /// <summary>
            /// Collaborates with objects conforming to the Target interface.
            /// </summary>
            public class Client
            {
                public void DefaultMethod()
                {
                    Target targetInstance = new Target();
                    targetInstance.ClientRequest();
                }
                public void AdapterMethod()
                {
                    Target targetInstance = new Adapter();
                    targetInstance.ClientRequest();
                }

            }

        }

        namespace Real
        {

        }
    }

}
