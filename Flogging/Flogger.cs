using Flogging.Core;
using Serilog;
using Serilog.Events;
using System;
using System.Configuration;

namespace Flogging
{
    public static class Flogger
    {
        private static readonly ILogger _perfLogger;
        private static readonly ILogger _usageLogger;
        private static readonly ILogger _errorLogger;
        private static readonly ILogger _diagnosticLogger;

        static Flogger()
        {
            _perfLogger = new LoggerConfiguration()
                .WriteTo.File("C:\\Users\\Meet  Kerasiya\\source\\repos\\Flogging\\Source\\perf.txt")
                .CreateLogger();
            _usageLogger = new LoggerConfiguration()
                .WriteTo.File("C:\\Users\\Meet  Kerasiya\\source\\repos\\Flogging\\Source\\usage.txt")
                .CreateLogger();
            _errorLogger = new LoggerConfiguration()
                .WriteTo.File("C:\\Users\\Meet  Kerasiya\\source\\repos\\Flogging\\Source\\error.txt")
                .CreateLogger();
            _diagnosticLogger = new LoggerConfiguration()
                .WriteTo.File("C:\\Users\\Meet  Kerasiya\\source\\repos\\Flogging\\Source\\diagnostic.txt")
                .CreateLogger();


        }

        public static void WritePerf(FlogDetail infoToLog)
        {
            _perfLogger.Write(LogEventLevel.Information, "{@FlogDetail}", infoToLog);

        }
        public static void WriteUsage(FlogDetail infoToLog)
        {
            _usageLogger.Write(LogEventLevel.Information, "{@FlogDetail}", infoToLog);

        }
        public static void WriteError(FlogDetail infoToLog)
        {
            _errorLogger.Write(LogEventLevel.Information, "{@FlogDetail}", infoToLog);

        }
        public static void WriteDiagnostic(FlogDetail infoToLog)
        {
            var writeDiagnostic = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableDiagnostics"]);
            if (!writeDiagnostic)
            {
                return;
            }
            _diagnosticLogger.Write(LogEventLevel.Information, "{@FlogDetail}", infoToLog);

        }

    }
}
