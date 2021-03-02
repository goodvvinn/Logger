using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logger
{
    public class FileService : IFileService
    {
        private LoggerConfig _loggerConfig = new LoggerConfig();
        private static FileService instance;
        public FileService()
        {
        }

        public void MyStreamWriter(string log)
        {
            try
            {
                using (StreamWriter sr = new StreamWriter("logs.txt", false, Encoding.Default))
                {
                    sr.WriteLine(log);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static FileService GetInstance()
        {
            if (instance == null)
            {
                instance = new FileService();
            }

            return instance;
        }
    }
}
