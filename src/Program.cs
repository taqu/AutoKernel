using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System.Runtime.InteropServices;

namespace AutoKernels
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}