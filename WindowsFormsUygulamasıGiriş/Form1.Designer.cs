namespace WindowsFormsUygulamasıGiriş
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LblSayi1 = new System.Windows.Forms.Label();
            this.LblSayi2 = new System.Windows.Forms.Label();
            this.tbxSayi1 = new System.Windows.Forms.TextBox();
            this.tbxSayi2 = new System.Windows.Forms.TextBox();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(152, 84);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(133, 22);
            this.tbxName.TabIndex = 0;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.SteelBlue;
            this.LblName.Location = new System.Drawing.Point(40, 90);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(43, 16);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Adınız";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(152, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mesaj Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblSayi1
            // 
            this.LblSayi1.AutoSize = true;
            this.LblSayi1.Location = new System.Drawing.Point(455, 311);
            this.LblSayi1.Name = "LblSayi1";
            this.LblSayi1.Size = new System.Drawing.Size(47, 16);
            this.LblSayi1.TabIndex = 3;
            this.LblSayi1.Text = "1. Sayı";
            // 
            // LblSayi2
            // 
            this.LblSayi2.AutoSize = true;
            this.LblSayi2.Location = new System.Drawing.Point(455, 387);
            this.LblSayi2.Name = "LblSayi2";
            this.LblSayi2.Size = new System.Drawing.Size(47, 16);
            this.LblSayi2.TabIndex = 4;
            this.LblSayi2.Text = "2. Sayı";
            // 
            // tbxSayi1
            // 
            this.tbxSayi1.Location = new System.Drawing.Point(587, 305);
            this.tbxSayi1.Name = "tbxSayi1";
            this.tbxSayi1.Size = new System.Drawing.Size(100, 22);
            this.tbxSayi1.TabIndex = 5;
            // 
            // tbxSayi2
            // 
            this.tbxSayi2.Location = new System.Drawing.Point(587, 381);
            this.tbxSayi2.Name = "tbxSayi2";
            this.tbxSayi2.Size = new System.Drawing.Size(100, 22);
            this.tbxSayi2.TabIndex = 6;
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSonuc.Location = new System.Drawing.Point(771, 346);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(99, 29);
            this.LblSonuc.TabIndex = 7;
            this.LblSonuc.Text = "Sonuc...";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(587, 441);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(100, 40);
            this.btnTopla.TabIndex = 8;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::WindowsFormsUygulamasıGiriş.Properties.Resources.siluetler_makale_gorseli;
            this.ClientSize = new System.Drawing.Size(937, 532);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.tbxSayi2);
            this.Controls.Add(this.tbxSayi1);
            this.Controls.Add(this.LblSayi2);
            this.Controls.Add(this.LblSayi1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.tbxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblSayi1;
        private System.Windows.Forms.Label LblSayi2;
        private System.Windows.Forms.TextBox tbxSayi1;
        private System.Windows.Forms.TextBox tbxSayi2;
        private System.Windows.Forms.Label LblSonuc;
        private System.Windows.Forms.Button btnTopla;
    }
}

