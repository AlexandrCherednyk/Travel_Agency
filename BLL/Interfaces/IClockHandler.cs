using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    interface IClockHandler
    {
        // Также нужно подписаться на событие "NewDay" класса Clock.
        public abstract void OnNewDay(object sender, EventArgs e);
    }
}
