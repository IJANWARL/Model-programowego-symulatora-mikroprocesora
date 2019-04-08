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
    public partial class okno3 : Form
    {
        public okno3(Symulator par)
        {
            InitializeComponent();
            this.parent = par;
        }

        private void open_b_Click(object sender, EventArgs e)
        {
            string nazwa = this.open_t.Text;

            if (File.Exists(@nazwa))
            {
                string temp = File.ReadAllText(@nazwa);
                parent.komendy_t.Text = temp;
                parent.sumator_komend = File.ReadLines(@nazwa).Count();
                parent.iterator_komend = 0;
                this.Close();
            }
            else
            {
                MessageBox.Show("Plik o podanej nazwie nie istnieje!!!");
            }
        }

        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string nazwa = this.open_t.Text;

                if (File.Exists(@nazwa))
                {
                    string temp = File.ReadAllText(@nazwa);
                    parent.komendy_t.Text = temp;
                    parent.sumator_komend = File.ReadLines(@nazwa).Count();
                    parent.iterator_komend = 0;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Plik o podanej nazie nie istnieje.");
                }
            }
        }
    }
}
