using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel.Planning;

namespace AutoKernels
{
    public class Context
    {
        private static Context? instance_;

        private ILogger? logger_;
        private Config? config_;
        private Agent? agent_;
        private Plan? plan_;

        private Context(TextBox textBox)
        {
            ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddProvider(new FileLoggerProvider());
                builder.AddProvider(new TextBoxLoggerProvider(textBox));
            });
            logger_ = loggerFactory.CreateLogger<Main>();

            string path = System.IO.Directory.GetCurrentDirectory();
            path = System.IO.Path.Combine(path, Config.FileName);
            config_ = Config.load(path);
            agent_ = new Agent(config_, logger_);
        }

        public static Context Instance { get { return instance_; } }
        public static ILogger Logger { get { return instance_.logger_; } }
        public static Config Config { get { return instance_.config_; } }

        public static Agent Agent { get { return instance_.agent_; } }

        public static void Initialize(TextBox textBox)
        {
            instance_ = new Context(textBox);
        }
        public static void Terminate()
        {
            instance_ = null;
        }

        public Plan Plan { get; set; }
    }
}
