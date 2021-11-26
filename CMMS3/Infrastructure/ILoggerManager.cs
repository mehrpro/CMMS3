using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMMS3.Infrastructure
{
    public interface ILoggerManager
    {

        void LogInfo(string message);
        void LogDebug(string message);
        void LogError(string message);
        void LogWarn(string message);


    }

    public class LoggerManager : ILoggerManager
    {
        private static ILogger _logger = LogManager.GetCurrentClassLogger();
        public LoggerManager()
        {

        }

        public void LogInfo(string message)
        {
            _logger.Info(message);
        }

        public void LogDebug(string message)
        {
            _logger.Debug(message);
        }

        public void LogError(string message)
        {
            _logger.Error(message);
        }

        public void LogWarn(string message)
        {
            _logger.Warn(message);
        }
    }
}
