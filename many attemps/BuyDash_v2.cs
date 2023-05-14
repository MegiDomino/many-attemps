using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace many_attemps
{
    public partial class BuyDash_v2 : UserControl
    {
        public BuyDash_v2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            foreach (Control control in parentForm.Controls)
            {
                if (control is BuyDash_v1 || control is BuyDash_v2)
                {
                    parentForm.Controls.Remove(control);
                    control.Dispose();
                }
            }

        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Download Successfully");

        }
    }
}
