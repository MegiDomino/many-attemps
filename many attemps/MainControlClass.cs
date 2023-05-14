using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace many_attemps
{
    internal class MainControlClass
    {
        public static void showControl(System.Windows.Forms.Control control, System.Windows.Forms.Control ConFrm1)
        {
            ConFrm1.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            ConFrm1.Controls.Add(control);
        }

    }
}
