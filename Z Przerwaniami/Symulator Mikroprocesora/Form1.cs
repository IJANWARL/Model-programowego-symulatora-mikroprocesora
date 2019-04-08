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
    public partial class Symulator : Form
    {

        public Symulator()
        {
            InitializeComponent();
            init();
        }

        private void wartosc_CheckedChanged(object sender, EventArgs e)
        {
            if (this.wartosc_rb.Checked == true)
            {
                this.wartosc_p.Visible = true;
            }
            else
            {
                this.wartosc_p.Visible = false;
            }

        }

        private void przerwanie_CheckedChanged(object sender, EventArgs e)
        {
            if (this.przerwanie_ch.Checked == true)
            {
                this.przerwanie_p.Visible = true;
                this.zaczekaj_t.Visible = true;
            }
            else
            {
                this.przerwanie_p.Visible = false;
                this.zaczekaj_t.Visible = false;
            }

        }

        private void init()
        {
            this.stos.AH = new bool[8];
            this.stos.AL = new bool[8];
            this.stos.BH = new bool[8];
            this.stos.BL = new bool[8];
            this.stos.CH = new bool[8];
            this.stos.CL = new bool[8];
            this.stos.DH = new bool[8];
            this.stos.DL = new bool[8];
            this.ah_tab = new System.Windows.Forms.Button[8];
            this.al_tab = new System.Windows.Forms.Button[8];
            this.bh_tab = new System.Windows.Forms.Button[8];
            this.bl_tab = new System.Windows.Forms.Button[8];
            this.ch_tab = new System.Windows.Forms.Button[8];
            this.cl_tab = new System.Windows.Forms.Button[8];
            this.dh_tab = new System.Windows.Forms.Button[8];
            this.dl_tab = new System.Windows.Forms.Button[8];
            ax = new rejestr();
            bx = new rejestr();
            cx = new rejestr();
            dx = new rejestr();
            ah_tab[0] = this.ah1;
            ah_tab[1] = this.ah2;
            ah_tab[2] = this.ah3;
            ah_tab[3] = this.ah4;
            ah_tab[4] = this.ah5;
            ah_tab[5] = this.ah6;
            ah_tab[6] = this.ah7;
            ah_tab[7] = this.ah8;
            al_tab[0] = this.al1;
            al_tab[1] = this.al2;
            al_tab[2] = this.al3;
            al_tab[3] = this.al4;
            al_tab[4] = this.al5;
            al_tab[5] = this.al6;
            al_tab[6] = this.al7;
            al_tab[7] = this.al8;
            bh_tab[0] = this.bh1;
            bh_tab[1] = this.bh2;
            bh_tab[2] = this.bh3;
            bh_tab[3] = this.bh4;
            bh_tab[4] = this.bh5;
            bh_tab[5] = this.bh6;
            bh_tab[6] = this.bh7;
            bh_tab[7] = this.bh8;
            bl_tab[0] = this.bl1;
            bl_tab[1] = this.bl2;
            bl_tab[2] = this.bl3;
            bl_tab[3] = this.bl4;
            bl_tab[4] = this.bl5;
            bl_tab[5] = this.bl6;
            bl_tab[6] = this.bl7;
            bl_tab[7] = this.bl8;
            ch_tab[0] = this.ch1;
            ch_tab[1] = this.ch2;
            ch_tab[2] = this.ch3;
            ch_tab[3] = this.ch4;
            ch_tab[4] = this.ch5;
            ch_tab[5] = this.ch6;
            ch_tab[6] = this.ch7;
            ch_tab[7] = this.ch8;
            cl_tab[0] = this.cl1;
            cl_tab[1] = this.cl2;
            cl_tab[2] = this.cl3;
            cl_tab[3] = this.cl4;
            cl_tab[4] = this.cl5;
            cl_tab[5] = this.cl6;
            cl_tab[6] = this.cl7;
            cl_tab[7] = this.cl8;
            dh_tab[0] = this.dh1;
            dh_tab[1] = this.dh2;
            dh_tab[2] = this.dh3;
            dh_tab[3] = this.dh4;
            dh_tab[4] = this.dh5;
            dh_tab[5] = this.dh6;
            dh_tab[6] = this.dh7;
            dh_tab[7] = this.dh8;
            dl_tab[0] = this.dl1;
            dl_tab[1] = this.dl2;
            dl_tab[2] = this.dl3;
            dl_tab[3] = this.dl4;
            dl_tab[4] = this.dl5;
            dl_tab[5] = this.dl6;
            dl_tab[6] = this.dl7;
            dl_tab[7] = this.dl8;
            ax.tab_h = ah_tab;
            ax.tab_l = al_tab;
            ax.dec_h = a_dec_h_t;
            ax.hex_h = a_hex_h_t;
            ax.dec_l = a_dec_l_t;
            ax.hex_l = a_hex_l_t;
            ax.cal_d = a_dec_x_t;
            ax.cal_h = a_hex_x_t;
            bx.tab_h = bh_tab;
            bx.tab_l = bl_tab;
            bx.dec_h = b_dec_h_t;
            bx.hex_h = b_hex_h_t;
            bx.dec_l = b_dec_l_t;
            bx.hex_l = b_hex_l_t;
            bx.cal_d = b_dec_x_t;
            bx.cal_h = b_hex_x_t;
            cx.tab_h = ch_tab;
            cx.tab_l = cl_tab;
            cx.dec_h = c_dec_h_t;
            cx.hex_h = c_hex_h_t;
            cx.dec_l = c_dec_l_t;
            cx.hex_l = c_hex_l_t;
            cx.cal_d = c_dec_x_t;
            cx.cal_h = c_hex_x_t;
            dx.tab_h = dh_tab;
            dx.tab_l = dl_tab;
            dx.dec_h = d_dec_h_t;
            dx.hex_h = d_hex_h_t;
            dx.dec_l = d_dec_l_t;
            dx.hex_l = d_hex_l_t;
            dx.cal_d = d_dec_x_t;
            dx.cal_h = d_hex_x_t;
        }

        private void al_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (przycisk.Text == "1") przycisk.Text = "0";
            else przycisk.Text = "1";

            int suma = 0;

            int pot = 1;

            for (int i = 0; i < 8; i++)
            {
                if (al_tab[i].Text == "1") suma += pot;
                pot *= 2;
            }

            this.a_dec_l_t.Text = suma.ToString();
            int sum = suma + 256 * Int32.Parse(a_dec_h_t.Text);
            this.a_dec_x_t.Text = sum.ToString();
            this.a_hex_l_t.Text = "0x" + suma.ToString("X");
            this.a_hex_x_t.Text = "0x" + sum.ToString("X");
        }

        private void ah_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (przycisk.Text == "1") przycisk.Text = "0";
            else przycisk.Text = "1";

            int suma = 0;

            int pot = 1;

            for (int i = 0; i < 8; i++)
            {
                if (ah_tab[i].Text == "1") suma += pot;
                pot *= 2;
            }

            this.a_dec_h_t.Text = suma.ToString();
            int temp = Int32.Parse(a_dec_l_t.Text);
            int sum = suma * 256 + temp;
            this.a_dec_x_t.Text = sum.ToString();
            this.a_hex_h_t.Text = "0x" + suma.ToString("X");
            this.a_hex_x_t.Text = "0x" + sum.ToString("X");

        }

        private void bl_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (przycisk.Text == "1") przycisk.Text = "0";
            else przycisk.Text = "1";


            int suma = 0;

            int pot = 1;

            for (int i = 0; i < 8; i++)
            {
                if (bl_tab[i].Text == "1") suma += pot;
                pot *= 2;
            }

            this.b_dec_l_t.Text = suma.ToString();
            int temp = Int32.Parse(b_dec_h_t.Text);
            int sum = suma + 256 * temp;
            this.b_dec_x_t.Text = sum.ToString();
            this.b_hex_l_t.Text = "0x" + suma.ToString("X");
            this.b_hex_x_t.Text = "0x" + sum.ToString("X");
        }

        private void bh_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (przycisk.Text == "1") przycisk.Text = "0";
            else przycisk.Text = "1";

            int suma = 0;

            int pot = 1;

            for (int i = 0; i < 8; i++)
            {
                if (bh_tab[i].Text == "1") suma += pot;
                pot *= 2;
            }

            this.b_dec_h_t.Text = suma.ToString();
            int temp = Int32.Parse(b_dec_l_t.Text);
            int sum = suma * 256 + temp;
            this.b_dec_x_t.Text = sum.ToString();
            this.b_hex_h_t.Text = "0x" + suma.ToString("X");
            this.b_hex_x_t.Text = "0x" + sum.ToString("X");

        }

        private void cl_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (przycisk.Text == "1") przycisk.Text = "0";
            else przycisk.Text = "1";


            int suma = 0;

            int pot = 1;

            for (int i = 0; i < 8; i++)
            {
                if (cl_tab[i].Text == "1") suma += pot;
                pot *= 2;
            }

            this.c_dec_l_t.Text = suma.ToString();
            int temp = Int32.Parse(c_dec_h_t.Text);
            int sum = suma + 256 * temp;
            this.c_dec_x_t.Text = sum.ToString();
            this.c_hex_l_t.Text = "0x" + suma.ToString("X");
            this.c_hex_x_t.Text = "0x" + sum.ToString("X");

        }

        private void ch_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (przycisk.Text == "1") przycisk.Text = "0";
            else przycisk.Text = "1";

            int suma = 0;

            int pot = 1;

            for (int i = 0; i < 8; i++)
            {
                if (ch_tab[i].Text == "1") suma += pot;
                pot *= 2;
            }

            this.c_dec_h_t.Text = suma.ToString();
            int temp = Int32.Parse(c_dec_l_t.Text);
            int sum = suma * 256 + temp;
            this.c_dec_x_t.Text = sum.ToString();
            this.c_hex_h_t.Text = "0x" + suma.ToString("X");
            this.c_hex_x_t.Text = "0x" + sum.ToString("X");

        }

        private void dl_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (przycisk.Text == "1") przycisk.Text = "0";
            else przycisk.Text = "1";


            int suma = 0;

            int pot = 1;

            for (int i = 0; i < 8; i++)
            {
                if (dl_tab[i].Text == "1") suma += pot;
                pot *= 2;
            }

            this.d_dec_l_t.Text = suma.ToString();
            int temp = Int32.Parse(d_dec_h_t.Text);
            int sum = suma + 256 * temp;
            this.d_dec_x_t.Text = sum.ToString();
            this.d_hex_l_t.Text = "0x" + suma.ToString("X");
            this.d_hex_x_t.Text = "0x" + sum.ToString("X");
        }

        private void dh_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (przycisk.Text == "1") przycisk.Text = "0";
            else przycisk.Text = "1";

            int suma = 0;

            int pot = 1;

            for (int i = 0; i < 8; i++)
            {
                if (dh_tab[i].Text == "1") suma += pot;
                pot *= 2;
            }

            this.d_dec_h_t.Text = suma.ToString();
            int temp = Int32.Parse(d_dec_l_t.Text);
            int sum = suma * 256 + temp;
            this.d_dec_x_t.Text = sum.ToString();
            this.d_hex_h_t.Text = "0x" + suma.ToString("X");
            this.d_hex_x_t.Text = "0x" + sum.ToString("X");
        }

        private void reset_ah(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                ah_tab[i].Text = "0";
            }

            this.a_dec_h_t.Text = "0";
            this.a_hex_h_t.Text = "0x0";
            this.a_dec_x_t.Text = this.a_dec_l_t.Text;
            this.a_hex_x_t.Text = this.a_hex_l_t.Text;
        }

        private void reset_al(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                al_tab[i].Text = "0";
            }

            this.a_dec_l_t.Text = "0";
            this.a_hex_l_t.Text = "0x0";
            int temp = Int32.Parse(this.a_dec_h_t.Text);
            temp = temp * 256;
            this.a_dec_x_t.Text = temp.ToString();
            this.a_hex_x_t.Text = "0x" + temp.ToString("X");
        }

        private void reset_bh(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                bh_tab[i].Text = "0";
            }

            this.b_dec_h_t.Text = "0";
            this.b_hex_h_t.Text = "0x0";
            this.b_dec_x_t.Text = this.b_dec_l_t.Text;
            this.b_hex_x_t.Text = this.b_hex_l_t.Text;
        }

        private void reset_bl(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                bl_tab[i].Text = "0";
            }

            this.b_dec_l_t.Text = "0";
            this.b_hex_l_t.Text = "0x0";
            int temp = Int32.Parse(this.b_dec_h_t.Text);
            temp = temp * 256;
            this.b_dec_x_t.Text = temp.ToString();
            this.b_hex_x_t.Text = "0x" + temp.ToString("X");
        }

        private void reset_ch(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                ch_tab[i].Text = "0";
            }

            this.c_dec_h_t.Text = "0";
            this.c_hex_h_t.Text = "0x0";
            this.c_dec_x_t.Text = this.c_dec_l_t.Text;
            this.c_hex_x_t.Text = this.c_hex_l_t.Text;
        }

        private void reset_cl(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                cl_tab[i].Text = "0";
            }

            this.c_dec_l_t.Text = "0";
            this.c_hex_l_t.Text = "0x0";
            int temp = Int32.Parse(this.c_dec_h_t.Text);
            temp = temp * 256;
            this.c_dec_x_t.Text = temp.ToString();
            this.c_hex_x_t.Text = "0x" + temp.ToString("X");
        }

        private void reset_dh(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                dh_tab[i].Text = "0";
            }

            this.d_dec_h_t.Text = "0";
            this.d_hex_h_t.Text = "0x0";
            this.d_dec_x_t.Text = this.d_dec_l_t.Text;
            this.d_hex_x_t.Text = this.d_hex_l_t.Text;
        }

        private void reset_dl(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                dl_tab[i].Text = "0";
            }

            this.d_dec_l_t.Text = "0";
            this.d_hex_l_t.Text = "0x0";
            int temp = Int32.Parse(this.d_dec_h_t.Text);
            temp = temp * 256;
            this.d_dec_x_t.Text = temp.ToString();
            this.d_hex_x_t.Text = "0x" + temp.ToString("X");
        }

        private void dodawanie_kom(object sender, EventArgs e)
        {
            string pol = "";
            string wart = "";
            string dok = "";


            if (this.mov_rb.Checked) pol = "MOV";
            else if (this.add_rb.Checked) pol = "ADD";
            else pol = "SUB";

            if (this.ah_d_rb.Checked) dok = "AH";
            else if (this.al_d_rb.Checked) dok = "AL";
            else if (this.bh_d_rb.Checked) dok = "BH";
            else if (this.bl_d_rb.Checked) dok = "BL";
            else if (this.ch_d_rb.Checked) dok = "CH";
            else if (this.cl_d_rb.Checked) dok = "CL";
            else if (this.dh_d_rb.Checked) dok = "DH";
            else dok = "DL";


            if (this.ah_rb.Checked) wart = "AH";
            else if (this.al_rb.Checked) wart = "AL";
            else if (this.bh_rb.Checked) wart = "BH";
            else if (this.bl_rb.Checked) wart = "BL";
            else if (this.ch_rb.Checked) wart = "CH";
            else if (this.cl_rb.Checked) wart = "CL";
            else if (this.dh_rb.Checked) wart = "DH";
            else if (this.dl_rb.Checked) wart = "DL";
            else
            {
                if (this.wartosc_rb.Checked == false)
                {

                    dod_kom(sender, e, pol, wart, dok);
                }
                else
                {
                    if (this.decymalnie_rb.Checked)
                    {
                        int temp = Int32.Parse(this.wartosc_t.Text);
                        wart = "0x" + temp.ToString("X");
                    }
                    else if (this.wartosc_t.Text.Length < 3)
                    {
                        wart = "0x" + this.wartosc_t.Text;
                    }
                    else
                    {
                        wart = this.wartosc_t.Text;
                    }
                }
            }
            dod_kom(sender, e, pol, wart, dok);
        }

        private void dod_kom(object sender, EventArgs e, string pol, string skad, string dokad)
        {
            this.sumator_komend++;
            this.komendy_t.AppendText(sumator_komend.ToString() + ":   " + skad + " - " + pol + " - " + dokad);
            this.komendy_t.AppendText(Environment.NewLine);
        }

        private void plik_zapis_b_Click(object sender, EventArgs e)
        {
            this.okno2 = new okno2(this);
            this.okno2.ShowDialog();
        }

        private void reset_kom_b_Click(object sender, EventArgs e)
        {
            this.komendy_t.Text = "";
            this.sumator_komend = 0;
            this.iterator_komend = 0;
            this.przes = 0;
        }

        private void plik_odczyt_b_Click(object sender, EventArgs e)
        {
            this.okno3 = new okno3(this);
            this.okno3.ShowDialog();
        }

        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dodawanie_kom(sender, e);
            }
        }

        private void wykonaj_b_Click(object sender, EventArgs e)
        {
            int pol = 0;
            int wart = 0;
            rejestr rej;
            bool ktory;




            if (this.mov_rb.Checked) pol = 1;
            else if (this.add_rb.Checked) pol = 2;
            else pol = 3;



            if (this.ah_rb.Checked) wart = Int32.Parse(this.a_dec_h_t.Text);
            else if (this.al_rb.Checked) wart = Int32.Parse(this.a_dec_l_t.Text);
            else if (this.bh_rb.Checked) wart = Int32.Parse(this.b_dec_h_t.Text);
            else if (this.bl_rb.Checked) wart = Int32.Parse(this.b_dec_l_t.Text);
            else if (this.ch_rb.Checked) wart = Int32.Parse(this.c_dec_h_t.Text);
            else if (this.cl_rb.Checked) wart = Int32.Parse(this.c_dec_l_t.Text);
            else if (this.dh_rb.Checked) wart = Int32.Parse(this.d_dec_h_t.Text);
            else if (this.dl_rb.Checked) wart = Int32.Parse(this.d_dec_l_t.Text);



            if (this.ah_d_rb.Checked)
            {
                rej = ax;
                ktory = true;
            }
            else if (this.al_d_rb.Checked)
            {
                rej = ax;
                ktory = false;
            }
            else if (this.bh_d_rb.Checked)
            {
                rej = bx;
                ktory = true;
            }
            else if (this.bl_d_rb.Checked)
            {
                rej = bx;
                ktory = false;
            }
            else if (this.ch_d_rb.Checked)
            {
                rej = cx;
                ktory = true;
            }
            else if (this.cl_d_rb.Checked)
            {
                rej = cx;
                ktory = false;
            }
            else if (this.dh_d_rb.Checked)
            {
                rej = dx;
                ktory = true;
            }
            else
            {
                rej = dx;
                ktory = false;
            }





            if (!this.wartosc_rb.Checked)
            {
                wyk_kom(pol, wart, rej, ktory);
            }
            else
            {
                if (this.decymalnie_rb.Checked)
                {
                    wart = Int32.Parse(this.wartosc_t.Text);
                    wyk_kom(pol, wart, rej, ktory);
                }
                else
                {
                    string temp = this.wartosc_t.Text;

                    if (temp.Length < 3)
                    {
                        wart = int.Parse(temp, System.Globalization.NumberStyles.HexNumber);
                    }
                    else if (temp.Substring(0, 2) == "0x")
                    {
                        wart = Convert.ToInt32(temp, 16);
                    }
                    else wart = int.Parse(temp, System.Globalization.NumberStyles.HexNumber);

                    wyk_kom(pol, wart, rej, ktory);
                }
            }
        }

        private void kom_read(object sender, EventArgs e)
        {
            string temp = this.komendy_t.Text;
            File.WriteAllText(@"temp", temp);
            string[] temp_tab = File.ReadAllLines(@"temp");
            string wartS = "", polS = "", dokS = "";
            int wart = 0, pol = 0;
            bool ktory;
            rejestr rej;
            if (iterator_komend >= 9) przes = 1;
            else if (iterator_komend >= 99) przes = 2;
            else if (iterator_komend >= 999) przes = 3;
            else if (iterator_komend >= 9999) przes = 4;


            if (iterator_komend < sumator_komend)
            {
                if (temp_tab[iterator_komend].Length == 18 + przes)
                {
                    wartS = temp_tab[iterator_komend].Substring(5 + przes, 2);
                    polS = temp_tab[iterator_komend].Substring(10 + przes, 3);
                    dokS = temp_tab[iterator_komend].Substring(16 + przes, 2);

                    if (wartS == "AH")
                    {
                        wart = Int32.Parse(ax.dec_h.Text);
                    }
                    else if (wartS == "AL")
                    {
                        wart = Int32.Parse(ax.dec_l.Text);
                    }
                    else if (wartS == "BH")
                    {
                        wart = Int32.Parse(bx.dec_h.Text);
                    }
                    else if (wartS == "BL")
                    {
                        wart = Int32.Parse(bx.dec_l.Text);
                    }
                    else if (wartS == "CH")
                    {
                        wart = Int32.Parse(cx.dec_h.Text);
                    }
                    else if (wartS == "CL")
                    {
                        wart = Int32.Parse(cx.dec_l.Text);
                    }
                    else if (wartS == "DH")
                    {
                        wart = Int32.Parse(dx.dec_h.Text);
                    }
                    else
                    {
                        wart = Int32.Parse(dx.dec_l.Text);
                    }

                }
                else if (temp_tab[iterator_komend].Length == 19 + przes)
                {
                    wartS = temp_tab[iterator_komend].Substring(7 + przes, 1);
                    polS = temp_tab[iterator_komend].Substring(11 + przes, 3);
                    dokS = temp_tab[iterator_komend].Substring(17 + przes, 2);
                    wart = int.Parse(wartS, System.Globalization.NumberStyles.HexNumber);
                }
                else if (temp_tab[iterator_komend].Length == 20 + przes)
                {
                    wartS = temp_tab[iterator_komend].Substring(7 + przes, 2);
                    polS = temp_tab[iterator_komend].Substring(12 + przes, 3);
                    dokS = temp_tab[iterator_komend].Substring(18 + przes, 2);
                    wart = int.Parse(wartS, System.Globalization.NumberStyles.HexNumber);
                }

                //this.test.Text = polS;

                if (dokS == "AH")
                {
                    rej = ax;
                    ktory = true;
                }
                else if (dokS == "AL")
                {
                    rej = ax;
                    ktory = false;
                }
                else if (dokS == "BH")
                {
                    rej = bx;
                    ktory = true;
                }
                else if (dokS == "BL")
                {
                    rej = bx;
                    ktory = false;
                }
                else if (dokS == "CH")
                {
                    rej = cx;
                    ktory = true;
                }
                else if (dokS == "CL")
                {
                    rej = cx;
                    ktory = false;
                }
                else if (dokS == "DH")
                {
                    rej = dx;
                    ktory = true;
                }
                else
                {
                    rej = dx;
                    ktory = false;
                }

                if (polS == "MOV") pol = 1;
                else if (polS == "ADD") pol = 2;
                else pol = 3;

                temp_tab[iterator_komend] += "   wykonana";
                iterator_komend++;
                File.WriteAllLines(@"temp", temp_tab);
                this.komendy_t.Text = File.ReadAllText(@"temp");
                wyk_kom(pol, wart, rej, ktory);
            }

        }

        private void wyk_kom(int pol, int wartosc, rejestr rej, bool ktory)
        {
            if (pol == 1)
            {
                if (ktory)
                {
                    rej.dec_h.Text = wartosc.ToString();
                    rej.hex_h.Text = "0x" + wartosc.ToString("X");
                }
                else
                {
                    rej.dec_l.Text = wartosc.ToString();
                    rej.hex_l.Text = "0x" + wartosc.ToString("X");
                }
                change(rej, ktory, wartosc);
            }
            else if (pol == 2)
            {
                int sum;
                if (ktory)
                {
                    sum = wartosc + Int32.Parse(rej.dec_h.Text);
                    if (sum > 255) sum -= 255;
                    rej.dec_h.Text = sum.ToString();
                    rej.hex_h.Text = "0x" + sum.ToString("X");
                }
                else
                {
                    sum = wartosc + Int32.Parse(rej.dec_l.Text);
                    if (sum > 255) sum -= 255;
                    rej.dec_l.Text = sum.ToString();
                    rej.hex_l.Text = "0x" + sum.ToString("X");
                }
                change(rej, ktory, sum);
            }
            else
            {
                int sum;
                if (ktory)
                {
                    sum = Int32.Parse(rej.dec_h.Text) - wartosc;
                    if (sum < 0) sum = -sum;
                    rej.dec_h.Text = sum.ToString();
                    rej.hex_h.Text = "0x" + sum.ToString("X");
                }
                else
                {
                    sum = Int32.Parse(rej.dec_l.Text) - wartosc;
                    if (sum < 0) sum = -sum;
                    rej.dec_l.Text = sum.ToString();
                    rej.hex_l.Text = "0x" + sum.ToString("X");
                }
                change(rej, ktory, sum);
            }
            int temp = (Int32.Parse(rej.dec_l.Text) + 256 * Int32.Parse(rej.dec_h.Text));
            rej.cal_d.Text = temp.ToString();
            rej.cal_h.Text = "0x" + temp.ToString("X");
        }

        private void change(rejestr rej, bool ktory, int wart)
        {
            if (ktory)
            {
                string binary = Convert.ToString(wart, 2);
                int x = 8 - binary.Length;
                for (int i = 0; i < x; i++)
                {
                    binary = "0" + binary;
                }

                for (int i = 0; i < 8; i++)
                {
                    rej.tab_h[7 - i].Text = binary.Substring(i, 1);
                }

            }
            else
            {
                string binary = Convert.ToString(wart, 2);
                int x = 8 - binary.Length;
                for (int i = 0; i < x; i++)
                {
                    binary = "0" + binary;
                }

                for (int i = 0; i < 8; i++)
                {
                    rej.tab_l[7 - i].Text = binary.Substring(i, 1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void caly_b_Click(object sender, EventArgs e)
        {
            if (sec_rb.Checked) timer.Interval = 500;
            else if (sec1_rb.Checked) timer.Interval = 1000;
            else if (sec3_rb.Checked) timer.Interval = 3000;
            else timer.Interval = 5000;
            zatrzask = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (zatrzask)
            {
                kom_read(sender, e);
            }

            if (iterator_komend == sumator_komend) zatrzask = false;
        }

        private void play_b_Click(object sender, EventArgs e)
        {
            if (iterator_komend < sumator_komend) zatrzask = true;
        }

        private void pause_b_Click(object sender, EventArgs e)
        {
            zatrzask = false;
        }

        private void time_change(object sender, EventArgs e)
        {
            if (sec_rb.Checked) timer.Interval = 500;
            else if (sec1_rb.Checked) timer.Interval = 1000;
            else if (sec3_rb.Checked) timer.Interval = 3000;
            else timer.Interval = 5000;
        }

        private void ScreenShoot(PictureBox picture)
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            Graphics screenshot = Graphics.FromImage(bmp);
            screenshot.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            picture.BackgroundImage = bmp;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (przerwanie_ch.Checked == true)
            {
                znak = e.KeyChar;
                klawisz = true;
                przerwanie_Click(sender, e);
            }            
        }

        private void przerwanie_Click(object sender, EventArgs e)
        {
            timer.Stop();
            zapis_stos();

            if(klawisz && !(odczytaj_znak_rb.Checked) && !(spr_czy_nac_rb.Checked))
            {
                wyk_kom(1, 21, ax, true);
                wyk_kom(1, 79, ax, false);
                wyk_kom(1, 0, bx, true);
                wyk_kom(1, 0, bx, false);
                wyk_kom(1, 0, cx, true);
                wyk_kom(1, 0, cx, false);
                wyk_kom(1, 0, dx, true);
                wyk_kom(1, 0, dx, false);
                
            }
            else if (odczytaj_znak_rb.Checked)
            {
                zaczekajB = true;
                zatrzask_tim.Start();
            }
            else if (spr_czy_nac_rb.Checked)
            {
                if(klawisz)
                {
                    wyk_kom(1, 22, ax, true);
                    wyk_kom(1, 1, ax, false);
                    wyk_kom(1, znak, bx, true);
                    wyk_kom(1, 0, bx, false);
                    wyk_kom(1, 0, cx, true);
                    wyk_kom(1, 0, cx, false);
                    wyk_kom(1, 0, dx, true);
                    wyk_kom(1, 0, dx, false);
                    klawisz = false;
                }
                else
                {
                    wyk_kom(1, 22, ax, true);
                    wyk_kom(1, 1, ax, false);
                    wyk_kom(1, 0, bx, true);
                    wyk_kom(1, 0, bx, false);
                    wyk_kom(1, 0, cx, true);
                    wyk_kom(1, 0, cx, false);
                    wyk_kom(1, 0, dx, true);
                    wyk_kom(1, 1, dx, false);
                }
                
            }
            else if (screen_shot_rb.Checked)
            {
                ScreenShoot(picture);
                

                wyk_kom(1, 5, ax, true);
                wyk_kom(1, 0, ax, false);
                wyk_kom(1, 0, bx, true);
                wyk_kom(1, 0, bx, false);
                wyk_kom(1, 0, cx, true);
                wyk_kom(1, 0, cx, false);
                wyk_kom(1, 0, dx, true);
                wyk_kom(1, 0, dx, false);
            }
            else if (ustaw_godz_rb.Checked)
            {
                time = tim.ToString("HH:mm");
                godzina_t.Text = time;
               

                wyk_kom(1, 26, ax, true);
                wyk_kom(1, 3, ax, false);
                wyk_kom(1, 0, bx, true);
                wyk_kom(1, 0, bx, false);
                wyk_kom(1, 0, cx, true);
                wyk_kom(1, 0, cx, false);
                wyk_kom(1, 0, dx, true);
                wyk_kom(1, 0, dx, false);
            }
            else if (pobierz_godz_rb.Checked)
            {
                int godziny, minuty;
                string time = godzina_t.Text;
                godziny = Int32.Parse(time.Substring(0, 2));
                minuty = Int32.Parse(time.Substring(3, 2));
               

                wyk_kom(1, 26, ax, true);
                wyk_kom(1, 2, ax, false);
                wyk_kom(1, godziny, bx, true);
                wyk_kom(1, minuty, bx, false);
                wyk_kom(1, 0, cx, true);
                wyk_kom(1, 0, cx, false);
                wyk_kom(1, 0, dx, true);
                wyk_kom(1, 0, dx, false);
            }
            else if (ustaw_dat_rb.Checked)
            {
                time = tim.ToString("dd MM yyyy");
                data_t.Text = time;
                

                wyk_kom(1, 26, ax, true);
                wyk_kom(1, 5, ax, false);
                wyk_kom(1, 0, bx, true);
                wyk_kom(1, 0, bx, false);
                wyk_kom(1, 0, cx, true);
                wyk_kom(1, 0, cx, false);
                wyk_kom(1, 0, dx, true);
                wyk_kom(1, 0, dx, false);
            }
            else if (pobierz_dat_rb.Checked)
            {
                int dzien, miesioc, rok1, rok2;
                string time = data_t.Text;
                dzien = Int32.Parse(time.Substring(0, 2));
                miesioc = Int32.Parse(time.Substring(3, 2));
                rok1 = Int32.Parse(time.Substring(6, 2));
                rok2 = Int32.Parse(time.Substring(8, 2));
               

                wyk_kom(1, 26, ax, true);
                wyk_kom(1, 2, ax, false);
                wyk_kom(1, dzien, bx, true);
                wyk_kom(1, miesioc, bx, false);
                wyk_kom(1, rok1, cx, true);
                wyk_kom(1, rok2, cx, false);
                wyk_kom(1, 0, dx, true);
                wyk_kom(1, 0, dx, false);
            }
            else if (stan_klawiatury_rb.Checked)
            {                
                int num = 0, scrol = 0, caps = 0, insert = 0;
                if (Control.IsKeyLocked(Keys.NumLock)) num = 1;
                if (Control.IsKeyLocked(Keys.Scroll)) scrol = 1;
                if (Control.IsKeyLocked(Keys.CapsLock)) caps = 1;
                if (Control.IsKeyLocked(Keys.Insert)) insert = 1;


                wyk_kom(1, 22, ax, true);
                wyk_kom(1, 2, ax, false);
                wyk_kom(1, num, bx, true);
                wyk_kom(1, scrol, bx, false);
                wyk_kom(1, caps, cx, true);
                wyk_kom(1, insert, cx, false);
                wyk_kom(1, 0, dx, true);
                wyk_kom(1, 0, dx, false);
            }
            else if (zaczekaj_rb.Checked)
            {
                zaczekajB = true;
                
                wyk_kom(1, 21, ax, true);
                wyk_kom(1, 134, ax, false);
                wyk_kom(1, 0, bx, true);
                wyk_kom(1, 0, bx, false);
                wyk_kom(1, 0, cx, true);
                wyk_kom(1, 0, cx, false);
                wyk_kom(1, 0, dx, true);
                wyk_kom(1, 0, dx, false);
                zaczekaj_t.Text = zacz5.ToString();
                zaczekaj5.Start();
                zaczekaj.Start();
            }
            


                if (!zaczekajB)
            {
                timer_przer.Start();
                klawisz = false;
            }

            //System.Threading.Thread.Sleep(50000);

        }

        private void zapis_stos()
        {
            for(int i = 0; i < 8; i++)
            {
                if (ah_tab[i].Text == "1") stos.AH[i] = true;
                else stos.AH[i] = false;
            }
            for (int i = 0; i < 8; i++)
            {
                if (al_tab[i].Text == "1") stos.AL[i] = true;
                else stos.AL[i] = false;
            }
            for (int i = 0; i < 8; i++)
            {
                if (bh_tab[i].Text == "1") stos.BH[i] = true;
                else stos.BH[i] = false;
            }
            for (int i = 0; i < 8; i++)
            {
                if (bl_tab[i].Text == "1") stos.BL[i] = true;
                else stos.BL[i] = false;
            }
            for (int i = 0; i < 8; i++)
            {
                if (ch_tab[i].Text == "1") stos.CH[i] = true;
                else stos.CH[i] = false;
            }
            for (int i = 0; i < 8; i++)
            {
                if (cl_tab[i].Text == "1") stos.CL[i] = true;
                else stos.CL[i] = false;
            }
            for (int i = 0; i < 8; i++)
            {
                if (dh_tab[i].Text == "1") stos.DH[i] = true;
                else stos.DH[i] = false;
            }
            for (int i = 0; i < 8; i++)
            {
                if (dl_tab[i].Text == "1") stos.DL[i] = true;
                else stos.DL[i] = false;
            }
        }

        private void przerwanie_reset()
        {
            
            for (int i = 0; i < 8; i++)
            {
                if (stos.AH[i]) ah_tab[i].Text = "1";
                else ah_tab[i].Text = "0";
            }
            
            for (int i = 0; i < 8; i++)
            {
                if (stos.AL[i]) al_tab[i].Text = "1";
                else al_tab[i].Text = "0";
            }
            
            for (int i = 0; i < 8; i++)
            {
                if (stos.BH[i]) bh_tab[i].Text = "1";
                else bh_tab[i].Text = "0";
            }
            for (int i = 0; i < 8; i++)
            {
                if (stos.BL[i]) bl_tab[i].Text = "1";
                else bl_tab[i].Text = "0";
            }

            for (int i = 0; i < 8; i++)
            {
                if (stos.CH[i]) ch_tab[i].Text = "1";
                else ch_tab[i].Text = "0";
            }
            for (int i = 0; i < 8; i++)
            {
                if (stos.CL[i]) cl_tab[i].Text = "1";
                else cl_tab[i].Text = "0";
            }
            for (int i = 0; i < 8; i++)
            {
                if (stos.DH[i]) dh_tab[i].Text = "1";
                else dh_tab[i].Text = "0";
            }
            for (int i = 0; i < 8; i++)
            {
                if (stos.DL[i]) dl_tab[i].Text = "1";
                else dl_tab[i].Text = "0";
            }

            int sumaAH = 0;
            int sumaAL = 0;
            int sumaBH = 0;
            int sumaBL = 0;
            int sumaCH = 0;
            int sumaCL = 0;
            int sumaDH = 0;
            int sumaDL = 0;
            int pot = 1;
            int temp;
            int sum;



            for (int i = 0; i < 8; i++)
            {
                if (ah_tab[i].Text == "1") sumaAH += pot;
                if (al_tab[i].Text == "1") sumaAL += pot;
                if (bh_tab[i].Text == "1") sumaBH += pot;
                if (bl_tab[i].Text == "1") sumaBL += pot;
                if (ch_tab[i].Text == "1") sumaCH += pot;
                if (cl_tab[i].Text == "1") sumaCL += pot;
                if (dh_tab[i].Text == "1") sumaDH += pot;
                if (dl_tab[i].Text == "1") sumaDL += pot;
                pot *= 2;
            }

           
            this.a_dec_h_t.Text = sumaAH.ToString();
            temp = Int32.Parse(a_dec_l_t.Text);
            sum = sumaAH * 256 + temp;
            this.a_dec_x_t.Text = sum.ToString();
            this.a_hex_h_t.Text = "0x" + sumaAH.ToString("X");
            this.a_hex_x_t.Text = "0x" + sum.ToString("X");

            this.a_dec_l_t.Text = sumaAL.ToString();
            sum = sumaAL + 256 * Int32.Parse(a_dec_h_t.Text);
            this.a_dec_x_t.Text = sum.ToString();
            this.a_hex_l_t.Text = "0x" + sumaAL.ToString("X");
            this.a_hex_x_t.Text = "0x" + sum.ToString("X");


            this.b_dec_h_t.Text = sumaBH.ToString();
            temp = Int32.Parse(b_dec_l_t.Text);
            sum = sumaBH * 256 + temp;
            this.b_dec_x_t.Text = sum.ToString();
            this.b_hex_h_t.Text = "0x" + sumaBH.ToString("X");
            this.b_hex_x_t.Text = "0x" + sum.ToString("X");

            this.b_dec_l_t.Text = sumaBL.ToString();
            sum = sumaBL + 256 * Int32.Parse(b_dec_h_t.Text);
            this.b_dec_x_t.Text = sum.ToString();
            this.b_hex_l_t.Text = "0x" + sumaBL.ToString("X");
            this.b_hex_x_t.Text = "0x" + sum.ToString("X");


            this.c_dec_h_t.Text = sumaCH.ToString();
            temp = Int32.Parse(c_dec_l_t.Text);
            sum = sumaCH * 256 + temp;
            this.c_dec_x_t.Text = sum.ToString();
            this.c_hex_h_t.Text = "0x" + sumaCH.ToString("X");
            this.c_hex_x_t.Text = "0x" + sum.ToString("X");

            this.c_dec_l_t.Text = sumaCL.ToString();
            sum = sumaCL + 256 * Int32.Parse(c_dec_h_t.Text);
            this.c_dec_x_t.Text = sum.ToString();
            this.c_hex_l_t.Text = "0x" + sumaCL.ToString("X");
            this.c_hex_x_t.Text = "0x" + sum.ToString("X");


            this.d_dec_h_t.Text = sumaDH.ToString();
            temp = Int32.Parse(d_dec_l_t.Text);
            sum = sumaDH * 256 + temp;
            this.d_dec_x_t.Text = sum.ToString();
            this.d_hex_h_t.Text = "0x" + sumaDH.ToString("X");
            this.d_hex_x_t.Text = "0x" + sum.ToString("X");

            this.d_dec_l_t.Text = sumaDL.ToString();
            sum = sumaDL + 256 * Int32.Parse(d_dec_h_t.Text);
            this.d_dec_x_t.Text = sum.ToString();
            this.d_hex_l_t.Text = "0x" + sumaDL.ToString("X");
            this.d_hex_x_t.Text = "0x" + sum.ToString("X");
        }

        private void timer_przer_Tick(object sender, EventArgs e)
        {
            przerwanie_reset();
            timer.Start();
            timer_przer.Stop();
        }

        private void zaczekaj_Tick(object sender, EventArgs e)
        {
            timer_przer.Start();
            klawisz = false;
            zaczekajB = false;
            zaczekaj.Stop();
        }

        private void zaczekaj5_Tick(object sender, EventArgs e)
        {
            zacz5--;
            zaczekaj_t.Text = zacz5.ToString();
            if (zacz5 == 0) zaczekaj5.Stop();
        }

        private void Symulator_Load(object sender, EventArgs e)
        {

        }

        private void zatrzask_tim_Tick(object sender, EventArgs e)
        {
            if(klawisz)
            {
                wyk_kom(1, 22, ax, true);
                wyk_kom(1, 0, ax, false);
                wyk_kom(1, znak, bx, true);
                wyk_kom(1, 0, bx, false);
                wyk_kom(1, 0, cx, true);
                wyk_kom(1, 0, cx, false);
                wyk_kom(1, 0, dx, true);
                wyk_kom(1, 0, dx, false);
                timer_przer.Start();
                klawisz = false;
                zaczekajB = false;
                zatrzask_tim.Stop();
            }
        }
    }
}
