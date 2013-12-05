using ExploreGlobal.Infrastructure.Interfaces;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Core;
namespace ExploreGlobal.Infrastructure.Logging
{
    public class Log4NetLoggerService : ILoggingService
    {
        private ILog _logger;

        public Log4NetLoggerService()
        {
            _logger = LogManager.GetLogger(this.GetType());
            log4net.Config.XmlConfigurator.Configure(); 
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(string message, Exception x)
        {
            _logger.Error(message, x);
        }

        public void Error(Exception x)
        {
            _logger.Error(x);
        }

        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        public void Fatal(Exception x)
        {
            _logger.Fatal(x);
        }
    }
}
