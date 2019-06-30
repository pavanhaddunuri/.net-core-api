using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Logger
{
    interface ILoggerManager
    {
        void LogInfo(string message);
        void LogError(string message);
        void LogWarn(string message);
        void LogDebug(string message);
    }
}
