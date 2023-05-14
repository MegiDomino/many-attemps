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
    public partial class BuyDash_v1 : UserControl
    {
        public BuyDash_v1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuyDash_v2 buyDash_v2 = new BuyDash_v2();
            buyDash_v2.Dock = DockStyle.Fill;
            this.Controls.Add(buyDash_v2);
            buyDash_v2.BringToFront();
        }

        private void buyDash_v21_Load(object sender, EventArgs e)
        {
            
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}
