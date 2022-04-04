namespace Praktikum_4_April
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbKalimat = new System.Windows.Forms.Label();
            this.LbHuruf = new System.Windows.Forms.Label();
            this.LbHasil = new System.Windows.Forms.Label();
            this.TbInputan = new System.Windows.Forms.TextBox();
            this.TbHurufPertama = new System.Windows.Forms.TextBox();
            this.TbHurufKedua = new System.Windows.Forms.TextBox();
            this.LbMenjadi = new System.Windows.Forms.Label();
            this.BtnKonversi = new System.Windows.Forms.Button();
            this.LbOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbKalimat
            // 
            this.LbKalimat.AutoSize = true;
            this.LbKalimat.Location = new System.Drawing.Point(19, 26);
            this.LbKalimat.Name = "LbKalimat";
            this.LbKalimat.Size = new System.Drawing.Size(129, 20);
            this.LbKalimat.TabIndex = 0;
            this.LbKalimat.Text = "Masukkan Kalimat";
            // 
            // LbHuruf
            // 
            this.LbHuruf.AutoSize = true;
            this.LbHuruf.Location = new System.Drawing.Point(19, 78);
            this.LbHuruf.Name = "LbHuruf";
            this.LbHuruf.Size = new System.Drawing.Size(115, 20);
            this.LbHuruf.TabIndex = 1;
            this.LbHuruf.Text = "Masukkan Huruf";
            // 
            // LbHasil
            // 
            this.LbHasil.AutoSize = true;
            this.LbHasil.Location = new System.Drawing.Point(19, 193);
            this.LbHasil.Name = "LbHasil";
            this.LbHasil.Size = new System.Drawing.Size(42, 20);
            this.LbHasil.TabIndex = 2;
            this.LbHasil.Text = "Hasil";
            // 
            // TbInputan
            // 
            this.TbInputan.Location = new System.Drawing.Point(219, 26);
            this.TbInputan.Name = "TbInputan";
            this.TbInputan.Size = new System.Drawing.Size(235, 27);
            this.TbInputan.TabIndex = 3;
            // 
            // TbHurufPertama
            // 
            this.TbHurufPertama.Location = new System.Drawing.Point(219, 78);
            this.TbHurufPertama.Name = "TbHurufPertama";
            this.TbHurufPertama.Size = new System.Drawing.Size(38, 27);
            this.TbHurufPertama.TabIndex = 4;
            this.TbHurufPertama.TextChanged += new System.EventHandler(this.TbHurufPertama_TextChanged);
            // 
            // TbHurufKedua
            // 
            this.TbHurufKedua.Location = new System.Drawing.Point(412, 78);
            this.TbHurufKedua.Name = "TbHurufKedua";
            this.TbHurufKedua.Size = new System.Drawing.Size(42, 27);
            this.TbHurufKedua.TabIndex = 5;
            this.TbHurufKedua.TextChanged += new System.EventHandler(this.TbHurufKedua_TextChanged);
            // 
            // LbMenjadi
            // 
            this.LbMenjadi.AutoSize = true;
            this.LbMenjadi.Location = new System.Drawing.Point(314, 78);
            this.LbMenjadi.Name = "LbMenjadi";
            this.LbMenjadi.Size = new System.Drawing.Size(63, 20);
            this.LbMenjadi.TabIndex = 6;
            this.LbMenjadi.Text = "Menjadi";
            // 
            // BtnKonversi
            // 
            this.BtnKonversi.Location = new System.Drawing.Point(228, 135);
            this.BtnKonversi.Name = "BtnKonversi";
            this.BtnKonversi.Size = new System.Drawing.Size(226, 29);
            this.BtnKonversi.TabIndex = 7;
            this.BtnKonversi.Text = "Konversi";
            this.BtnKonversi.UseVisualStyleBackColor = true;
            this.BtnKonversi.Click += new System.EventHandler(this.BtnKonversi_Click);
            // 
            // LbOutput
            // 
            this.LbOutput.AutoSize = true;
            this.LbOutput.Location = new System.Drawing.Point(283, 193);
            this.LbOutput.Name = "LbOutput";
            this.LbOutput.Size = new System.Drawing.Size(0, 20);
            this.LbOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 255);
            this.Controls.Add(this.LbOutput);
            this.Controls.Add(this.BtnKonversi);
            this.Controls.Add(this.LbMenjadi);
            this.Controls.Add(this.TbHurufKedua);
            this.Controls.Add(this.TbHurufPertama);
            this.Controls.Add(this.TbInputan);
            this.Controls.Add(this.LbHasil);
            this.Controls.Add(this.LbHuruf);
            this.Controls.Add(this.LbKalimat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LbKalimat;
        private Label LbHuruf;
        private Label LbHasil;
        private TextBox TbInputan;
        private TextBox TbHurufPertama;
        private TextBox TbHurufKedua;
        private Label LbMenjadi;
        private Button BtnKonversi;
        private Label LbOutput;
    }
}