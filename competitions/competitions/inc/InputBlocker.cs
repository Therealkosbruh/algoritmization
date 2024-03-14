using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace competitions.inc
{
    static class InputBlocker
    {
        [DllImport("user32.dll")]
        static extern bool BlockInput(bool fBlockIt);
        private static Timer timer = new Timer();

        static InputBlocker()
        {
            timer.Tick += new EventHandler(timer_Tick);
        }

        public static void BlockInput(int ms)
        {
            BlockInput(true);
            timer.Interval = ms;
            timer.Start();
        }

        private static void timer_Tick(object sender, EventArgs e)
        {
            BlockInput(false);
            timer.Stop();
        }
    }
}
