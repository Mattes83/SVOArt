using System;
using System.ComponentModel.Composition;

namespace SVOArt.Logger
{
    [Export(typeof(ILogger))]
    internal class Logger : ILogger
    {
        private readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        public void LogException(Exception exception, string message)
        {
            _logger.Error(exception, message);
        }
    }
}
