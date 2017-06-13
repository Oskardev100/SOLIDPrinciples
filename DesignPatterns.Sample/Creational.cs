using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns.Sample.Creational
{
    namespace Factory
    {
        namespace OOP
        {
            public class Client
            {
            }

            #region Product
            public abstract class Product
            {
            }
            public class ConcreteProductA : Product
            {
            }
            public class ConcreteProductB : Product
            {
            }
            #endregion

            #region Creator
            public abstract class Creator
            {
                public abstract Product FactoryMethod();
            }
            public class ConcreteCreatorA : Creator
            {
                public override Product FactoryMethod()
                {
                    throw new NotImplementedException();
                }
            }
            public class ConcreteCreatorB : Creator
            {
                public override Product FactoryMethod()
                {
                    throw new NotImplementedException();
                }
            }
            #endregion
        }
        namespace Real
        {

        }
    }

    namespace AbstractFactory
    {
        namespace OOP
        {
            public class Client
            {
                public AbstractProductA _abstractProductA;
                public AbstractProductB _abstractProductB;

                //Constructor
                public Client(AbstractFactory factory)
                {
                    _abstractProductA = factory.CreateProductA();
                    _abstractProductB = factory.CreateProductB();
                }
            }

            #region Factory
            #region Abstract Factory
            public abstract class AbstractFactory
            {
                public abstract AbstractProductA CreateProductA();
                public abstract AbstractProductB CreateProductB();
            }
            #endregion

            #region ConcreteFactory
            public class ConcreteFactory1 : AbstractFactory
            {
                public override AbstractProductA CreateProductA()
                {
                    throw new NotImplementedException();
                }

                public override AbstractProductB CreateProductB()
                {
                    throw new NotImplementedException();
                }
            }
            public class ConcreteFactory2 : AbstractFactory
            {
                public override AbstractProductA CreateProductA()
                {
                    throw new NotImplementedException();
                }

                public override AbstractProductB CreateProductB()
                {
                    throw new NotImplementedException();
                }
            }
            #endregion

            #endregion

            #region Product
            #region Abstract Products
            public abstract class AbstractProductA { }
            public abstract class AbstractProductB { }
            #endregion

            #region Concrete Products
            public class ProductA1 : AbstractProductA { }
            public class ProductB1 : AbstractProductB { }

            public class ProductA2 : AbstractProductA { }
            public class ProductB2 : AbstractProductB { }
            #endregion
            #endregion
        }
    }

    namespace Singleton
    {
        namespace OOP
        {
            public class Client
            {
                public void RunSingleton()
                {
                    Singleton s1 = Singleton.Intance();
                    Singleton s2 = Singleton.Intance();

                    if (s1 == s2)
                    {
                        s2 = Singleton.Intance();
                    }
                }

                public void DestroyFirst()
                {
                    Singleton2 s1 = Singleton2.Intance();
                    Singleton2 s2 = Singleton2.Intance();

                    if (s1 == s2)
                    {
                        s1.Dispose();
                        s2 = Singleton2.Intance();
                        if (s1 == s2)
                        {

                        }
                    }
                }
            }

            public class Singleton
            {
                private static Singleton _instance;

                protected Singleton()
                {
                }

                public static Singleton Intance()
                {
                    if (_instance == null)
                        _instance = new Singleton();
                    return _instance;
                }
            }
            public class Singleton2 : IDisposable
            {
                public bool disposed = false;
                private static Singleton2 _instance;

                protected Singleton2()
                {
                }

                public static Singleton2 Intance()
                {
                    if (_instance == null)
                        _instance = new Singleton2();
                    _instance.disposed = false;
                    return _instance;
                }

                public void Dispose()
                {
                    Dispose(true);
                    GC.SuppressFinalize(this);
                }
                protected virtual void Dispose(bool disposing)
                {
                    //Release object
                    disposed = true;
                    _instance = null;
                }

                //Destructor
                ~Singleton2()
                {
                    Dispose(true);
                }
            }
        }
    }
}