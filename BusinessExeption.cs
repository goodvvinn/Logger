﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class BusinessExeption : Exception
    {
        public BusinessExeption(string message)
            : base(message)
        {
        }
    }
}
