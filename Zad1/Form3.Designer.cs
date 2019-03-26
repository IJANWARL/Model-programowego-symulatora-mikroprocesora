namespace Zad1
{
    partial class okno3
    {
        public Symulator parent;
        private Warning warning;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(okno3));
            this.open_b = new System.Windows.Forms.Button();
            this.open_t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // open_b
            // 
            this.open_b.Location = new System.Drawing.Point(249, 49);
            this.open_b.Name = "open_b";
            this.open_b.Size = new System.Drawing.Size(75, 23);
            this.open_b.TabIndex = 5;
            this.open_b.Text = "Open";
            this.open_b.UseVisualStyleBackColor = true;
            this.open_b.Click += new System.EventHandler(this.open_b_Click);
            // 
            // open_t
            // 
            this.open_t.Location = new System.Drawing.Point(131, 52);
            this.open_t.Name = "open_t";
            this.open_t.Size = new System.Drawing.Size(101, 20);
            this.open_t.TabIndex = 4;
            this.open_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwa pliku:";
            // 
            // okno3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 122);
            this.Controls.Add(this.open_b);
            this.Controls.Add(this.open_t);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "okno3";
            this.Text = "Open";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open_b;
        private System.Windows.Forms.TextBox open_t;
        private System.Windows.Forms.Label label1;
    }
}