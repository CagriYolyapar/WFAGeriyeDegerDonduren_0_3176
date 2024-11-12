namespace WFAGeriyeDegerDonduren_0
{
    partial class Form1
    {
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
            this.BtnTopla = new System.Windows.Forms.Button();
            this.TxtSayi1 = new System.Windows.Forms.TextBox();
            this.TxtSayi2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnTopla
            // 
            this.BtnTopla.Location = new System.Drawing.Point(141, 125);
            this.BtnTopla.Name = "BtnTopla";
            this.BtnTopla.Size = new System.Drawing.Size(75, 23);
            this.BtnTopla.TabIndex = 0;
            this.BtnTopla.Text = "Topla";
            this.BtnTopla.UseVisualStyleBackColor = true;
            this.BtnTopla.Click += new System.EventHandler(this.BtnTopla_Click);
            // 
            // TxtSayi1
            // 
            this.TxtSayi1.Location = new System.Drawing.Point(30, 64);
            this.TxtSayi1.Name = "TxtSayi1";
            this.TxtSayi1.Size = new System.Drawing.Size(100, 22);
            this.TxtSayi1.TabIndex = 1;
            // 
            // TxtSayi2
            // 
            this.TxtSayi2.Location = new System.Drawing.Point(257, 64);
            this.TxtSayi2.Name = "TxtSayi2";
            this.TxtSayi2.Size = new System.Drawing.Size(100, 22);
            this.TxtSayi2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtSayi2);
            this.Controls.Add(this.TxtSayi1);
            this.Controls.Add(this.BtnTopla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTopla;
        private System.Windows.Forms.TextBox TxtSayi1;
        private System.Windows.Forms.TextBox TxtSayi2;
    }
}

