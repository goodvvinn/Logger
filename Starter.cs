using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
   public class Starter
    {
        public Logger Logger { get; set; }
        public FileService FileService { get; set; }

        public void Run()
        {
            Random random = new Random();
            Result result;
            Logger = Logger.GetInstance();
            FileService = FileService.GetInstance();

            for (int i = 0; i < 100; i++)
            {
                int value = random.Next(1, 4);
                switch (value)
                {
                    case 1:
                        result = Action.StartMethod();
                        break;
                    case 2:
                        result = Action.SkippedLogic();
                        FileService.MyStreamWriter(Logger.Report);
                        break;
                    case 3:
                        result = Action.BrokeLogic();
                        Logger.Save(result);
                        try
                        {
                            FileService.MyStreamWriter(Logger.Report);
                        }
                        catch (Exception)
                        {
                            throw new Exception("Action got this custom Exception");
                        }

                        break;
                    default:
                        result = Action.BrokeLogic();

                        Logger.Save(result);
                        FileService.MyStreamWriter(Logger.Report);
                        break;
                }

                Logger.Display(result);
            }

            FileService.MyStreamWriter(Logger.Report);
        }
    }
}
