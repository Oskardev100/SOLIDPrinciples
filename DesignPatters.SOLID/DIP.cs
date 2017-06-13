using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.DIP
{
    namespace Scenario1
    {
        public class Client
        {
            ExceptionLogger _Logger;

            public Client()
            {
                _Logger = new ExceptionLogger();
            }
            public void RunProgram()
            {
                try
                {
                    throw new System.Exception();
                }
                catch (DataException ex)
                {
                    _Logger.LogExceptionToDB(ex.Message);
                }
                catch (Exception ex)
                {
                    _Logger.LogExceptionToFile(ex.Message);
                }
            }
        }

        public class ExceptionLogger
        {
            FileLogger _FileLogger;
            DBLogger _DBLogger;

            public ExceptionLogger()
            {
                _FileLogger = new FileLogger();
                _DBLogger = new DBLogger();
            }
            public void LogExceptionToFile(string ExMessage)
            {
                _FileLogger.WriteToFile(string.Format("{0} - Exception. {1}", DateTime.Now, ExMessage));
            }
            public void LogExceptionToDB(string ExMessaage)
            {
                _DBLogger.WriteToDB(ExMessaage);
            }
        }

        public class FileLogger
        {
            public void WriteToFile(string text)
            {
                Console.WriteLine(text);
            }
        }
        public class DBLogger
        {
            public void WriteToDB(string text)
            {
                Console.WriteLine(text);
            }
        }
    }
    namespace Scenario2
    {
        public class Client
        {
            FileLogger _FileLogger;
            DBLogger _DBLogger;
            public Client()
            {
                _FileLogger = new FileLogger();
                _DBLogger = new DBLogger();
            }
            public void RunProgram()
            {
                try
                {
                    throw new System.Data.DataException();
                    throw new System.Exception();
                }
                catch (System.Data.DataException ex)
                {
                    _DBLogger.WriteException(ex.Message);// .LogExceptionToFile(ex);
                }
                catch (Exception ex)
                {
                    _FileLogger.WriteException(ex.Message);
                }
            }
        }

        public interface ILoger
        {
            void WriteException(string message);
        }
        public class FileLogger : ILoger
        {
            public void WriteException(string message)
            {
                Console.WriteLine(string.Format("{0} - Exception. {1}", DateTime.Now, message));
            }
        }
        public class DBLogger : ILoger
        {
            public void WriteException(string message)
            {
                Console.WriteLine(string.Format("{0} - Exception. {1}", DateTime.Now, message));
            }
        }

    }
    namespace Scenario3
    {
        public class Client
        {
            FileLogger _FileLogger;
            DBLogger _DBLogger;
            EventViewerLogger _EventViewerLogger;

            public Client()
            {
                _FileLogger = new FileLogger();
                _DBLogger = new DBLogger();
                _EventViewerLogger = new EventViewerLogger();
            }
            public void RunProgram()
            {
                try
                {
                    throw new System.Data.DataException();
                    throw new System.Exception();
                }
                catch (System.IO.IOException ex)
                {
                    _DBLogger.WriteException(ex.Message);
                }
                catch (System.Data.DataException ex)
                {
                    _FileLogger.WriteException(ex.Message);
                }
                catch (Exception ex)
                {
                    _EventViewerLogger.WriteException(ex.Message);
                }
            }
        }
        public class ExceptionLogger
        {
            FileLogger _FileLogger;
            DBLogger _DBLogger;
            EventViewerLogger _EventViewerLogger;

            public ExceptionLogger()
            {
                _FileLogger = new FileLogger();
                _DBLogger = new DBLogger();
                _EventViewerLogger = new EventViewerLogger();
            }
            public void LogExceptionToFile(string ExMessage)
            {
                _FileLogger.WriteException(string.Format("{0} - Exception. {1}", DateTime.Now, ExMessage));
            }
            public void LogExceptionToDB(string ExMessage)
            {
                _DBLogger.WriteException(string.Format("{0} - Exception. {1}", DateTime.Now, ExMessage));
            }
            public void LogExceptionToEventViewer(string ExMessage)
            {
                _EventViewerLogger.WriteException(string.Format("{0} - Exception. {1}", DateTime.Now, ExMessage));
            }
        }

        public interface ILoger
        {
            void WriteException(string message);
        }
        public class FileLogger : ILoger
        {
            public void WriteException(string message)
            {
                Console.WriteLine(string.Format("{0} - Exception. {1}", DateTime.Now, message));
            }
        }
        public class DBLogger : ILoger
        {
            public void WriteException(string message)
            {
                Console.WriteLine(string.Format("{0} - Exception. {1}", DateTime.Now, message));
            }
        }
        public class EventViewerLogger : ILoger
        {
            public void WriteException(string message)
            {
                Console.WriteLine(string.Format("{0} - Exception. {1}", DateTime.Now, message));
            }
        }
    }
}
