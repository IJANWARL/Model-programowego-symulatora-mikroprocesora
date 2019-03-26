using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zad1
{
    public partial class okno2 : Form
    {
       public okno2(Symulator par)
        {
            InitializeComponent();
            this.parent = par;
        }

        private void save_b_Click(object sender, EventArgs e)
        {
            string nazwa = this.save_t.Text;

            if (File.Exists(@nazwa))
            {
                this.warning = new Warning(this);
                this.warning.ShowDialog();
            }
            else save(sender, e);
        }

        public void save(object sender, EventArgs e)
        {
            string nazwa = this.save_t.Text;
            string text = parent.komendy_t.Text;
            File.WriteAllText(@nazwa, text);
            this.Close();
        }

        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string nazwa = this.save_t.Text;

                if (File.Exists(@nazwa))
                {
                    this.warning = new Warning(this);
                    this.warning.ShowDialog();
                }
                else save(sender, e);
            }            
        }
    }
}
