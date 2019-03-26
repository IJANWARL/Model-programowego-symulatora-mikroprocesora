namespace Zad1
{
    partial class okno2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(okno2));
            this.label1 = new System.Windows.Forms.Label();
            this.save_t = new System.Windows.Forms.TextBox();
            this.save_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa pliku:";
            // 
            // save_t
            // 
            this.save_t.Location = new System.Drawing.Point(135, 33);
            this.save_t.Name = "save_t";
            this.save_t.Size = new System.Drawing.Size(101, 20);
            this.save_t.TabIndex = 1;
            this.save_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // save_b
            // 
            this.save_b.Location = new System.Drawing.Point(253, 30);
            this.save_b.Name = "save_b";
            this.save_b.Size = new System.Drawing.Size(75, 23);
            this.save_b.TabIndex = 2;
            this.save_b.Text = "Save";
            this.save_b.UseVisualStyleBackColor = true;
            this.save_b.Click += new System.EventHandler(this.save_b_Click);
            // 
            // okno2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 85);
            this.Controls.Add(this.save_b);
            this.Controls.Add(this.save_t);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "okno2";
            this.Text = "Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox save_t;
        private System.Windows.Forms.Button save_b;
    }
}