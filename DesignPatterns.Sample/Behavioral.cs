using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Sample.Behavioral
{
    namespace ChainOfResposibility
    {
        namespace OOP
        {
            public abstract class Handler
            {

                protected Handler successor;
                public void SetSuccessor(Handler _succesor)
                {
                    this.successor = _succesor;
                }
                public abstract void HandleRequest(int request);

                //Virtual Methods vs Abstract Methods?
            }
            public class ConcreteHandler1 : Handler
            {
                public override void HandleRequest(int request)
                {
                    if (request >= 0 && request < 10)
                    {
                        Console.WriteLine("{0} handled request {1}",
                          this.GetType().Name, request);
                    }
                    else if (successor != null)
                    {
                        successor.HandleRequest(request);
                    }
                }
            }
            public class ConcreteHandler2 : Handler
            {
                public override void HandleRequest(int request)
                {
                    if (request >= 10 && request < 20)
                    {
                        Console.WriteLine("{0} handled request {1}",
                          this.GetType().Name, request);
                    }
                    else if (successor != null)
                    {
                        successor.HandleRequest(request);
                    }
                }
            }

            public class Client
            {
                public void StartChainOfResp()
                {
                    Handler h1 = new ConcreteHandler1();
                    Handler h2 = new ConcreteHandler2();
                    h1.SetSuccessor(h2);

                    // Generate and process request
                    int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

                    foreach (int request in requests)
                    {
                        h1.HandleRequest(request);
                    }
                }

            }


        }
        namespace Real
        {
        }
    }
}
