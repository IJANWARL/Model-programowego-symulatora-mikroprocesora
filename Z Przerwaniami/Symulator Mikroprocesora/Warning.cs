using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad1
{
    public partial class Warning : Form
    {
        public Warning(okno2 par)
        {
            InitializeComponent();
            this.parent = par;
        }

        private void back_b_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continue_b_Click(object sender, EventArgs e)
        {
            parent.save(sender, e);
            this.Close();
        }
    }
}
