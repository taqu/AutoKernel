using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;
using System.Runtime.Versioning;

namespace AutoKernels
{
    [UnsupportedOSPlatform("browser")]
    [ProviderAlias("TextViewLoggerProvider")]
    public class TextBoxLoggerProvider : ILoggerProvider
    {
        private readonly ConcurrentDictionary<string, TextBoxLogger> loggers_ = new(StringComparer.OrdinalIgnoreCase);
        private TextBox textBox_;
        private bool disposed_ = false;
        public TextBoxLoggerProvider(TextBox textBox)
        {
            textBox_ = textBox;
        }

        ~TextBoxLoggerProvider()
        {
            Dispose(false);
        }

        public ILogger CreateLogger(string categoryName) => loggers_.GetOrAdd(categoryName, name => new TextBoxLogger(textBox_));

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

