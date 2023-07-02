using Microsoft.Extensions.Logging;

namespace AutoKernels
{
    public class TextBoxLogger : ILogger
    {
        private const int Capacity = 4096;
        private bool[] EnabledLogLevels;
        private TextBox textBox_;
        private List<string> logs_ = new List<string>(Capacity);

        public TextBoxLogger(TextBox textBox)
        {
            EnabledLogLevels = new bool[System.Enum.GetValues(typeof(LogLevel)).Length];
            System.Array.Fill<bool>(EnabledLogLevels, true);
            textBox_ = textBox;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => default!;

        public bool IsEnabled(LogLevel logLevel)
        {
            return EnabledLogLevels[(int)logLevel];
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (null == textBox_)
            {
                return;
            }
            if (!IsEnabled(logLevel))
            {
                return;
            }
            string log = string.Format("[{0}] {1}: {2}", logLevel.ToString(), eventId.ToString(), formatter(state, exception));
            logs_.Add(log);

            if (Capacity <= logs_.Count)
            {
                logs_.RemoveRange(0, Capacity / 2);
            }

            textBox_.Invoke(() => {
                if (Capacity <= logs_.Count)
                {
                    textBox_.Clear();
                    foreach (string l in logs_)
                    {
                        textBox_.AppendText(l);
                    }
                }
                else
                {
                    textBox_.AppendText(log);
                }
            });
        }
    }
}

