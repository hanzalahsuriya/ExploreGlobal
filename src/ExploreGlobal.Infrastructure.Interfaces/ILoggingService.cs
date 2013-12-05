﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploreGlobal.Infrastructure.Interfaces
{
    public interface ILoggingService
    {
        void Info(string message);

        void Warn(string message);

        void Debug(string message);

        void Error(string message);
        void Error(string message, Exception x);
        void Error(Exception x);

        void Fatal(string message);
        void Fatal(Exception x);
    }
}
