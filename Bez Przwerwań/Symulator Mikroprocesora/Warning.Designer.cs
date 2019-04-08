namespace Zad1
{
    partial class Warning
    {
        public okno2 parent;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warning));
            this.label1 = new System.Windows.Forms.Label();
            this.back_b = new System.Windows.Forms.Button();
            this.continue_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(71, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plik o podanej nazie \r\njuż istnieje.\r\nCzy na pewno chcesz \r\nkontynuować?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back_b
            // 
            this.back_b.Location = new System.Drawing.Point(27, 128);
            this.back_b.Name = "back_b";
            this.back_b.Size = new System.Drawing.Size(75, 23);
            this.back_b.TabIndex = 1;
            this.back_b.Text = "Powrót";
            this.back_b.UseVisualStyleBackColor = true;
            this.back_b.Click += new System.EventHandler(this.back_b_Click);
            // 
            // continue_b
            // 
            this.continue_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.continue_b.Location = new System.Drawing.Point(209, 128);
            this.continue_b.Name = "continue_b";
            this.continue_b.Size = new System.Drawing.Size(75, 23);
            this.continue_b.TabIndex = 2;
            this.continue_b.Text = "Kontynuuj";
            this.continue_b.UseVisualStyleBackColor = true;
            this.continue_b.Click += new System.EventHandler(this.continue_b_Click);
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 176);
            this.Controls.Add(this.continue_b);
            this.Controls.Add(this.back_b);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Warning";
            this.Text = "Warning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_b;
        private System.Windows.Forms.Button continue_b;
    }
}