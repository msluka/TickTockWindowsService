using System;
using System.Timers;
using System.IO;

namespace TickTockWindowsService
{
    public class TickTock
    {
        private readonly Timer _timer;
        public string _file;

        public TickTock()
        {
            System.IO.Directory.CreateDirectory("D:/Temp");
            _file = "D:/Temp/TickTock.txt";

            if (!File.Exists(_file))
            {
                File.Create(_file).Close();
                /*If we will not close the file after creating it, 
                  it cannot be used immediately to write something 
                  here and we get the exception that it cannot be accessed 
                  because it is being used by another process*/
            }

            // Timer interval is seeting up here
            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Our code goes here START

            string[] lines = new string[] { DateTime.Now.ToString() };
            File.AppendAllLines(_file, lines);

            // ur code goes here END
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }
    }
}
