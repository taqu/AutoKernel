using Microsoft.Extensions.Logging;

namespace AutoKernels
{
    public class FileLogger : ILogger, IDisposable
    {
        public const int FlushCycle = 32;
        public const string FileName = "log.txt";
        private bool[] EnabledLogLevels;
        private FileStream? file_;
        private StreamWriter? writer_;
        private bool disposed_ = false;
        private List<string> logs_ = new List<string>(FlushCycle);

        public FileLogger()
        {
            EnabledLogLevels = new bool[System.Enum.GetValues(typeof(LogLevel)).Length];
            System.Array.Fill<bool>(EnabledLogLevels, true);
            try
            {
                file_ = new FileStream(FileName, FileMode.OpenOrCreate);
                writer_ = new StreamWriter(file_);
            }
            catch
            {
            }
        }

        ~FileLogger()
        {
            Dispose(false);
        }

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
                if (null != file_)
                {
                    Flush();
                    file_.Dispose();
                    file_ = null;
                    writer_ = null;
                }
            }
            disposed_ = true;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => default!;

        public bool IsEnabled(LogLevel logLevel)
        {
            return EnabledLogLevels[(int)logLevel];
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (null == file_)
            {
                return;
            }
            if (!IsEnabled(logLevel))
            {
                return;
            }
            string log = string.Format("[{0}] {1}: {2}", logLevel.ToString(), eventId.ToString(), formatter(state, exception));
            logs_.Add(log);
            if (FlushCycle <= logs_.Count)
            {
                Flush();
            }
        }

        public void Flush()
        {
            if (null == writer_ || logs_.Count <= 0)
            {
                return;
            }
            foreach(string log in logs_)
            {
                writer_.WriteLine(log);
            }
            writer_.Flush();
            logs_.Clear();
        }
    }
}

