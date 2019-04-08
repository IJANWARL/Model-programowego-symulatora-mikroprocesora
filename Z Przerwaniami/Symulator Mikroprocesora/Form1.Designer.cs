namespace Zad1
{
    public struct rejestr
    {
        public System.Windows.Forms.Button[] tab_h;
        public System.Windows.Forms.TextBox dec_h;
        public System.Windows.Forms.TextBox hex_h;
        public System.Windows.Forms.Button[] tab_l;
        public System.Windows.Forms.TextBox dec_l;
        public System.Windows.Forms.TextBox hex_l;
        public System.Windows.Forms.TextBox cal_d;
        public System.Windows.Forms.TextBox cal_h;
    }

    public struct stos
    {
        public bool[] AH;
        public bool[] AL;
        public bool[] BH;
        public bool[] BL;
        public bool[] CH;
        public bool[] CL;
        public bool[] DH;
        public bool[] DL;
    }

    partial class Symulator
    {
        public int sumator_komend = 0;
        public int iterator_komend = 0;
        public string text;
        private okno2 okno2;
        private okno3 okno3;
        bool zatrzask = false;
        int przes = 0;
        stos stos;
        System.DateTime tim = System.DateTime.Now;
        string time;
        int znak;
        bool klawisz = false;
        bool zaczekajB = false;
        bool klawisz_zatszask = true;
        int zacz5 = 5;


        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Symulator));
            this.komendy_t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_rb = new System.Windows.Forms.RadioButton();
            this.sub_rb = new System.Windows.Forms.RadioButton();
            this.mov_rb = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dl_rb = new System.Windows.Forms.RadioButton();
            this.dh_rb = new System.Windows.Forms.RadioButton();
            this.cl_rb = new System.Windows.Forms.RadioButton();
            this.wartosc_rb = new System.Windows.Forms.RadioButton();
            this.ch_rb = new System.Windows.Forms.RadioButton();
            this.bl_rb = new System.Windows.Forms.RadioButton();
            this.bh_rb = new System.Windows.Forms.RadioButton();
            this.al_rb = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ah_rb = new System.Windows.Forms.RadioButton();
            this.wartosc_p = new System.Windows.Forms.Panel();
            this.wartosc_t = new System.Windows.Forms.TextBox();
            this.hexalnie_rb = new System.Windows.Forms.RadioButton();
            this.decymalnie_rb = new System.Windows.Forms.RadioButton();
            this.dodaj_b = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.a_dec_h_t = new System.Windows.Forms.TextBox();
            this.a_dec_l_t = new System.Windows.Forms.TextBox();
            this.b_dec_h_t = new System.Windows.Forms.TextBox();
            this.b_dec_l_t = new System.Windows.Forms.TextBox();
            this.c_dec_h_t = new System.Windows.Forms.TextBox();
            this.c_dec_l_t = new System.Windows.Forms.TextBox();
            this.d_dec_h_t = new System.Windows.Forms.TextBox();
            this.d_dec_l_t = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.d_dec_x_t = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.c_dec_x_t = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.b_dec_x_t = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.a_dec_x_t = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ah8 = new System.Windows.Forms.Button();
            this.ah6 = new System.Windows.Forms.Button();
            this.ah7 = new System.Windows.Forms.Button();
            this.ah5 = new System.Windows.Forms.Button();
            this.ah4 = new System.Windows.Forms.Button();
            this.ah3 = new System.Windows.Forms.Button();
            this.ah2 = new System.Windows.Forms.Button();
            this.ah1 = new System.Windows.Forms.Button();
            this.al8 = new System.Windows.Forms.Button();
            this.al7 = new System.Windows.Forms.Button();
            this.al6 = new System.Windows.Forms.Button();
            this.al5 = new System.Windows.Forms.Button();
            this.al4 = new System.Windows.Forms.Button();
            this.al3 = new System.Windows.Forms.Button();
            this.al2 = new System.Windows.Forms.Button();
            this.al1 = new System.Windows.Forms.Button();
            this.bl1 = new System.Windows.Forms.Button();
            this.bl2 = new System.Windows.Forms.Button();
            this.bl3 = new System.Windows.Forms.Button();
            this.bl4 = new System.Windows.Forms.Button();
            this.bl5 = new System.Windows.Forms.Button();
            this.bl6 = new System.Windows.Forms.Button();
            this.bl7 = new System.Windows.Forms.Button();
            this.bl8 = new System.Windows.Forms.Button();
            this.bh1 = new System.Windows.Forms.Button();
            this.bh2 = new System.Windows.Forms.Button();
            this.bh3 = new System.Windows.Forms.Button();
            this.bh4 = new System.Windows.Forms.Button();
            this.bh5 = new System.Windows.Forms.Button();
            this.bh7 = new System.Windows.Forms.Button();
            this.bh6 = new System.Windows.Forms.Button();
            this.bh8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reset_al_b = new System.Windows.Forms.Button();
            this.reset_ah_b = new System.Windows.Forms.Button();
            this.a_hex_l_t = new System.Windows.Forms.TextBox();
            this.a_hex_h_t = new System.Windows.Forms.TextBox();
            this.a_hex_x_t = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.reset_bl_b = new System.Windows.Forms.Button();
            this.reset_bh_b = new System.Windows.Forms.Button();
            this.b_hex_l_t = new System.Windows.Forms.TextBox();
            this.b_hex_h_t = new System.Windows.Forms.TextBox();
            this.b_hex_x_t = new System.Windows.Forms.TextBox();
            this.cl1 = new System.Windows.Forms.Button();
            this.cl2 = new System.Windows.Forms.Button();
            this.cl3 = new System.Windows.Forms.Button();
            this.cl4 = new System.Windows.Forms.Button();
            this.cl5 = new System.Windows.Forms.Button();
            this.cl6 = new System.Windows.Forms.Button();
            this.cl7 = new System.Windows.Forms.Button();
            this.cl8 = new System.Windows.Forms.Button();
            this.ch1 = new System.Windows.Forms.Button();
            this.ch2 = new System.Windows.Forms.Button();
            this.ch3 = new System.Windows.Forms.Button();
            this.ch4 = new System.Windows.Forms.Button();
            this.ch5 = new System.Windows.Forms.Button();
            this.ch7 = new System.Windows.Forms.Button();
            this.ch6 = new System.Windows.Forms.Button();
            this.ch8 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.reset_cl_b = new System.Windows.Forms.Button();
            this.reset_ch_b = new System.Windows.Forms.Button();
            this.c_hex_l_t = new System.Windows.Forms.TextBox();
            this.c_hex_h_t = new System.Windows.Forms.TextBox();
            this.c_hex_x_t = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.reset_dl_b = new System.Windows.Forms.Button();
            this.reset_dh_b = new System.Windows.Forms.Button();
            this.d_hex_l_t = new System.Windows.Forms.TextBox();
            this.dl1 = new System.Windows.Forms.Button();
            this.d_hex_h_t = new System.Windows.Forms.TextBox();
            this.d_hex_x_t = new System.Windows.Forms.TextBox();
            this.dl2 = new System.Windows.Forms.Button();
            this.dl3 = new System.Windows.Forms.Button();
            this.dh8 = new System.Windows.Forms.Button();
            this.dl4 = new System.Windows.Forms.Button();
            this.dl5 = new System.Windows.Forms.Button();
            this.dh6 = new System.Windows.Forms.Button();
            this.dl6 = new System.Windows.Forms.Button();
            this.dh7 = new System.Windows.Forms.Button();
            this.dl7 = new System.Windows.Forms.Button();
            this.dh5 = new System.Windows.Forms.Button();
            this.dl8 = new System.Windows.Forms.Button();
            this.dh4 = new System.Windows.Forms.Button();
            this.dh1 = new System.Windows.Forms.Button();
            this.dh3 = new System.Windows.Forms.Button();
            this.dh2 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dl_d_rb = new System.Windows.Forms.RadioButton();
            this.cl_d_rb = new System.Windows.Forms.RadioButton();
            this.dh_d_rb = new System.Windows.Forms.RadioButton();
            this.ch_d_rb = new System.Windows.Forms.RadioButton();
            this.bl_d_rb = new System.Windows.Forms.RadioButton();
            this.bh_d_rb = new System.Windows.Forms.RadioButton();
            this.al_d_rb = new System.Windows.Forms.RadioButton();
            this.ah_d_rb = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.wykonaj_b = new System.Windows.Forms.Button();
            this.krkowo_b = new System.Windows.Forms.Button();
            this.caly_b = new System.Windows.Forms.Button();
            this.plik_odczyt_b = new System.Windows.Forms.Button();
            this.plik_zapis_b = new System.Windows.Forms.Button();
            this.reset_kom_b = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.sec5_rb = new System.Windows.Forms.RadioButton();
            this.sec3_rb = new System.Windows.Forms.RadioButton();
            this.sec1_rb = new System.Windows.Forms.RadioButton();
            this.sec_rb = new System.Windows.Forms.RadioButton();
            this.label30 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pause_b = new System.Windows.Forms.Button();
            this.play_b = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.przerwanie_ch = new System.Windows.Forms.CheckBox();
            this.przerwanie_p = new System.Windows.Forms.Panel();
            this.przerwanie_b = new System.Windows.Forms.Button();
            this.spr_czy_nac_rb = new System.Windows.Forms.RadioButton();
            this.zaczekaj_rb = new System.Windows.Forms.RadioButton();
            this.stan_klawiatury_rb = new System.Windows.Forms.RadioButton();
            this.odczytaj_znak_rb = new System.Windows.Forms.RadioButton();
            this.pobierz_dat_rb = new System.Windows.Forms.RadioButton();
            this.ustaw_dat_rb = new System.Windows.Forms.RadioButton();
            this.pobierz_godz_rb = new System.Windows.Forms.RadioButton();
            this.ustaw_godz_rb = new System.Windows.Forms.RadioButton();
            this.screen_shot_rb = new System.Windows.Forms.RadioButton();
            this.picture = new System.Windows.Forms.PictureBox();
            this.godzina_t = new System.Windows.Forms.TextBox();
            this.data_t = new System.Windows.Forms.TextBox();
            this.timer_przer = new System.Windows.Forms.Timer(this.components);
            this.zaczekaj = new System.Windows.Forms.Timer(this.components);
            this.zaczekaj_t = new System.Windows.Forms.TextBox();
            this.zaczekaj5 = new System.Windows.Forms.Timer(this.components);
            this.zatrzask_tim = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.wartosc_p.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.przerwanie_p.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // komendy_t
            // 
            this.komendy_t.AcceptsReturn = true;
            this.komendy_t.Location = new System.Drawing.Point(641, 294);
            this.komendy_t.Multiline = true;
            this.komendy_t.Name = "komendy_t";
            this.komendy_t.ReadOnly = true;
            this.komendy_t.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.komendy_t.Size = new System.Drawing.Size(188, 240);
            this.komendy_t.TabIndex = 1;
            this.komendy_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(616, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sekwencja komend:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.add_rb);
            this.panel1.Controls.Add(this.sub_rb);
            this.panel1.Controls.Add(this.mov_rb);
            this.panel1.Location = new System.Drawing.Point(252, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 107);
            this.panel1.TabIndex = 3;
            // 
            // add_rb
            // 
            this.add_rb.AutoSize = true;
            this.add_rb.Location = new System.Drawing.Point(18, 39);
            this.add_rb.Name = "add_rb";
            this.add_rb.Size = new System.Drawing.Size(48, 17);
            this.add_rb.TabIndex = 2;
            this.add_rb.Text = "ADD";
            this.add_rb.UseVisualStyleBackColor = true;
            this.add_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // sub_rb
            // 
            this.sub_rb.AutoSize = true;
            this.sub_rb.Location = new System.Drawing.Point(18, 62);
            this.sub_rb.Name = "sub_rb";
            this.sub_rb.Size = new System.Drawing.Size(47, 17);
            this.sub_rb.TabIndex = 1;
            this.sub_rb.Text = "SUB";
            this.sub_rb.UseVisualStyleBackColor = true;
            this.sub_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // mov_rb
            // 
            this.mov_rb.AutoSize = true;
            this.mov_rb.Checked = true;
            this.mov_rb.Location = new System.Drawing.Point(18, 16);
            this.mov_rb.Name = "mov_rb";
            this.mov_rb.Size = new System.Drawing.Size(49, 17);
            this.mov_rb.TabIndex = 0;
            this.mov_rb.TabStop = true;
            this.mov_rb.Text = "MOV";
            this.mov_rb.UseVisualStyleBackColor = true;
            this.mov_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dl_rb);
            this.panel3.Controls.Add(this.dh_rb);
            this.panel3.Controls.Add(this.cl_rb);
            this.panel3.Controls.Add(this.wartosc_rb);
            this.panel3.Controls.Add(this.ch_rb);
            this.panel3.Controls.Add(this.bl_rb);
            this.panel3.Controls.Add(this.bh_rb);
            this.panel3.Controls.Add(this.al_rb);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.ah_rb);
            this.panel3.Location = new System.Drawing.Point(14, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 214);
            this.panel3.TabIndex = 26;
            // 
            // dl_rb
            // 
            this.dl_rb.AutoSize = true;
            this.dl_rb.Location = new System.Drawing.Point(11, 160);
            this.dl_rb.Name = "dl_rb";
            this.dl_rb.Size = new System.Drawing.Size(39, 17);
            this.dl_rb.TabIndex = 8;
            this.dl_rb.Text = "DL";
            this.dl_rb.UseVisualStyleBackColor = true;
            this.dl_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dh_rb
            // 
            this.dh_rb.AutoSize = true;
            this.dh_rb.Location = new System.Drawing.Point(11, 139);
            this.dh_rb.Name = "dh_rb";
            this.dh_rb.Size = new System.Drawing.Size(41, 17);
            this.dh_rb.TabIndex = 7;
            this.dh_rb.Text = "DH";
            this.dh_rb.UseVisualStyleBackColor = true;
            this.dh_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // cl_rb
            // 
            this.cl_rb.AutoSize = true;
            this.cl_rb.Location = new System.Drawing.Point(11, 116);
            this.cl_rb.Name = "cl_rb";
            this.cl_rb.Size = new System.Drawing.Size(38, 17);
            this.cl_rb.TabIndex = 5;
            this.cl_rb.Text = "CL";
            this.cl_rb.UseVisualStyleBackColor = true;
            this.cl_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // wartosc_rb
            // 
            this.wartosc_rb.AutoSize = true;
            this.wartosc_rb.Location = new System.Drawing.Point(11, 180);
            this.wartosc_rb.Name = "wartosc_rb";
            this.wartosc_rb.Size = new System.Drawing.Size(68, 17);
            this.wartosc_rb.TabIndex = 6;
            this.wartosc_rb.Text = "Wartość:";
            this.wartosc_rb.UseVisualStyleBackColor = true;
            this.wartosc_rb.CheckedChanged += new System.EventHandler(this.wartosc_CheckedChanged);
            this.wartosc_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ch_rb
            // 
            this.ch_rb.AutoSize = true;
            this.ch_rb.Location = new System.Drawing.Point(11, 95);
            this.ch_rb.Name = "ch_rb";
            this.ch_rb.Size = new System.Drawing.Size(40, 17);
            this.ch_rb.TabIndex = 4;
            this.ch_rb.Text = "CH";
            this.ch_rb.UseVisualStyleBackColor = true;
            this.ch_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bl_rb
            // 
            this.bl_rb.AutoSize = true;
            this.bl_rb.Location = new System.Drawing.Point(11, 72);
            this.bl_rb.Name = "bl_rb";
            this.bl_rb.Size = new System.Drawing.Size(38, 17);
            this.bl_rb.TabIndex = 3;
            this.bl_rb.Text = "BL";
            this.bl_rb.UseVisualStyleBackColor = true;
            this.bl_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bh_rb
            // 
            this.bh_rb.AutoSize = true;
            this.bh_rb.Location = new System.Drawing.Point(11, 49);
            this.bh_rb.Name = "bh_rb";
            this.bh_rb.Size = new System.Drawing.Size(40, 17);
            this.bh_rb.TabIndex = 2;
            this.bh_rb.Text = "BH";
            this.bh_rb.UseVisualStyleBackColor = true;
            this.bh_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // al_rb
            // 
            this.al_rb.AutoSize = true;
            this.al_rb.Location = new System.Drawing.Point(11, 26);
            this.al_rb.Name = "al_rb";
            this.al_rb.Size = new System.Drawing.Size(38, 17);
            this.al_rb.TabIndex = 1;
            this.al_rb.Text = "AL";
            this.al_rb.UseVisualStyleBackColor = true;
            this.al_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(127, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 17);
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // ah_rb
            // 
            this.ah_rb.AutoSize = true;
            this.ah_rb.Checked = true;
            this.ah_rb.Location = new System.Drawing.Point(11, 3);
            this.ah_rb.Name = "ah_rb";
            this.ah_rb.Size = new System.Drawing.Size(40, 17);
            this.ah_rb.TabIndex = 0;
            this.ah_rb.TabStop = true;
            this.ah_rb.Text = "AH";
            this.ah_rb.UseVisualStyleBackColor = true;
            this.ah_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // wartosc_p
            // 
            this.wartosc_p.Controls.Add(this.wartosc_t);
            this.wartosc_p.Controls.Add(this.hexalnie_rb);
            this.wartosc_p.Controls.Add(this.decymalnie_rb);
            this.wartosc_p.Location = new System.Drawing.Point(14, 479);
            this.wartosc_p.Name = "wartosc_p";
            this.wartosc_p.Size = new System.Drawing.Size(232, 60);
            this.wartosc_p.TabIndex = 9;
            this.wartosc_p.Visible = false;
            // 
            // wartosc_t
            // 
            this.wartosc_t.Location = new System.Drawing.Point(11, 32);
            this.wartosc_t.Name = "wartosc_t";
            this.wartosc_t.Size = new System.Drawing.Size(197, 20);
            this.wartosc_t.TabIndex = 7;
            this.wartosc_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // hexalnie_rb
            // 
            this.hexalnie_rb.AutoSize = true;
            this.hexalnie_rb.Location = new System.Drawing.Point(130, 9);
            this.hexalnie_rb.Name = "hexalnie_rb";
            this.hexalnie_rb.Size = new System.Drawing.Size(66, 17);
            this.hexalnie_rb.TabIndex = 9;
            this.hexalnie_rb.TabStop = true;
            this.hexalnie_rb.Text = "Hexalnie";
            this.hexalnie_rb.UseVisualStyleBackColor = true;
            this.hexalnie_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // decymalnie_rb
            // 
            this.decymalnie_rb.AutoSize = true;
            this.decymalnie_rb.Checked = true;
            this.decymalnie_rb.Location = new System.Drawing.Point(35, 9);
            this.decymalnie_rb.Name = "decymalnie_rb";
            this.decymalnie_rb.Size = new System.Drawing.Size(80, 17);
            this.decymalnie_rb.TabIndex = 8;
            this.decymalnie_rb.TabStop = true;
            this.decymalnie_rb.Text = "Decymalnie";
            this.decymalnie_rb.UseVisualStyleBackColor = true;
            this.decymalnie_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dodaj_b
            // 
            this.dodaj_b.BackgroundImage = global::Zad1.Properties.Resources.images1;
            this.dodaj_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dodaj_b.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dodaj_b.Location = new System.Drawing.Point(256, 404);
            this.dodaj_b.Name = "dodaj_b";
            this.dodaj_b.Size = new System.Drawing.Size(157, 52);
            this.dodaj_b.TabIndex = 27;
            this.dodaj_b.Text = "Dodaj";
            this.dodaj_b.UseVisualStyleBackColor = false;
            this.dodaj_b.Click += new System.EventHandler(this.dodawanie_kom);
            this.dodaj_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rejestr AX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "AH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "AL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rejestr BX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rejestr CX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Rejestr DX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "BH";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "BL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "CH";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "CL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "DH";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "DL";
            // 
            // a_dec_h_t
            // 
            this.a_dec_h_t.Location = new System.Drawing.Point(99, 109);
            this.a_dec_h_t.Name = "a_dec_h_t";
            this.a_dec_h_t.ReadOnly = true;
            this.a_dec_h_t.Size = new System.Drawing.Size(49, 20);
            this.a_dec_h_t.TabIndex = 16;
            this.a_dec_h_t.Text = "0";
            this.a_dec_h_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // a_dec_l_t
            // 
            this.a_dec_l_t.Location = new System.Drawing.Point(154, 109);
            this.a_dec_l_t.Name = "a_dec_l_t";
            this.a_dec_l_t.ReadOnly = true;
            this.a_dec_l_t.Size = new System.Drawing.Size(49, 20);
            this.a_dec_l_t.TabIndex = 17;
            this.a_dec_l_t.Text = "0";
            this.a_dec_l_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_dec_h_t
            // 
            this.b_dec_h_t.Location = new System.Drawing.Point(97, 108);
            this.b_dec_h_t.Name = "b_dec_h_t";
            this.b_dec_h_t.ReadOnly = true;
            this.b_dec_h_t.Size = new System.Drawing.Size(49, 20);
            this.b_dec_h_t.TabIndex = 18;
            this.b_dec_h_t.Text = "0";
            this.b_dec_h_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_dec_l_t
            // 
            this.b_dec_l_t.Location = new System.Drawing.Point(152, 108);
            this.b_dec_l_t.Name = "b_dec_l_t";
            this.b_dec_l_t.ReadOnly = true;
            this.b_dec_l_t.Size = new System.Drawing.Size(49, 20);
            this.b_dec_l_t.TabIndex = 19;
            this.b_dec_l_t.Text = "0";
            this.b_dec_l_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c_dec_h_t
            // 
            this.c_dec_h_t.Location = new System.Drawing.Point(94, 109);
            this.c_dec_h_t.Name = "c_dec_h_t";
            this.c_dec_h_t.ReadOnly = true;
            this.c_dec_h_t.Size = new System.Drawing.Size(49, 20);
            this.c_dec_h_t.TabIndex = 20;
            this.c_dec_h_t.Text = "0";
            this.c_dec_h_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c_dec_l_t
            // 
            this.c_dec_l_t.Location = new System.Drawing.Point(149, 109);
            this.c_dec_l_t.Name = "c_dec_l_t";
            this.c_dec_l_t.ReadOnly = true;
            this.c_dec_l_t.Size = new System.Drawing.Size(49, 20);
            this.c_dec_l_t.TabIndex = 21;
            this.c_dec_l_t.Text = "0";
            this.c_dec_l_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d_dec_h_t
            // 
            this.d_dec_h_t.Location = new System.Drawing.Point(105, 109);
            this.d_dec_h_t.Name = "d_dec_h_t";
            this.d_dec_h_t.ReadOnly = true;
            this.d_dec_h_t.Size = new System.Drawing.Size(49, 20);
            this.d_dec_h_t.TabIndex = 22;
            this.d_dec_h_t.Text = "0";
            this.d_dec_h_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d_dec_l_t
            // 
            this.d_dec_l_t.Location = new System.Drawing.Point(160, 109);
            this.d_dec_l_t.Name = "d_dec_l_t";
            this.d_dec_l_t.ReadOnly = true;
            this.d_dec_l_t.Size = new System.Drawing.Size(49, 20);
            this.d_dec_l_t.TabIndex = 23;
            this.d_dec_l_t.Text = "0";
            this.d_dec_l_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(480, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(287, 31);
            this.label14.TabIndex = 24;
            this.label14.Text = "Zawartość rejestrów:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(60, 93);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(22, 13);
            this.label26.TabIndex = 44;
            this.label26.Text = "DX";
            // 
            // d_dec_x_t
            // 
            this.d_dec_x_t.Location = new System.Drawing.Point(50, 109);
            this.d_dec_x_t.Name = "d_dec_x_t";
            this.d_dec_x_t.ReadOnly = true;
            this.d_dec_x_t.Size = new System.Drawing.Size(49, 20);
            this.d_dec_x_t.TabIndex = 43;
            this.d_dec_x_t.Text = "0";
            this.d_dec_x_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(54, 93);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 13);
            this.label25.TabIndex = 42;
            this.label25.Text = "CX";
            // 
            // c_dec_x_t
            // 
            this.c_dec_x_t.Location = new System.Drawing.Point(39, 109);
            this.c_dec_x_t.Name = "c_dec_x_t";
            this.c_dec_x_t.ReadOnly = true;
            this.c_dec_x_t.Size = new System.Drawing.Size(49, 20);
            this.c_dec_x_t.TabIndex = 41;
            this.c_dec_x_t.Text = "0";
            this.c_dec_x_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(54, 92);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(21, 13);
            this.label24.TabIndex = 40;
            this.label24.Text = "BX";
            // 
            // b_dec_x_t
            // 
            this.b_dec_x_t.Location = new System.Drawing.Point(42, 108);
            this.b_dec_x_t.Name = "b_dec_x_t";
            this.b_dec_x_t.ReadOnly = true;
            this.b_dec_x_t.Size = new System.Drawing.Size(49, 20);
            this.b_dec_x_t.TabIndex = 39;
            this.b_dec_x_t.Text = "0";
            this.b_dec_x_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(54, 93);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(21, 13);
            this.label23.TabIndex = 38;
            this.label23.Text = "AX";
            // 
            // a_dec_x_t
            // 
            this.a_dec_x_t.Location = new System.Drawing.Point(44, 109);
            this.a_dec_x_t.Name = "a_dec_x_t";
            this.a_dec_x_t.ReadOnly = true;
            this.a_dec_x_t.Size = new System.Drawing.Size(49, 20);
            this.a_dec_x_t.TabIndex = 37;
            this.a_dec_x_t.Text = "0";
            this.a_dec_x_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(172, 93);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 13);
            this.label22.TabIndex = 36;
            this.label22.Text = "DL";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(116, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 13);
            this.label21.TabIndex = 35;
            this.label21.Text = "DH";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(166, 94);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "CL";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(105, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "CH";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(166, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "BL";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(106, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "BH";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(173, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "AL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(111, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "AH";
            // 
            // ah8
            // 
            this.ah8.Location = new System.Drawing.Point(29, 25);
            this.ah8.Name = "ah8";
            this.ah8.Size = new System.Drawing.Size(20, 22);
            this.ah8.TabIndex = 46;
            this.ah8.Text = "0";
            this.ah8.UseVisualStyleBackColor = true;
            this.ah8.Click += new System.EventHandler(this.ah_Click);
            this.ah8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ah6
            // 
            this.ah6.Location = new System.Drawing.Point(81, 25);
            this.ah6.Name = "ah6";
            this.ah6.Size = new System.Drawing.Size(20, 22);
            this.ah6.TabIndex = 47;
            this.ah6.Text = "0";
            this.ah6.UseVisualStyleBackColor = true;
            this.ah6.Click += new System.EventHandler(this.ah_Click);
            this.ah6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ah7
            // 
            this.ah7.Location = new System.Drawing.Point(55, 25);
            this.ah7.Name = "ah7";
            this.ah7.Size = new System.Drawing.Size(20, 22);
            this.ah7.TabIndex = 48;
            this.ah7.Text = "0";
            this.ah7.UseVisualStyleBackColor = true;
            this.ah7.Click += new System.EventHandler(this.ah_Click);
            this.ah7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ah5
            // 
            this.ah5.Location = new System.Drawing.Point(107, 25);
            this.ah5.Name = "ah5";
            this.ah5.Size = new System.Drawing.Size(20, 22);
            this.ah5.TabIndex = 49;
            this.ah5.Text = "0";
            this.ah5.UseVisualStyleBackColor = true;
            this.ah5.Click += new System.EventHandler(this.ah_Click);
            this.ah5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ah4
            // 
            this.ah4.Location = new System.Drawing.Point(131, 25);
            this.ah4.Name = "ah4";
            this.ah4.Size = new System.Drawing.Size(20, 22);
            this.ah4.TabIndex = 50;
            this.ah4.Text = "0";
            this.ah4.UseVisualStyleBackColor = true;
            this.ah4.Click += new System.EventHandler(this.ah_Click);
            this.ah4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ah3
            // 
            this.ah3.Location = new System.Drawing.Point(157, 25);
            this.ah3.Name = "ah3";
            this.ah3.Size = new System.Drawing.Size(20, 22);
            this.ah3.TabIndex = 51;
            this.ah3.Text = "0";
            this.ah3.UseVisualStyleBackColor = true;
            this.ah3.Click += new System.EventHandler(this.ah_Click);
            this.ah3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ah2
            // 
            this.ah2.Location = new System.Drawing.Point(183, 25);
            this.ah2.Name = "ah2";
            this.ah2.Size = new System.Drawing.Size(20, 22);
            this.ah2.TabIndex = 52;
            this.ah2.Text = "0";
            this.ah2.UseVisualStyleBackColor = true;
            this.ah2.Click += new System.EventHandler(this.ah_Click);
            this.ah2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ah1
            // 
            this.ah1.Location = new System.Drawing.Point(209, 25);
            this.ah1.Name = "ah1";
            this.ah1.Size = new System.Drawing.Size(20, 22);
            this.ah1.TabIndex = 53;
            this.ah1.Text = "0";
            this.ah1.UseVisualStyleBackColor = true;
            this.ah1.Click += new System.EventHandler(this.ah_Click);
            this.ah1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // al8
            // 
            this.al8.Location = new System.Drawing.Point(29, 61);
            this.al8.Name = "al8";
            this.al8.Size = new System.Drawing.Size(20, 22);
            this.al8.TabIndex = 54;
            this.al8.Text = "0";
            this.al8.UseVisualStyleBackColor = true;
            this.al8.Click += new System.EventHandler(this.al_Click);
            this.al8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // al7
            // 
            this.al7.Location = new System.Drawing.Point(55, 61);
            this.al7.Name = "al7";
            this.al7.Size = new System.Drawing.Size(20, 22);
            this.al7.TabIndex = 55;
            this.al7.Text = "0";
            this.al7.UseVisualStyleBackColor = true;
            this.al7.Click += new System.EventHandler(this.al_Click);
            this.al7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // al6
            // 
            this.al6.Location = new System.Drawing.Point(81, 61);
            this.al6.Name = "al6";
            this.al6.Size = new System.Drawing.Size(20, 22);
            this.al6.TabIndex = 56;
            this.al6.Text = "0";
            this.al6.UseVisualStyleBackColor = true;
            this.al6.Click += new System.EventHandler(this.al_Click);
            this.al6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // al5
            // 
            this.al5.Location = new System.Drawing.Point(107, 61);
            this.al5.Name = "al5";
            this.al5.Size = new System.Drawing.Size(20, 22);
            this.al5.TabIndex = 57;
            this.al5.Text = "0";
            this.al5.UseVisualStyleBackColor = true;
            this.al5.Click += new System.EventHandler(this.al_Click);
            this.al5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // al4
            // 
            this.al4.Location = new System.Drawing.Point(131, 61);
            this.al4.Name = "al4";
            this.al4.Size = new System.Drawing.Size(20, 22);
            this.al4.TabIndex = 58;
            this.al4.Text = "0";
            this.al4.UseVisualStyleBackColor = true;
            this.al4.Click += new System.EventHandler(this.al_Click);
            this.al4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // al3
            // 
            this.al3.Location = new System.Drawing.Point(157, 61);
            this.al3.Name = "al3";
            this.al3.Size = new System.Drawing.Size(20, 22);
            this.al3.TabIndex = 59;
            this.al3.Text = "0";
            this.al3.UseVisualStyleBackColor = true;
            this.al3.Click += new System.EventHandler(this.al_Click);
            this.al3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // al2
            // 
            this.al2.Location = new System.Drawing.Point(183, 61);
            this.al2.Name = "al2";
            this.al2.Size = new System.Drawing.Size(20, 22);
            this.al2.TabIndex = 60;
            this.al2.Text = "0";
            this.al2.UseVisualStyleBackColor = true;
            this.al2.Click += new System.EventHandler(this.al_Click);
            this.al2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // al1
            // 
            this.al1.Location = new System.Drawing.Point(209, 61);
            this.al1.Name = "al1";
            this.al1.Size = new System.Drawing.Size(20, 22);
            this.al1.TabIndex = 61;
            this.al1.Text = "0";
            this.al1.UseVisualStyleBackColor = true;
            this.al1.Click += new System.EventHandler(this.al_Click);
            this.al1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bl1
            // 
            this.bl1.Location = new System.Drawing.Point(209, 60);
            this.bl1.Name = "bl1";
            this.bl1.Size = new System.Drawing.Size(20, 22);
            this.bl1.TabIndex = 77;
            this.bl1.Text = "0";
            this.bl1.UseVisualStyleBackColor = true;
            this.bl1.Click += new System.EventHandler(this.bl_Click);
            this.bl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bl2
            // 
            this.bl2.Location = new System.Drawing.Point(183, 60);
            this.bl2.Name = "bl2";
            this.bl2.Size = new System.Drawing.Size(20, 22);
            this.bl2.TabIndex = 76;
            this.bl2.Text = "0";
            this.bl2.UseVisualStyleBackColor = true;
            this.bl2.Click += new System.EventHandler(this.bl_Click);
            this.bl2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bl3
            // 
            this.bl3.Location = new System.Drawing.Point(157, 60);
            this.bl3.Name = "bl3";
            this.bl3.Size = new System.Drawing.Size(20, 22);
            this.bl3.TabIndex = 75;
            this.bl3.Text = "0";
            this.bl3.UseVisualStyleBackColor = true;
            this.bl3.Click += new System.EventHandler(this.bl_Click);
            this.bl3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bl4
            // 
            this.bl4.Location = new System.Drawing.Point(131, 60);
            this.bl4.Name = "bl4";
            this.bl4.Size = new System.Drawing.Size(20, 22);
            this.bl4.TabIndex = 74;
            this.bl4.Text = "0";
            this.bl4.UseVisualStyleBackColor = true;
            this.bl4.Click += new System.EventHandler(this.bl_Click);
            this.bl4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bl5
            // 
            this.bl5.Location = new System.Drawing.Point(107, 60);
            this.bl5.Name = "bl5";
            this.bl5.Size = new System.Drawing.Size(20, 22);
            this.bl5.TabIndex = 73;
            this.bl5.Text = "0";
            this.bl5.UseVisualStyleBackColor = true;
            this.bl5.Click += new System.EventHandler(this.bl_Click);
            this.bl5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bl6
            // 
            this.bl6.Location = new System.Drawing.Point(81, 60);
            this.bl6.Name = "bl6";
            this.bl6.Size = new System.Drawing.Size(20, 22);
            this.bl6.TabIndex = 72;
            this.bl6.Text = "0";
            this.bl6.UseVisualStyleBackColor = true;
            this.bl6.Click += new System.EventHandler(this.bl_Click);
            this.bl6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bl7
            // 
            this.bl7.Location = new System.Drawing.Point(55, 60);
            this.bl7.Name = "bl7";
            this.bl7.Size = new System.Drawing.Size(20, 22);
            this.bl7.TabIndex = 71;
            this.bl7.Text = "0";
            this.bl7.UseVisualStyleBackColor = true;
            this.bl7.Click += new System.EventHandler(this.bl_Click);
            this.bl7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bl8
            // 
            this.bl8.Location = new System.Drawing.Point(29, 60);
            this.bl8.Name = "bl8";
            this.bl8.Size = new System.Drawing.Size(20, 22);
            this.bl8.TabIndex = 70;
            this.bl8.Text = "0";
            this.bl8.UseVisualStyleBackColor = true;
            this.bl8.Click += new System.EventHandler(this.bl_Click);
            this.bl8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bh1
            // 
            this.bh1.Location = new System.Drawing.Point(209, 24);
            this.bh1.Name = "bh1";
            this.bh1.Size = new System.Drawing.Size(20, 22);
            this.bh1.TabIndex = 69;
            this.bh1.Text = "0";
            this.bh1.UseVisualStyleBackColor = true;
            this.bh1.Click += new System.EventHandler(this.bh_Click);
            this.bh1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bh2
            // 
            this.bh2.Location = new System.Drawing.Point(183, 24);
            this.bh2.Name = "bh2";
            this.bh2.Size = new System.Drawing.Size(20, 22);
            this.bh2.TabIndex = 68;
            this.bh2.Text = "0";
            this.bh2.UseVisualStyleBackColor = true;
            this.bh2.Click += new System.EventHandler(this.bh_Click);
            this.bh2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bh3
            // 
            this.bh3.Location = new System.Drawing.Point(157, 24);
            this.bh3.Name = "bh3";
            this.bh3.Size = new System.Drawing.Size(20, 22);
            this.bh3.TabIndex = 67;
            this.bh3.Text = "0";
            this.bh3.UseVisualStyleBackColor = true;
            this.bh3.Click += new System.EventHandler(this.bh_Click);
            this.bh3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bh4
            // 
            this.bh4.Location = new System.Drawing.Point(131, 24);
            this.bh4.Name = "bh4";
            this.bh4.Size = new System.Drawing.Size(20, 22);
            this.bh4.TabIndex = 66;
            this.bh4.Text = "0";
            this.bh4.UseVisualStyleBackColor = true;
            this.bh4.Click += new System.EventHandler(this.bh_Click);
            this.bh4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bh5
            // 
            this.bh5.Location = new System.Drawing.Point(107, 24);
            this.bh5.Name = "bh5";
            this.bh5.Size = new System.Drawing.Size(20, 22);
            this.bh5.TabIndex = 65;
            this.bh5.Text = "0";
            this.bh5.UseVisualStyleBackColor = true;
            this.bh5.Click += new System.EventHandler(this.bh_Click);
            this.bh5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bh7
            // 
            this.bh7.Location = new System.Drawing.Point(55, 24);
            this.bh7.Name = "bh7";
            this.bh7.Size = new System.Drawing.Size(20, 22);
            this.bh7.TabIndex = 64;
            this.bh7.Text = "0";
            this.bh7.UseVisualStyleBackColor = true;
            this.bh7.Click += new System.EventHandler(this.bh_Click);
            this.bh7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bh6
            // 
            this.bh6.Location = new System.Drawing.Point(81, 24);
            this.bh6.Name = "bh6";
            this.bh6.Size = new System.Drawing.Size(20, 22);
            this.bh6.TabIndex = 63;
            this.bh6.Text = "0";
            this.bh6.UseVisualStyleBackColor = true;
            this.bh6.Click += new System.EventHandler(this.bh_Click);
            this.bh6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bh8
            // 
            this.bh8.Location = new System.Drawing.Point(29, 24);
            this.bh8.Name = "bh8";
            this.bh8.Size = new System.Drawing.Size(20, 22);
            this.bh8.TabIndex = 62;
            this.bh8.Text = "0";
            this.bh8.UseVisualStyleBackColor = true;
            this.bh8.Click += new System.EventHandler(this.bh_Click);
            this.bh8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reset_al_b);
            this.panel2.Controls.Add(this.reset_ah_b);
            this.panel2.Controls.Add(this.a_hex_l_t);
            this.panel2.Controls.Add(this.a_hex_h_t);
            this.panel2.Controls.Add(this.a_hex_x_t);
            this.panel2.Controls.Add(this.al1);
            this.panel2.Controls.Add(this.al2);
            this.panel2.Controls.Add(this.al3);
            this.panel2.Controls.Add(this.al4);
            this.panel2.Controls.Add(this.al5);
            this.panel2.Controls.Add(this.al6);
            this.panel2.Controls.Add(this.al7);
            this.panel2.Controls.Add(this.al8);
            this.panel2.Controls.Add(this.ah1);
            this.panel2.Controls.Add(this.ah2);
            this.panel2.Controls.Add(this.ah3);
            this.panel2.Controls.Add(this.ah4);
            this.panel2.Controls.Add(this.ah5);
            this.panel2.Controls.Add(this.ah7);
            this.panel2.Controls.Add(this.ah6);
            this.panel2.Controls.Add(this.ah8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.a_dec_x_t);
            this.panel2.Controls.Add(this.a_dec_h_t);
            this.panel2.Controls.Add(this.a_dec_l_t);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(125, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 167);
            this.panel2.TabIndex = 78;
            // 
            // reset_al_b
            // 
            this.reset_al_b.Location = new System.Drawing.Point(235, 60);
            this.reset_al_b.Name = "reset_al_b";
            this.reset_al_b.Size = new System.Drawing.Size(47, 22);
            this.reset_al_b.TabIndex = 66;
            this.reset_al_b.Text = "Reset";
            this.reset_al_b.UseVisualStyleBackColor = true;
            this.reset_al_b.Click += new System.EventHandler(this.reset_al);
            this.reset_al_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // reset_ah_b
            // 
            this.reset_ah_b.Location = new System.Drawing.Point(235, 26);
            this.reset_ah_b.Name = "reset_ah_b";
            this.reset_ah_b.Size = new System.Drawing.Size(47, 22);
            this.reset_ah_b.TabIndex = 65;
            this.reset_ah_b.Text = "Reset";
            this.reset_ah_b.UseVisualStyleBackColor = true;
            this.reset_ah_b.Click += new System.EventHandler(this.reset_ah);
            this.reset_ah_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // a_hex_l_t
            // 
            this.a_hex_l_t.Location = new System.Drawing.Point(154, 135);
            this.a_hex_l_t.Name = "a_hex_l_t";
            this.a_hex_l_t.ReadOnly = true;
            this.a_hex_l_t.Size = new System.Drawing.Size(49, 20);
            this.a_hex_l_t.TabIndex = 64;
            this.a_hex_l_t.Text = "0x0";
            this.a_hex_l_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // a_hex_h_t
            // 
            this.a_hex_h_t.Location = new System.Drawing.Point(99, 135);
            this.a_hex_h_t.Name = "a_hex_h_t";
            this.a_hex_h_t.ReadOnly = true;
            this.a_hex_h_t.Size = new System.Drawing.Size(49, 20);
            this.a_hex_h_t.TabIndex = 63;
            this.a_hex_h_t.Text = "0x0";
            this.a_hex_h_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // a_hex_x_t
            // 
            this.a_hex_x_t.Location = new System.Drawing.Point(44, 135);
            this.a_hex_x_t.Name = "a_hex_x_t";
            this.a_hex_x_t.ReadOnly = true;
            this.a_hex_x_t.Size = new System.Drawing.Size(49, 20);
            this.a_hex_x_t.TabIndex = 62;
            this.a_hex_x_t.Text = "0x0";
            this.a_hex_x_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.reset_bl_b);
            this.panel4.Controls.Add(this.reset_bh_b);
            this.panel4.Controls.Add(this.b_hex_l_t);
            this.panel4.Controls.Add(this.bl1);
            this.panel4.Controls.Add(this.b_hex_h_t);
            this.panel4.Controls.Add(this.bl2);
            this.panel4.Controls.Add(this.b_hex_x_t);
            this.panel4.Controls.Add(this.bl3);
            this.panel4.Controls.Add(this.bl4);
            this.panel4.Controls.Add(this.bl5);
            this.panel4.Controls.Add(this.bl6);
            this.panel4.Controls.Add(this.bl7);
            this.panel4.Controls.Add(this.bl8);
            this.panel4.Controls.Add(this.bh1);
            this.panel4.Controls.Add(this.bh2);
            this.panel4.Controls.Add(this.bh3);
            this.panel4.Controls.Add(this.bh4);
            this.panel4.Controls.Add(this.bh5);
            this.panel4.Controls.Add(this.bh7);
            this.panel4.Controls.Add(this.bh6);
            this.panel4.Controls.Add(this.bh8);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.b_dec_x_t);
            this.panel4.Controls.Add(this.b_dec_h_t);
            this.panel4.Controls.Add(this.b_dec_l_t);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(413, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 167);
            this.panel4.TabIndex = 79;
            // 
            // reset_bl_b
            // 
            this.reset_bl_b.Location = new System.Drawing.Point(235, 60);
            this.reset_bl_b.Name = "reset_bl_b";
            this.reset_bl_b.Size = new System.Drawing.Size(47, 22);
            this.reset_bl_b.TabIndex = 78;
            this.reset_bl_b.Text = "Reset";
            this.reset_bl_b.UseVisualStyleBackColor = true;
            this.reset_bl_b.Click += new System.EventHandler(this.reset_bl);
            this.reset_bl_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // reset_bh_b
            // 
            this.reset_bh_b.Location = new System.Drawing.Point(235, 24);
            this.reset_bh_b.Name = "reset_bh_b";
            this.reset_bh_b.Size = new System.Drawing.Size(47, 22);
            this.reset_bh_b.TabIndex = 67;
            this.reset_bh_b.Text = "Reset";
            this.reset_bh_b.UseVisualStyleBackColor = true;
            this.reset_bh_b.Click += new System.EventHandler(this.reset_bh);
            this.reset_bh_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // b_hex_l_t
            // 
            this.b_hex_l_t.Location = new System.Drawing.Point(152, 134);
            this.b_hex_l_t.Name = "b_hex_l_t";
            this.b_hex_l_t.ReadOnly = true;
            this.b_hex_l_t.Size = new System.Drawing.Size(49, 20);
            this.b_hex_l_t.TabIndex = 67;
            this.b_hex_l_t.Text = "0x0";
            this.b_hex_l_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_hex_h_t
            // 
            this.b_hex_h_t.Location = new System.Drawing.Point(97, 134);
            this.b_hex_h_t.Name = "b_hex_h_t";
            this.b_hex_h_t.ReadOnly = true;
            this.b_hex_h_t.Size = new System.Drawing.Size(49, 20);
            this.b_hex_h_t.TabIndex = 66;
            this.b_hex_h_t.Text = "0x0";
            this.b_hex_h_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_hex_x_t
            // 
            this.b_hex_x_t.Location = new System.Drawing.Point(42, 134);
            this.b_hex_x_t.Name = "b_hex_x_t";
            this.b_hex_x_t.ReadOnly = true;
            this.b_hex_x_t.Size = new System.Drawing.Size(49, 20);
            this.b_hex_x_t.TabIndex = 65;
            this.b_hex_x_t.Text = "0x0";
            this.b_hex_x_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cl1
            // 
            this.cl1.Location = new System.Drawing.Point(209, 61);
            this.cl1.Name = "cl1";
            this.cl1.Size = new System.Drawing.Size(20, 22);
            this.cl1.TabIndex = 93;
            this.cl1.Text = "0";
            this.cl1.UseVisualStyleBackColor = true;
            this.cl1.Click += new System.EventHandler(this.cl_Click);
            this.cl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // cl2
            // 
            this.cl2.Location = new System.Drawing.Point(183, 61);
            this.cl2.Name = "cl2";
            this.cl2.Size = new System.Drawing.Size(20, 22);
            this.cl2.TabIndex = 92;
            this.cl2.Text = "0";
            this.cl2.UseVisualStyleBackColor = true;
            this.cl2.Click += new System.EventHandler(this.cl_Click);
            this.cl2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // cl3
            // 
            this.cl3.Location = new System.Drawing.Point(157, 61);
            this.cl3.Name = "cl3";
            this.cl3.Size = new System.Drawing.Size(20, 22);
            this.cl3.TabIndex = 91;
            this.cl3.Text = "0";
            this.cl3.UseVisualStyleBackColor = true;
            this.cl3.Click += new System.EventHandler(this.cl_Click);
            this.cl3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // cl4
            // 
            this.cl4.Location = new System.Drawing.Point(131, 61);
            this.cl4.Name = "cl4";
            this.cl4.Size = new System.Drawing.Size(20, 22);
            this.cl4.TabIndex = 90;
            this.cl4.Text = "0";
            this.cl4.UseVisualStyleBackColor = true;
            this.cl4.Click += new System.EventHandler(this.cl_Click);
            this.cl4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // cl5
            // 
            this.cl5.Location = new System.Drawing.Point(107, 61);
            this.cl5.Name = "cl5";
            this.cl5.Size = new System.Drawing.Size(20, 22);
            this.cl5.TabIndex = 89;
            this.cl5.Text = "0";
            this.cl5.UseVisualStyleBackColor = true;
            this.cl5.Click += new System.EventHandler(this.cl_Click);
            this.cl5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // cl6
            // 
            this.cl6.Location = new System.Drawing.Point(81, 61);
            this.cl6.Name = "cl6";
            this.cl6.Size = new System.Drawing.Size(20, 22);
            this.cl6.TabIndex = 88;
            this.cl6.Text = "0";
            this.cl6.UseVisualStyleBackColor = true;
            this.cl6.Click += new System.EventHandler(this.cl_Click);
            this.cl6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // cl7
            // 
            this.cl7.Location = new System.Drawing.Point(55, 61);
            this.cl7.Name = "cl7";
            this.cl7.Size = new System.Drawing.Size(20, 22);
            this.cl7.TabIndex = 87;
            this.cl7.Text = "0";
            this.cl7.UseVisualStyleBackColor = true;
            this.cl7.Click += new System.EventHandler(this.cl_Click);
            this.cl7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // cl8
            // 
            this.cl8.Location = new System.Drawing.Point(29, 61);
            this.cl8.Name = "cl8";
            this.cl8.Size = new System.Drawing.Size(20, 22);
            this.cl8.TabIndex = 86;
            this.cl8.Text = "0";
            this.cl8.UseVisualStyleBackColor = true;
            this.cl8.Click += new System.EventHandler(this.cl_Click);
            this.cl8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ch1
            // 
            this.ch1.Location = new System.Drawing.Point(209, 25);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(20, 22);
            this.ch1.TabIndex = 85;
            this.ch1.Text = "0";
            this.ch1.UseVisualStyleBackColor = true;
            this.ch1.Click += new System.EventHandler(this.ch_Click);
            this.ch1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ch2
            // 
            this.ch2.Location = new System.Drawing.Point(183, 25);
            this.ch2.Name = "ch2";
            this.ch2.Size = new System.Drawing.Size(20, 22);
            this.ch2.TabIndex = 84;
            this.ch2.Text = "0";
            this.ch2.UseVisualStyleBackColor = true;
            this.ch2.Click += new System.EventHandler(this.ch_Click);
            this.ch2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ch3
            // 
            this.ch3.Location = new System.Drawing.Point(157, 25);
            this.ch3.Name = "ch3";
            this.ch3.Size = new System.Drawing.Size(20, 22);
            this.ch3.TabIndex = 83;
            this.ch3.Text = "0";
            this.ch3.UseVisualStyleBackColor = true;
            this.ch3.Click += new System.EventHandler(this.ch_Click);
            this.ch3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ch4
            // 
            this.ch4.Location = new System.Drawing.Point(131, 25);
            this.ch4.Name = "ch4";
            this.ch4.Size = new System.Drawing.Size(20, 22);
            this.ch4.TabIndex = 82;
            this.ch4.Text = "0";
            this.ch4.UseVisualStyleBackColor = true;
            this.ch4.Click += new System.EventHandler(this.ch_Click);
            this.ch4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ch5
            // 
            this.ch5.Location = new System.Drawing.Point(107, 25);
            this.ch5.Name = "ch5";
            this.ch5.Size = new System.Drawing.Size(20, 22);
            this.ch5.TabIndex = 81;
            this.ch5.Text = "0";
            this.ch5.UseVisualStyleBackColor = true;
            this.ch5.Click += new System.EventHandler(this.ch_Click);
            this.ch5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ch7
            // 
            this.ch7.Location = new System.Drawing.Point(55, 25);
            this.ch7.Name = "ch7";
            this.ch7.Size = new System.Drawing.Size(20, 22);
            this.ch7.TabIndex = 80;
            this.ch7.Text = "0";
            this.ch7.UseVisualStyleBackColor = true;
            this.ch7.Click += new System.EventHandler(this.ch_Click);
            this.ch7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ch6
            // 
            this.ch6.Location = new System.Drawing.Point(81, 25);
            this.ch6.Name = "ch6";
            this.ch6.Size = new System.Drawing.Size(20, 22);
            this.ch6.TabIndex = 79;
            this.ch6.Text = "0";
            this.ch6.UseVisualStyleBackColor = true;
            this.ch6.Click += new System.EventHandler(this.ch_Click);
            this.ch6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ch8
            // 
            this.ch8.Location = new System.Drawing.Point(29, 25);
            this.ch8.Name = "ch8";
            this.ch8.Size = new System.Drawing.Size(20, 22);
            this.ch8.TabIndex = 78;
            this.ch8.Text = "0";
            this.ch8.UseVisualStyleBackColor = true;
            this.ch8.Click += new System.EventHandler(this.ch_Click);
            this.ch8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.reset_cl_b);
            this.panel5.Controls.Add(this.reset_ch_b);
            this.panel5.Controls.Add(this.c_hex_l_t);
            this.panel5.Controls.Add(this.cl1);
            this.panel5.Controls.Add(this.c_hex_h_t);
            this.panel5.Controls.Add(this.cl2);
            this.panel5.Controls.Add(this.c_hex_x_t);
            this.panel5.Controls.Add(this.cl3);
            this.panel5.Controls.Add(this.cl4);
            this.panel5.Controls.Add(this.cl5);
            this.panel5.Controls.Add(this.cl6);
            this.panel5.Controls.Add(this.cl7);
            this.panel5.Controls.Add(this.cl8);
            this.panel5.Controls.Add(this.ch1);
            this.panel5.Controls.Add(this.ch2);
            this.panel5.Controls.Add(this.ch3);
            this.panel5.Controls.Add(this.ch4);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.ch5);
            this.panel5.Controls.Add(this.c_dec_x_t);
            this.panel5.Controls.Add(this.ch7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.ch6);
            this.panel5.Controls.Add(this.ch8);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.c_dec_h_t);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.c_dec_l_t);
            this.panel5.Location = new System.Drawing.Point(701, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 167);
            this.panel5.TabIndex = 94;
            // 
            // reset_cl_b
            // 
            this.reset_cl_b.Location = new System.Drawing.Point(235, 60);
            this.reset_cl_b.Name = "reset_cl_b";
            this.reset_cl_b.Size = new System.Drawing.Size(47, 22);
            this.reset_cl_b.TabIndex = 95;
            this.reset_cl_b.Text = "Reset";
            this.reset_cl_b.UseVisualStyleBackColor = true;
            this.reset_cl_b.Click += new System.EventHandler(this.reset_cl);
            this.reset_cl_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // reset_ch_b
            // 
            this.reset_ch_b.Location = new System.Drawing.Point(235, 25);
            this.reset_ch_b.Name = "reset_ch_b";
            this.reset_ch_b.Size = new System.Drawing.Size(47, 22);
            this.reset_ch_b.TabIndex = 94;
            this.reset_ch_b.Text = "Reset";
            this.reset_ch_b.UseVisualStyleBackColor = true;
            this.reset_ch_b.Click += new System.EventHandler(this.reset_ch);
            this.reset_ch_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // c_hex_l_t
            // 
            this.c_hex_l_t.Location = new System.Drawing.Point(149, 135);
            this.c_hex_l_t.Name = "c_hex_l_t";
            this.c_hex_l_t.ReadOnly = true;
            this.c_hex_l_t.Size = new System.Drawing.Size(49, 20);
            this.c_hex_l_t.TabIndex = 80;
            this.c_hex_l_t.Text = "0x0";
            this.c_hex_l_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c_hex_h_t
            // 
            this.c_hex_h_t.Location = new System.Drawing.Point(94, 135);
            this.c_hex_h_t.Name = "c_hex_h_t";
            this.c_hex_h_t.ReadOnly = true;
            this.c_hex_h_t.Size = new System.Drawing.Size(49, 20);
            this.c_hex_h_t.TabIndex = 79;
            this.c_hex_h_t.Text = "0x0";
            this.c_hex_h_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c_hex_x_t
            // 
            this.c_hex_x_t.Location = new System.Drawing.Point(39, 135);
            this.c_hex_x_t.Name = "c_hex_x_t";
            this.c_hex_x_t.ReadOnly = true;
            this.c_hex_x_t.Size = new System.Drawing.Size(49, 20);
            this.c_hex_x_t.TabIndex = 78;
            this.c_hex_x_t.Text = "0x0";
            this.c_hex_x_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.reset_dl_b);
            this.panel6.Controls.Add(this.reset_dh_b);
            this.panel6.Controls.Add(this.d_hex_l_t);
            this.panel6.Controls.Add(this.dl1);
            this.panel6.Controls.Add(this.d_hex_h_t);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.d_hex_x_t);
            this.panel6.Controls.Add(this.dl2);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.dl3);
            this.panel6.Controls.Add(this.dh8);
            this.panel6.Controls.Add(this.dl4);
            this.panel6.Controls.Add(this.label26);
            this.panel6.Controls.Add(this.dl5);
            this.panel6.Controls.Add(this.dh6);
            this.panel6.Controls.Add(this.d_dec_x_t);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.dl6);
            this.panel6.Controls.Add(this.dh7);
            this.panel6.Controls.Add(this.dl7);
            this.panel6.Controls.Add(this.dh5);
            this.panel6.Controls.Add(this.dl8);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.dh4);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Controls.Add(this.dh1);
            this.panel6.Controls.Add(this.d_dec_h_t);
            this.panel6.Controls.Add(this.dh3);
            this.panel6.Controls.Add(this.d_dec_l_t);
            this.panel6.Controls.Add(this.dh2);
            this.panel6.Location = new System.Drawing.Point(989, 64);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(284, 167);
            this.panel6.TabIndex = 95;
            // 
            // reset_dl_b
            // 
            this.reset_dl_b.Location = new System.Drawing.Point(234, 61);
            this.reset_dl_b.Name = "reset_dl_b";
            this.reset_dl_b.Size = new System.Drawing.Size(47, 22);
            this.reset_dl_b.TabIndex = 98;
            this.reset_dl_b.Text = "Reset";
            this.reset_dl_b.UseVisualStyleBackColor = true;
            this.reset_dl_b.Click += new System.EventHandler(this.reset_dl);
            this.reset_dl_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // reset_dh_b
            // 
            this.reset_dh_b.Location = new System.Drawing.Point(234, 25);
            this.reset_dh_b.Name = "reset_dh_b";
            this.reset_dh_b.Size = new System.Drawing.Size(47, 22);
            this.reset_dh_b.TabIndex = 97;
            this.reset_dh_b.Text = "Reset";
            this.reset_dh_b.UseVisualStyleBackColor = true;
            this.reset_dh_b.Click += new System.EventHandler(this.reset_dh);
            this.reset_dh_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // d_hex_l_t
            // 
            this.d_hex_l_t.Location = new System.Drawing.Point(160, 134);
            this.d_hex_l_t.Name = "d_hex_l_t";
            this.d_hex_l_t.ReadOnly = true;
            this.d_hex_l_t.Size = new System.Drawing.Size(49, 20);
            this.d_hex_l_t.TabIndex = 96;
            this.d_hex_l_t.Text = "0x0";
            this.d_hex_l_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dl1
            // 
            this.dl1.Location = new System.Drawing.Point(209, 61);
            this.dl1.Name = "dl1";
            this.dl1.Size = new System.Drawing.Size(20, 22);
            this.dl1.TabIndex = 78;
            this.dl1.Text = "0";
            this.dl1.UseVisualStyleBackColor = true;
            this.dl1.Click += new System.EventHandler(this.dl_Click);
            this.dl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // d_hex_h_t
            // 
            this.d_hex_h_t.Location = new System.Drawing.Point(105, 134);
            this.d_hex_h_t.Name = "d_hex_h_t";
            this.d_hex_h_t.ReadOnly = true;
            this.d_hex_h_t.Size = new System.Drawing.Size(49, 20);
            this.d_hex_h_t.TabIndex = 95;
            this.d_hex_h_t.Text = "0x0";
            this.d_hex_h_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d_hex_x_t
            // 
            this.d_hex_x_t.Location = new System.Drawing.Point(50, 134);
            this.d_hex_x_t.Name = "d_hex_x_t";
            this.d_hex_x_t.ReadOnly = true;
            this.d_hex_x_t.Size = new System.Drawing.Size(49, 20);
            this.d_hex_x_t.TabIndex = 94;
            this.d_hex_x_t.Text = "0x0";
            this.d_hex_x_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dl2
            // 
            this.dl2.Location = new System.Drawing.Point(183, 61);
            this.dl2.Name = "dl2";
            this.dl2.Size = new System.Drawing.Size(20, 22);
            this.dl2.TabIndex = 77;
            this.dl2.Text = "0";
            this.dl2.UseVisualStyleBackColor = true;
            this.dl2.Click += new System.EventHandler(this.dl_Click);
            this.dl2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dl3
            // 
            this.dl3.Location = new System.Drawing.Point(157, 61);
            this.dl3.Name = "dl3";
            this.dl3.Size = new System.Drawing.Size(20, 22);
            this.dl3.TabIndex = 76;
            this.dl3.Text = "0";
            this.dl3.UseVisualStyleBackColor = true;
            this.dl3.Click += new System.EventHandler(this.dl_Click);
            this.dl3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dh8
            // 
            this.dh8.Location = new System.Drawing.Point(29, 25);
            this.dh8.Name = "dh8";
            this.dh8.Size = new System.Drawing.Size(20, 22);
            this.dh8.TabIndex = 63;
            this.dh8.Text = "0";
            this.dh8.UseVisualStyleBackColor = true;
            this.dh8.Click += new System.EventHandler(this.dh_Click);
            this.dh8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dl4
            // 
            this.dl4.Location = new System.Drawing.Point(131, 61);
            this.dl4.Name = "dl4";
            this.dl4.Size = new System.Drawing.Size(20, 22);
            this.dl4.TabIndex = 75;
            this.dl4.Text = "0";
            this.dl4.UseVisualStyleBackColor = true;
            this.dl4.Click += new System.EventHandler(this.dl_Click);
            this.dl4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dl5
            // 
            this.dl5.Location = new System.Drawing.Point(107, 61);
            this.dl5.Name = "dl5";
            this.dl5.Size = new System.Drawing.Size(20, 22);
            this.dl5.TabIndex = 74;
            this.dl5.Text = "0";
            this.dl5.UseVisualStyleBackColor = true;
            this.dl5.Click += new System.EventHandler(this.dl_Click);
            this.dl5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dh6
            // 
            this.dh6.Location = new System.Drawing.Point(81, 25);
            this.dh6.Name = "dh6";
            this.dh6.Size = new System.Drawing.Size(20, 22);
            this.dh6.TabIndex = 64;
            this.dh6.Text = "0";
            this.dh6.UseVisualStyleBackColor = true;
            this.dh6.Click += new System.EventHandler(this.dh_Click);
            this.dh6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dl6
            // 
            this.dl6.Location = new System.Drawing.Point(81, 61);
            this.dl6.Name = "dl6";
            this.dl6.Size = new System.Drawing.Size(20, 22);
            this.dl6.TabIndex = 73;
            this.dl6.Text = "0";
            this.dl6.UseVisualStyleBackColor = true;
            this.dl6.Click += new System.EventHandler(this.dl_Click);
            this.dl6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dh7
            // 
            this.dh7.Location = new System.Drawing.Point(55, 25);
            this.dh7.Name = "dh7";
            this.dh7.Size = new System.Drawing.Size(20, 22);
            this.dh7.TabIndex = 65;
            this.dh7.Text = "0";
            this.dh7.UseVisualStyleBackColor = true;
            this.dh7.Click += new System.EventHandler(this.dh_Click);
            this.dh7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dl7
            // 
            this.dl7.Location = new System.Drawing.Point(55, 61);
            this.dl7.Name = "dl7";
            this.dl7.Size = new System.Drawing.Size(20, 22);
            this.dl7.TabIndex = 72;
            this.dl7.Text = "0";
            this.dl7.UseVisualStyleBackColor = true;
            this.dl7.Click += new System.EventHandler(this.dl_Click);
            this.dl7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dh5
            // 
            this.dh5.Location = new System.Drawing.Point(107, 25);
            this.dh5.Name = "dh5";
            this.dh5.Size = new System.Drawing.Size(20, 22);
            this.dh5.TabIndex = 66;
            this.dh5.Text = "0";
            this.dh5.UseVisualStyleBackColor = true;
            this.dh5.Click += new System.EventHandler(this.dh_Click);
            this.dh5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dl8
            // 
            this.dl8.Location = new System.Drawing.Point(29, 61);
            this.dl8.Name = "dl8";
            this.dl8.Size = new System.Drawing.Size(20, 22);
            this.dl8.TabIndex = 71;
            this.dl8.Text = "0";
            this.dl8.UseVisualStyleBackColor = true;
            this.dl8.Click += new System.EventHandler(this.dl_Click);
            this.dl8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dh4
            // 
            this.dh4.Location = new System.Drawing.Point(131, 25);
            this.dh4.Name = "dh4";
            this.dh4.Size = new System.Drawing.Size(20, 22);
            this.dh4.TabIndex = 67;
            this.dh4.Text = "0";
            this.dh4.UseVisualStyleBackColor = true;
            this.dh4.Click += new System.EventHandler(this.dh_Click);
            this.dh4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dh1
            // 
            this.dh1.Location = new System.Drawing.Point(209, 25);
            this.dh1.Name = "dh1";
            this.dh1.Size = new System.Drawing.Size(20, 22);
            this.dh1.TabIndex = 70;
            this.dh1.Text = "0";
            this.dh1.UseVisualStyleBackColor = true;
            this.dh1.Click += new System.EventHandler(this.dh_Click);
            this.dh1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dh3
            // 
            this.dh3.Location = new System.Drawing.Point(157, 25);
            this.dh3.Name = "dh3";
            this.dh3.Size = new System.Drawing.Size(20, 22);
            this.dh3.TabIndex = 68;
            this.dh3.Text = "0";
            this.dh3.UseVisualStyleBackColor = true;
            this.dh3.Click += new System.EventHandler(this.dh_Click);
            this.dh3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dh2
            // 
            this.dh2.Location = new System.Drawing.Point(183, 25);
            this.dh2.Name = "dh2";
            this.dh2.Size = new System.Drawing.Size(20, 22);
            this.dh2.TabIndex = 69;
            this.dh2.Text = "0";
            this.dh2.UseVisualStyleBackColor = true;
            this.dh2.Click += new System.EventHandler(this.dh_Click);
            this.dh2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(24, 105);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(79, 24);
            this.label27.TabIndex = 96;
            this.label27.Text = "Binarnie";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(10, 168);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(109, 24);
            this.label28.TabIndex = 97;
            this.label28.Text = "Decymalnie";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(18, 199);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(85, 24);
            this.label29.TabIndex = 98;
            this.label29.Text = "Hexalnie";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dl_d_rb);
            this.panel7.Controls.Add(this.cl_d_rb);
            this.panel7.Controls.Add(this.dh_d_rb);
            this.panel7.Controls.Add(this.ch_d_rb);
            this.panel7.Controls.Add(this.bl_d_rb);
            this.panel7.Controls.Add(this.bh_d_rb);
            this.panel7.Controls.Add(this.al_d_rb);
            this.panel7.Controls.Add(this.ah_d_rb);
            this.panel7.Location = new System.Drawing.Point(431, 259);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(57, 188);
            this.panel7.TabIndex = 27;
            // 
            // dl_d_rb
            // 
            this.dl_d_rb.AutoSize = true;
            this.dl_d_rb.Location = new System.Drawing.Point(11, 160);
            this.dl_d_rb.Name = "dl_d_rb";
            this.dl_d_rb.Size = new System.Drawing.Size(39, 17);
            this.dl_d_rb.TabIndex = 10;
            this.dl_d_rb.Text = "DL";
            this.dl_d_rb.UseVisualStyleBackColor = true;
            this.dl_d_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // cl_d_rb
            // 
            this.cl_d_rb.AutoSize = true;
            this.cl_d_rb.Location = new System.Drawing.Point(11, 116);
            this.cl_d_rb.Name = "cl_d_rb";
            this.cl_d_rb.Size = new System.Drawing.Size(38, 17);
            this.cl_d_rb.TabIndex = 5;
            this.cl_d_rb.Text = "CL";
            this.cl_d_rb.UseVisualStyleBackColor = true;
            this.cl_d_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // dh_d_rb
            // 
            this.dh_d_rb.AutoSize = true;
            this.dh_d_rb.Location = new System.Drawing.Point(11, 139);
            this.dh_d_rb.Name = "dh_d_rb";
            this.dh_d_rb.Size = new System.Drawing.Size(41, 17);
            this.dh_d_rb.TabIndex = 9;
            this.dh_d_rb.Text = "DH";
            this.dh_d_rb.UseVisualStyleBackColor = true;
            this.dh_d_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ch_d_rb
            // 
            this.ch_d_rb.AutoSize = true;
            this.ch_d_rb.Location = new System.Drawing.Point(11, 95);
            this.ch_d_rb.Name = "ch_d_rb";
            this.ch_d_rb.Size = new System.Drawing.Size(40, 17);
            this.ch_d_rb.TabIndex = 4;
            this.ch_d_rb.Text = "CH";
            this.ch_d_rb.UseVisualStyleBackColor = true;
            this.ch_d_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bl_d_rb
            // 
            this.bl_d_rb.AutoSize = true;
            this.bl_d_rb.Location = new System.Drawing.Point(11, 72);
            this.bl_d_rb.Name = "bl_d_rb";
            this.bl_d_rb.Size = new System.Drawing.Size(38, 17);
            this.bl_d_rb.TabIndex = 3;
            this.bl_d_rb.Text = "BL";
            this.bl_d_rb.UseVisualStyleBackColor = true;
            this.bl_d_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // bh_d_rb
            // 
            this.bh_d_rb.AutoSize = true;
            this.bh_d_rb.Location = new System.Drawing.Point(11, 49);
            this.bh_d_rb.Name = "bh_d_rb";
            this.bh_d_rb.Size = new System.Drawing.Size(40, 17);
            this.bh_d_rb.TabIndex = 2;
            this.bh_d_rb.Text = "BH";
            this.bh_d_rb.UseVisualStyleBackColor = true;
            this.bh_d_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // al_d_rb
            // 
            this.al_d_rb.AutoSize = true;
            this.al_d_rb.Location = new System.Drawing.Point(11, 26);
            this.al_d_rb.Name = "al_d_rb";
            this.al_d_rb.Size = new System.Drawing.Size(38, 17);
            this.al_d_rb.TabIndex = 1;
            this.al_d_rb.Text = "AL";
            this.al_d_rb.UseVisualStyleBackColor = true;
            this.al_d_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ah_d_rb
            // 
            this.ah_d_rb.AutoSize = true;
            this.ah_d_rb.Checked = true;
            this.ah_d_rb.Location = new System.Drawing.Point(11, 3);
            this.ah_d_rb.Name = "ah_d_rb";
            this.ah_d_rb.Size = new System.Drawing.Size(40, 17);
            this.ah_d_rb.TabIndex = 0;
            this.ah_d_rb.TabStop = true;
            this.ah_d_rb.Text = "AH";
            this.ah_d_rb.UseVisualStyleBackColor = true;
            this.ah_d_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(362, 303);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 17);
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // wykonaj_b
            // 
            this.wykonaj_b.BackgroundImage = global::Zad1.Properties.Resources.images1;
            this.wykonaj_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wykonaj_b.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wykonaj_b.Location = new System.Drawing.Point(256, 487);
            this.wykonaj_b.Name = "wykonaj_b";
            this.wykonaj_b.Size = new System.Drawing.Size(157, 52);
            this.wykonaj_b.TabIndex = 101;
            this.wykonaj_b.Text = "Wykonaj";
            this.wykonaj_b.UseVisualStyleBackColor = false;
            this.wykonaj_b.Click += new System.EventHandler(this.wykonaj_b_Click);
            this.wykonaj_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // krkowo_b
            // 
            this.krkowo_b.BackgroundImage = global::Zad1.Properties.Resources.images1;
            this.krkowo_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.krkowo_b.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.krkowo_b.Location = new System.Drawing.Point(850, 299);
            this.krkowo_b.Name = "krkowo_b";
            this.krkowo_b.Size = new System.Drawing.Size(92, 40);
            this.krkowo_b.TabIndex = 102;
            this.krkowo_b.Text = "Wykonywanie \r\nkrokowe";
            this.krkowo_b.UseVisualStyleBackColor = false;
            this.krkowo_b.Click += new System.EventHandler(this.kom_read);
            this.krkowo_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // caly_b
            // 
            this.caly_b.BackgroundImage = global::Zad1.Properties.Resources.images1;
            this.caly_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.caly_b.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.caly_b.Location = new System.Drawing.Point(850, 342);
            this.caly_b.Name = "caly_b";
            this.caly_b.Size = new System.Drawing.Size(92, 40);
            this.caly_b.TabIndex = 103;
            this.caly_b.Text = "Wykkonanie całej \r\nsekwencji na raz";
            this.caly_b.UseVisualStyleBackColor = false;
            this.caly_b.Click += new System.EventHandler(this.caly_b_Click);
            this.caly_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // plik_odczyt_b
            // 
            this.plik_odczyt_b.BackgroundImage = global::Zad1.Properties.Resources.images1;
            this.plik_odczyt_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plik_odczyt_b.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plik_odczyt_b.Location = new System.Drawing.Point(948, 342);
            this.plik_odczyt_b.Name = "plik_odczyt_b";
            this.plik_odczyt_b.Size = new System.Drawing.Size(90, 40);
            this.plik_odczyt_b.TabIndex = 105;
            this.plik_odczyt_b.Text = "Odczyt sekwencji \r\nz pliku";
            this.plik_odczyt_b.UseVisualStyleBackColor = false;
            this.plik_odczyt_b.Click += new System.EventHandler(this.plik_odczyt_b_Click);
            this.plik_odczyt_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // plik_zapis_b
            // 
            this.plik_zapis_b.BackgroundImage = global::Zad1.Properties.Resources.images1;
            this.plik_zapis_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plik_zapis_b.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plik_zapis_b.Location = new System.Drawing.Point(948, 299);
            this.plik_zapis_b.Name = "plik_zapis_b";
            this.plik_zapis_b.Size = new System.Drawing.Size(90, 40);
            this.plik_zapis_b.TabIndex = 104;
            this.plik_zapis_b.Text = "Zapis sekwencji\r\ndo pliku";
            this.plik_zapis_b.UseVisualStyleBackColor = false;
            this.plik_zapis_b.Click += new System.EventHandler(this.plik_zapis_b_Click);
            this.plik_zapis_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // reset_kom_b
            // 
            this.reset_kom_b.Location = new System.Drawing.Point(692, 540);
            this.reset_kom_b.Name = "reset_kom_b";
            this.reset_kom_b.Size = new System.Drawing.Size(75, 23);
            this.reset_kom_b.TabIndex = 106;
            this.reset_kom_b.Text = "Wyczyść";
            this.reset_kom_b.UseVisualStyleBackColor = true;
            this.reset_kom_b.Click += new System.EventHandler(this.reset_kom_b_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.sec5_rb);
            this.panel8.Controls.Add(this.sec3_rb);
            this.panel8.Controls.Add(this.sec1_rb);
            this.panel8.Controls.Add(this.sec_rb);
            this.panel8.Location = new System.Drawing.Point(842, 438);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(229, 26);
            this.panel8.TabIndex = 108;
            // 
            // sec5_rb
            // 
            this.sec5_rb.AutoSize = true;
            this.sec5_rb.Location = new System.Drawing.Point(166, 2);
            this.sec5_rb.Name = "sec5_rb";
            this.sec5_rb.Size = new System.Drawing.Size(51, 17);
            this.sec5_rb.TabIndex = 3;
            this.sec5_rb.Text = "5 sec";
            this.sec5_rb.UseVisualStyleBackColor = true;
            this.sec5_rb.Click += new System.EventHandler(this.time_change);
            this.sec5_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // sec3_rb
            // 
            this.sec3_rb.AutoSize = true;
            this.sec3_rb.Location = new System.Drawing.Point(118, 2);
            this.sec3_rb.Name = "sec3_rb";
            this.sec3_rb.Size = new System.Drawing.Size(51, 17);
            this.sec3_rb.TabIndex = 2;
            this.sec3_rb.Text = "3 sec";
            this.sec3_rb.UseVisualStyleBackColor = true;
            this.sec3_rb.Click += new System.EventHandler(this.time_change);
            this.sec3_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // sec1_rb
            // 
            this.sec1_rb.AutoSize = true;
            this.sec1_rb.Location = new System.Drawing.Point(61, 2);
            this.sec1_rb.Name = "sec1_rb";
            this.sec1_rb.Size = new System.Drawing.Size(51, 17);
            this.sec1_rb.TabIndex = 1;
            this.sec1_rb.Text = "1 sec";
            this.sec1_rb.UseVisualStyleBackColor = true;
            this.sec1_rb.Click += new System.EventHandler(this.time_change);
            this.sec1_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // sec_rb
            // 
            this.sec_rb.AutoSize = true;
            this.sec_rb.Checked = true;
            this.sec_rb.Location = new System.Drawing.Point(4, 2);
            this.sec_rb.Name = "sec_rb";
            this.sec_rb.Size = new System.Drawing.Size(60, 17);
            this.sec_rb.TabIndex = 0;
            this.sec_rb.TabStop = true;
            this.sec_rb.Text = "0.5 sec";
            this.sec_rb.UseVisualStyleBackColor = true;
            this.sec_rb.Click += new System.EventHandler(this.time_change);
            this.sec_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(914, 424);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(71, 13);
            this.label30.TabIndex = 109;
            this.label30.Text = "Częstotliwość";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Zad1.Properties.Resources.images1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1120, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 52);
            this.button1.TabIndex = 110;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pause_b
            // 
            this.pause_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pause_b.BackgroundImage")));
            this.pause_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pause_b.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pause_b.Location = new System.Drawing.Point(850, 478);
            this.pause_b.Name = "pause_b";
            this.pause_b.Size = new System.Drawing.Size(102, 44);
            this.pause_b.TabIndex = 111;
            this.pause_b.UseVisualStyleBackColor = true;
            this.pause_b.Click += new System.EventHandler(this.pause_b_Click);
            this.pause_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // play_b
            // 
            this.play_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play_b.BackgroundImage")));
            this.play_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play_b.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.play_b.Location = new System.Drawing.Point(958, 478);
            this.play_b.Name = "play_b";
            this.play_b.Size = new System.Drawing.Size(102, 44);
            this.play_b.TabIndex = 112;
            this.play_b.UseVisualStyleBackColor = true;
            this.play_b.Click += new System.EventHandler(this.play_b_Click);
            this.play_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.przerwanie_ch);
            this.panel9.Controls.Add(this.przerwanie_p);
            this.panel9.Location = new System.Drawing.Point(488, 262);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(126, 288);
            this.panel9.TabIndex = 113;
            // 
            // przerwanie_ch
            // 
            this.przerwanie_ch.AutoSize = true;
            this.przerwanie_ch.Location = new System.Drawing.Point(10, 6);
            this.przerwanie_ch.Name = "przerwanie_ch";
            this.przerwanie_ch.Size = new System.Drawing.Size(78, 17);
            this.przerwanie_ch.TabIndex = 124;
            this.przerwanie_ch.Text = "Przerwanie";
            this.przerwanie_ch.UseVisualStyleBackColor = true;
            this.przerwanie_ch.CheckedChanged += new System.EventHandler(this.przerwanie_CheckedChanged);
            this.przerwanie_ch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // przerwanie_p
            // 
            this.przerwanie_p.Controls.Add(this.przerwanie_b);
            this.przerwanie_p.Controls.Add(this.spr_czy_nac_rb);
            this.przerwanie_p.Controls.Add(this.zaczekaj_rb);
            this.przerwanie_p.Controls.Add(this.stan_klawiatury_rb);
            this.przerwanie_p.Controls.Add(this.odczytaj_znak_rb);
            this.przerwanie_p.Controls.Add(this.pobierz_dat_rb);
            this.przerwanie_p.Controls.Add(this.ustaw_dat_rb);
            this.przerwanie_p.Controls.Add(this.pobierz_godz_rb);
            this.przerwanie_p.Controls.Add(this.ustaw_godz_rb);
            this.przerwanie_p.Controls.Add(this.screen_shot_rb);
            this.przerwanie_p.Location = new System.Drawing.Point(6, 32);
            this.przerwanie_p.Name = "przerwanie_p";
            this.przerwanie_p.Size = new System.Drawing.Size(120, 253);
            this.przerwanie_p.TabIndex = 123;
            this.przerwanie_p.Visible = false;
            // 
            // przerwanie_b
            // 
            this.przerwanie_b.Location = new System.Drawing.Point(16, 223);
            this.przerwanie_b.Name = "przerwanie_b";
            this.przerwanie_b.Size = new System.Drawing.Size(75, 23);
            this.przerwanie_b.TabIndex = 122;
            this.przerwanie_b.Text = "Wykonaj";
            this.przerwanie_b.UseVisualStyleBackColor = true;
            this.przerwanie_b.Click += new System.EventHandler(this.przerwanie_Click);
            this.przerwanie_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // spr_czy_nac_rb
            // 
            this.spr_czy_nac_rb.AutoSize = true;
            this.spr_czy_nac_rb.Location = new System.Drawing.Point(8, 187);
            this.spr_czy_nac_rb.Name = "spr_czy_nac_rb";
            this.spr_czy_nac_rb.Size = new System.Drawing.Size(110, 30);
            this.spr_czy_nac_rb.TabIndex = 120;
            this.spr_czy_nac_rb.Text = "Sprawdź czy \r\nnaciśnięto klawisz";
            this.spr_czy_nac_rb.UseVisualStyleBackColor = true;
            this.spr_czy_nac_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // zaczekaj_rb
            // 
            this.zaczekaj_rb.AutoSize = true;
            this.zaczekaj_rb.Location = new System.Drawing.Point(8, 166);
            this.zaczekaj_rb.Name = "zaczekaj_rb";
            this.zaczekaj_rb.Size = new System.Drawing.Size(83, 17);
            this.zaczekaj_rb.TabIndex = 119;
            this.zaczekaj_rb.Text = "Zaczekaj 5s";
            this.zaczekaj_rb.UseVisualStyleBackColor = true;
            this.zaczekaj_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // stan_klawiatury_rb
            // 
            this.stan_klawiatury_rb.AutoSize = true;
            this.stan_klawiatury_rb.Location = new System.Drawing.Point(8, 143);
            this.stan_klawiatury_rb.Name = "stan_klawiatury_rb";
            this.stan_klawiatury_rb.Size = new System.Drawing.Size(97, 17);
            this.stan_klawiatury_rb.TabIndex = 118;
            this.stan_klawiatury_rb.Text = "Stan klawiatury";
            this.stan_klawiatury_rb.UseVisualStyleBackColor = true;
            this.stan_klawiatury_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // odczytaj_znak_rb
            // 
            this.odczytaj_znak_rb.AutoSize = true;
            this.odczytaj_znak_rb.Location = new System.Drawing.Point(8, 120);
            this.odczytaj_znak_rb.Name = "odczytaj_znak_rb";
            this.odczytaj_znak_rb.Size = new System.Drawing.Size(92, 17);
            this.odczytaj_znak_rb.TabIndex = 117;
            this.odczytaj_znak_rb.Text = "Odczytaj znak";
            this.odczytaj_znak_rb.UseVisualStyleBackColor = true;
            this.odczytaj_znak_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // pobierz_dat_rb
            // 
            this.pobierz_dat_rb.AutoSize = true;
            this.pobierz_dat_rb.Location = new System.Drawing.Point(8, 97);
            this.pobierz_dat_rb.Name = "pobierz_dat_rb";
            this.pobierz_dat_rb.Size = new System.Drawing.Size(87, 17);
            this.pobierz_dat_rb.TabIndex = 116;
            this.pobierz_dat_rb.Text = "Pobierz datę ";
            this.pobierz_dat_rb.UseVisualStyleBackColor = true;
            this.pobierz_dat_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ustaw_dat_rb
            // 
            this.ustaw_dat_rb.AutoSize = true;
            this.ustaw_dat_rb.Location = new System.Drawing.Point(8, 74);
            this.ustaw_dat_rb.Name = "ustaw_dat_rb";
            this.ustaw_dat_rb.Size = new System.Drawing.Size(79, 17);
            this.ustaw_dat_rb.TabIndex = 115;
            this.ustaw_dat_rb.Text = "Ustaw datę";
            this.ustaw_dat_rb.UseVisualStyleBackColor = true;
            this.ustaw_dat_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // pobierz_godz_rb
            // 
            this.pobierz_godz_rb.AutoSize = true;
            this.pobierz_godz_rb.Location = new System.Drawing.Point(8, 51);
            this.pobierz_godz_rb.Name = "pobierz_godz_rb";
            this.pobierz_godz_rb.Size = new System.Drawing.Size(100, 17);
            this.pobierz_godz_rb.TabIndex = 114;
            this.pobierz_godz_rb.Text = "Pobierz godzinę";
            this.pobierz_godz_rb.UseVisualStyleBackColor = true;
            this.pobierz_godz_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // ustaw_godz_rb
            // 
            this.ustaw_godz_rb.AutoSize = true;
            this.ustaw_godz_rb.Location = new System.Drawing.Point(8, 28);
            this.ustaw_godz_rb.Name = "ustaw_godz_rb";
            this.ustaw_godz_rb.Size = new System.Drawing.Size(95, 17);
            this.ustaw_godz_rb.TabIndex = 113;
            this.ustaw_godz_rb.Text = "Ustaw godzinę";
            this.ustaw_godz_rb.UseVisualStyleBackColor = true;
            this.ustaw_godz_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // screen_shot_rb
            // 
            this.screen_shot_rb.AutoSize = true;
            this.screen_shot_rb.Checked = true;
            this.screen_shot_rb.Location = new System.Drawing.Point(8, 5);
            this.screen_shot_rb.Name = "screen_shot_rb";
            this.screen_shot_rb.Size = new System.Drawing.Size(79, 17);
            this.screen_shot_rb.TabIndex = 112;
            this.screen_shot_rb.TabStop = true;
            this.screen_shot_rb.Text = "Screenshot";
            this.screen_shot_rb.UseVisualStyleBackColor = true;
            this.screen_shot_rb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // picture
            // 
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.Location = new System.Drawing.Point(1070, 303);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(200, 128);
            this.picture.TabIndex = 114;
            this.picture.TabStop = false;
            // 
            // godzina_t
            // 
            this.godzina_t.Location = new System.Drawing.Point(1149, 453);
            this.godzina_t.Name = "godzina_t";
            this.godzina_t.ReadOnly = true;
            this.godzina_t.Size = new System.Drawing.Size(69, 20);
            this.godzina_t.TabIndex = 99;
            this.godzina_t.Text = "00:00";
            this.godzina_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // data_t
            // 
            this.data_t.Location = new System.Drawing.Point(1120, 479);
            this.data_t.Name = "data_t";
            this.data_t.ReadOnly = true;
            this.data_t.Size = new System.Drawing.Size(121, 20);
            this.data_t.TabIndex = 115;
            this.data_t.Text = "00.00.0000";
            this.data_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer_przer
            // 
            this.timer_przer.Interval = 5000;
            this.timer_przer.Tick += new System.EventHandler(this.timer_przer_Tick);
            // 
            // zaczekaj
            // 
            this.zaczekaj.Interval = 5000;
            this.zaczekaj.Tick += new System.EventHandler(this.zaczekaj_Tick);
            // 
            // zaczekaj_t
            // 
            this.zaczekaj_t.Location = new System.Drawing.Point(582, 460);
            this.zaczekaj_t.Name = "zaczekaj_t";
            this.zaczekaj_t.ReadOnly = true;
            this.zaczekaj_t.Size = new System.Drawing.Size(12, 20);
            this.zaczekaj_t.TabIndex = 10;
            this.zaczekaj_t.Text = "0";
            this.zaczekaj_t.Visible = false;
            // 
            // zaczekaj5
            // 
            this.zaczekaj5.Interval = 1000;
            this.zaczekaj5.Tick += new System.EventHandler(this.zaczekaj5_Tick);
            // 
            // zatrzask_tim
            // 
            this.zatrzask_tim.Interval = 10;
            this.zatrzask_tim.Tick += new System.EventHandler(this.zatrzask_tim_Tick);
            // 
            // Symulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 582);
            this.Controls.Add(this.zaczekaj_t);
            this.Controls.Add(this.data_t);
            this.Controls.Add(this.godzina_t);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.play_b);
            this.Controls.Add(this.pause_b);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.reset_kom_b);
            this.Controls.Add(this.plik_odczyt_b);
            this.Controls.Add(this.plik_zapis_b);
            this.Controls.Add(this.caly_b);
            this.Controls.Add(this.krkowo_b);
            this.Controls.Add(this.wykonaj_b);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.wartosc_p);
            this.Controls.Add(this.dodaj_b);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.komendy_t);
            this.Controls.Add(this.label14);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Symulator";
            this.Text = "Symulator rejestrów";
            this.Load += new System.EventHandler(this.Symulator_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.wartosc_p.ResumeLayout(false);
            this.wartosc_p.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.przerwanie_p.ResumeLayout(false);
            this.przerwanie_p.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox komendy_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton add_rb;
        private System.Windows.Forms.RadioButton sub_rb;
        private System.Windows.Forms.RadioButton mov_rb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox wartosc_t;
        private System.Windows.Forms.RadioButton wartosc_rb;
        private System.Windows.Forms.RadioButton cl_rb;
        private System.Windows.Forms.RadioButton ch_rb;
        private System.Windows.Forms.RadioButton bl_rb;
        private System.Windows.Forms.RadioButton bh_rb;
        private System.Windows.Forms.RadioButton al_rb;
        private System.Windows.Forms.RadioButton ah_rb;
        private System.Windows.Forms.Panel wartosc_p;
        private System.Windows.Forms.RadioButton hexalnie_rb;
        private System.Windows.Forms.RadioButton decymalnie_rb;
        private System.Windows.Forms.Button dodaj_b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox a_dec_h_t;
        private System.Windows.Forms.TextBox a_dec_l_t;
        private System.Windows.Forms.TextBox b_dec_h_t;
        private System.Windows.Forms.TextBox b_dec_l_t;
        private System.Windows.Forms.TextBox c_dec_h_t;
        private System.Windows.Forms.TextBox c_dec_l_t;
        private System.Windows.Forms.TextBox d_dec_h_t;
        private System.Windows.Forms.TextBox d_dec_l_t;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox d_dec_x_t;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox c_dec_x_t;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox b_dec_x_t;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox a_dec_x_t;
        private System.Windows.Forms.Button ah8;
        private System.Windows.Forms.Button ah6;
        private System.Windows.Forms.Button ah7;
        private System.Windows.Forms.Button ah5;
        private System.Windows.Forms.Button ah4;
        private System.Windows.Forms.Button ah3;
        private System.Windows.Forms.Button ah2;
        private System.Windows.Forms.Button ah1;
        private System.Windows.Forms.Button al8;
        private System.Windows.Forms.Button al7;
        private System.Windows.Forms.Button al6;
        private System.Windows.Forms.Button al5;
        private System.Windows.Forms.Button al4;
        private System.Windows.Forms.Button al3;
        private System.Windows.Forms.Button al2;
        private System.Windows.Forms.Button al1;
        private System.Windows.Forms.Button bl1;
        private System.Windows.Forms.Button bl2;
        private System.Windows.Forms.Button bl3;
        private System.Windows.Forms.Button bl4;
        private System.Windows.Forms.Button bl5;
        private System.Windows.Forms.Button bl6;
        private System.Windows.Forms.Button bl7;
        private System.Windows.Forms.Button bl8;
        private System.Windows.Forms.Button bh1;
        private System.Windows.Forms.Button bh2;
        private System.Windows.Forms.Button bh3;
        private System.Windows.Forms.Button bh4;
        private System.Windows.Forms.Button bh5;
        private System.Windows.Forms.Button bh7;
        private System.Windows.Forms.Button bh6;
        private System.Windows.Forms.Button bh8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button cl1;
        private System.Windows.Forms.Button cl2;
        private System.Windows.Forms.Button cl3;
        private System.Windows.Forms.Button cl4;
        private System.Windows.Forms.Button cl5;
        private System.Windows.Forms.Button cl6;
        private System.Windows.Forms.Button cl7;
        private System.Windows.Forms.Button cl8;
        private System.Windows.Forms.Button ch1;
        private System.Windows.Forms.Button ch2;
        private System.Windows.Forms.Button ch3;
        private System.Windows.Forms.Button ch4;
        private System.Windows.Forms.Button ch5;
        private System.Windows.Forms.Button ch7;
        private System.Windows.Forms.Button ch6;
        private System.Windows.Forms.Button ch8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox a_hex_l_t;
        private System.Windows.Forms.TextBox a_hex_h_t;
        private System.Windows.Forms.TextBox a_hex_x_t;
        private System.Windows.Forms.TextBox b_hex_l_t;
        private System.Windows.Forms.TextBox b_hex_h_t;
        private System.Windows.Forms.TextBox b_hex_x_t;
        private System.Windows.Forms.TextBox c_hex_l_t;
        private System.Windows.Forms.TextBox c_hex_h_t;
        private System.Windows.Forms.TextBox c_hex_x_t;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox d_hex_l_t;
        private System.Windows.Forms.Button dl1;
        private System.Windows.Forms.TextBox d_hex_h_t;
        private System.Windows.Forms.TextBox d_hex_x_t;
        private System.Windows.Forms.Button dl2;
        private System.Windows.Forms.Button dl3;
        private System.Windows.Forms.Button dh8;
        private System.Windows.Forms.Button dl4;
        private System.Windows.Forms.Button dl5;
        private System.Windows.Forms.Button dh6;
        private System.Windows.Forms.Button dl6;
        private System.Windows.Forms.Button dh7;
        private System.Windows.Forms.Button dl7;
        private System.Windows.Forms.Button dh5;
        private System.Windows.Forms.Button dl8;
        private System.Windows.Forms.Button dh4;
        private System.Windows.Forms.Button dh1;
        private System.Windows.Forms.Button dh3;
        private System.Windows.Forms.Button dh2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button reset_al_b;
        private System.Windows.Forms.Button reset_ah_b;
        private System.Windows.Forms.Button reset_bl_b;
        private System.Windows.Forms.Button reset_bh_b;
        private System.Windows.Forms.Button reset_cl_b;
        private System.Windows.Forms.Button reset_ch_b;
        private System.Windows.Forms.Button reset_dl_b;
        private System.Windows.Forms.Button reset_dh_b;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton cl_d_rb;
        private System.Windows.Forms.RadioButton ch_d_rb;
        private System.Windows.Forms.RadioButton bl_d_rb;
        private System.Windows.Forms.RadioButton bh_d_rb;
        private System.Windows.Forms.RadioButton al_d_rb;
        private System.Windows.Forms.RadioButton ah_d_rb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button wykonaj_b;
        private System.Windows.Forms.Button krkowo_b;
        private System.Windows.Forms.Button caly_b;
        private System.Windows.Forms.RadioButton dl_rb;
        private System.Windows.Forms.RadioButton dh_rb;
        private System.Windows.Forms.RadioButton dl_d_rb;
        private System.Windows.Forms.RadioButton dh_d_rb;
        private System.Windows.Forms.Button plik_odczyt_b;
        private System.Windows.Forms.Button plik_zapis_b;
        private System.Windows.Forms.Button reset_kom_b;
        public System.Windows.Forms.Button[] ah_tab;
        public System.Windows.Forms.Button[] al_tab;
        public System.Windows.Forms.Button[] bh_tab;
        public System.Windows.Forms.Button[] bl_tab;
        public System.Windows.Forms.Button[] ch_tab;
        public System.Windows.Forms.Button[] cl_tab;
        public System.Windows.Forms.Button[] dh_tab;
        public System.Windows.Forms.Button[] dl_tab;
        public rejestr ax;
        public rejestr bx;
        public rejestr cx;
        public rejestr dx;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton sec5_rb;
        private System.Windows.Forms.RadioButton sec3_rb;
        private System.Windows.Forms.RadioButton sec1_rb;
        private System.Windows.Forms.RadioButton sec_rb;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button pause_b;
        private System.Windows.Forms.Button play_b;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel przerwanie_p;
        private System.Windows.Forms.RadioButton spr_czy_nac_rb;
        private System.Windows.Forms.RadioButton zaczekaj_rb;
        private System.Windows.Forms.RadioButton stan_klawiatury_rb;
        private System.Windows.Forms.RadioButton odczytaj_znak_rb;
        private System.Windows.Forms.RadioButton pobierz_dat_rb;
        private System.Windows.Forms.RadioButton ustaw_dat_rb;
        private System.Windows.Forms.RadioButton pobierz_godz_rb;
        private System.Windows.Forms.RadioButton ustaw_godz_rb;
        private System.Windows.Forms.RadioButton screen_shot_rb;
        private System.Windows.Forms.CheckBox przerwanie_ch;
        private System.Windows.Forms.Button przerwanie_b;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox godzina_t;
        private System.Windows.Forms.TextBox data_t;
        private System.Windows.Forms.Timer timer_przer;
        private System.Windows.Forms.Timer zaczekaj;
        private System.Windows.Forms.TextBox zaczekaj_t;
        private System.Windows.Forms.Timer zaczekaj5;
        private System.Windows.Forms.Timer zatrzask_tim;
    }

}

