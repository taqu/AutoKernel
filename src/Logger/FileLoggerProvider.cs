using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;
using System.Runtime.Versioning;

namespace AutoKernels
{
    [UnsupportedOSPlatform("browser")]
    [ProviderAlias("FileLoggerProvider")]
    public class FileLoggerProvider : ILoggerProvider
    {
        private readonly ConcurrentDictionary<string, FileLogger> loggers_ = new(StringComparer.OrdinalIgnoreCase);
        private bool disposed_ = false;
        public FileLoggerProvider()
        {
        }

        ~FileLoggerProvider()
        {
            Dispose(false);
        }

        public ILogger CreateLogger(string categoryName) => loggers_.GetOrAdd(categoryName, name => new FileLogger());

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed_)
            {
                return;
            }
            if (disposing)
            {
                loggers_.Clear();
            }
            disposed_ = true;
        }
    }
}

