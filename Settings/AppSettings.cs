using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AshmawyX
{
    public class AppSettings
    {
        public bool DelayEnabled { get; set; } = true;
        public double MinDelay { get; set; } = 0.2;
        public double MaxDelay { get; set; } = 0.8;

        public List<Keys> BlockedKeys { get; set; } = new List<Keys>();

        public AppSettings Clone()
        {
            return new AppSettings
            {
                DelayEnabled = this.DelayEnabled,
                MinDelay = this.MinDelay,
                MaxDelay = this.MaxDelay,
                BlockedKeys = this.BlockedKeys.ToList()
            };
        }
    }
}
