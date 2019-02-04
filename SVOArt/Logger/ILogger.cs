using System;

namespace SVOArt.Logger
{
    internal interface ILogger
    {
        void LogException(Exception exception, string message);
    }
}
