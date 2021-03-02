using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class Action
    {
        public static Result StartMethod()
        {
            Result result = new Result()
            {
                Status = true,
                Message = "Start method: Start Method()",
                Type = "Info"
            };
            return result;
        }

        public static Result SkippedLogic()
        {
            Result result = new Result()
            {
                Status = true,
                Message = "Skipped logic in method : SkippedLogic()",
                Type = "Warning",
            };
            return result;
        }

        public static Result BrokeLogic()
        {
            Result result = new Result()
            {
                Status = false,
                Message = "I broke a logic" + Environment.NewLine,
                Type = "Error"
            };
            return result;
        }
    }
}
