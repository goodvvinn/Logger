using System;
using System.IO;

namespace Logger
{
    public class Logger
    {
        private static Logger instance;

        // private string _report;
        protected Logger()
        {
            Report = string.Empty;
        }

        public string Report { get; set; }
        public void Save(Result result)
        {
            string message = "Action failed by a reason : " + result.Message;
            Report += DateTime.Now.ToString("h:mm:ss\t") + result.Message;
        }

        public void Display(Result result)
        {
            string time = DateTime.Now.ToString("h:mm:ss");
            string message = time + ":\t" + result.Type + ":\t\t" + result.Message;
            Console.WriteLine(message);
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }
    }
}
