using System;
using System.Timers;

namespace BLL.Models.Assistance_models
{
    public class Clock
    {
        private readonly Timer Timer = new Timer(1000);
        private DateTime Yesturday = DateTime.Today;

        public static event EventHandler NewDay;

        public Clock()
        {
            Timer.Elapsed += TimerElapsed;
            Timer.Start();
        }

        void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (Yesturday != DateTime.Today)
            {
                NewDay?.Invoke(this, EventArgs.Empty);
                Yesturday = DateTime.Today;
            }
        }
    }
}
