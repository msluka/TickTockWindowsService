using System;
using Topshelf;

namespace TickTockWindowsService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {
                 x.Service<TickTock>(s =>
                 {
                     s.ConstructUsing(ticktock => new TickTock());
                     s.WhenStarted(ticktock => ticktock.Start());
                     s.WhenStopped(ticktock => ticktock.Stop());
                 });

                 x.RunAsLocalSystem();
                 x.SetServiceName("TickTockService");
                 x.SetDisplayName("Tick Tock Service");
                 x.SetDescription("This service is created by Me: The Clock Is Ticking - Tick Tock");

             });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
        }
    }
}
