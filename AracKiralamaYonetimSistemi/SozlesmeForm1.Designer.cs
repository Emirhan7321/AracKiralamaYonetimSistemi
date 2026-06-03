namespace AracKiralamaYonetimSistemi
{
    partial class SozlesmeForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SozlesmeForm1));
            this.lblSozAdSoyad = new System.Windows.Forms.Label();
            this.txtSozAdSoyad = new System.Windows.Forms.TextBox();
            this.lblSozTc = new System.Windows.Forms.Label();
            this.lblSozTelefon = new System.Windows.Forms.Label();
            this.txtSozTc = new System.Windows.Forms.TextBox();
            this.txtSozTelefon = new System.Windows.Forms.TextBox();
            this.dtpAlis = new System.Windows.Forms.DateTimePicker();
            this.lblSozAracAlisTarihi = new System.Windows.Forms.Label();
            this.lblSozAracTeslim = new System.Windows.Forms.Label();
            this.dtpTeslim = new System.Windows.Forms.DateTimePicker();
            this.lblSozPlaka = new System.Windows.Forms.Label();
            this.txtSozPlaka = new System.Windows.Forms.TextBox();
            this.lblSozTutar = new System.Windows.Forms.Label();
            this.btnSozKirala = new System.Windows.Forms.Button();
            this.chkSozlesme = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblSozAdSoyad
            // 
            this.lblSozAdSoyad.AutoSize = true;
            this.lblSozAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSozAdSoyad.Location = new System.Drawing.Point(31, 45);
            this.lblSozAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSozAdSoyad.Name = "lblSozAdSoyad";
            this.lblSozAdSoyad.Size = new System.Drawing.Size(85, 20);
            this.lblSozAdSoyad.TabIndex = 0;
            this.lblSozAdSoyad.Text = "Ad Soyad:";
            // 
            // txtSozAdSoyad
            // 
            this.txtSozAdSoyad.Location = new System.Drawing.Point(156, 42);
            this.txtSozAdSoyad.Name = "txtSozAdSoyad";
            this.txtSozAdSoyad.Size = new System.Drawing.Size(298, 26);
            this.txtSozAdSoyad.TabIndex = 1;
            // 
            // lblSozTc
            // 
            this.lblSozTc.AutoSize = true;
            this.lblSozTc.Location = new System.Drawing.Point(31, 88);
            this.lblSozTc.Name = "lblSozTc";
            this.lblSozTc.Size = new System.Drawing.Size(109, 20);
            this.lblSozTc.TabIndex = 2;
            this.lblSozTc.Text = "Tc Kimlik No:";
            // 
            // lblSozTelefon
            // 
            this.lblSozTelefon.AutoSize = true;
            this.lblSozTelefon.Location = new System.Drawing.Point(31, 135);
            this.lblSozTelefon.Name = "lblSozTelefon";
            this.lblSozTelefon.Size = new System.Drawing.Size(69, 20);
            this.lblSozTelefon.TabIndex = 3;
            this.lblSozTelefon.Text = "Telefon:";
            // 
            // txtSozTc
            // 
            this.txtSozTc.Location = new System.Drawing.Point(156, 88);
            this.txtSozTc.Name = "txtSozTc";
            this.txtSozTc.Size = new System.Drawing.Size(298, 26);
            this.txtSozTc.TabIndex = 4;
            // 
            // txtSozTelefon
            // 
            this.txtSozTelefon.Location = new System.Drawing.Point(156, 135);
            this.txtSozTelefon.Name = "txtSozTelefon";
            this.txtSozTelefon.Size = new System.Drawing.Size(298, 26);
            this.txtSozTelefon.TabIndex = 5;
            // 
            // dtpAlis
            // 
            this.dtpAlis.Location = new System.Drawing.Point(216, 209);
            this.dtpAlis.Name = "dtpAlis";
            this.dtpAlis.Size = new System.Drawing.Size(297, 26);
            this.dtpAlis.TabIndex = 6;
            this.dtpAlis.ValueChanged += new System.EventHandler(this.dtpAlis_ValueChanged);
            // 
            // lblSozAracAlisTarihi
            // 
            this.lblSozAracAlisTarihi.AutoSize = true;
            this.lblSozAracAlisTarihi.Location = new System.Drawing.Point(31, 214);
            this.lblSozAracAlisTarihi.Name = "lblSozAracAlisTarihi";
            this.lblSozAracAlisTarihi.Size = new System.Drawing.Size(163, 20);
            this.lblSozAracAlisTarihi.TabIndex = 7;
            this.lblSozAracAlisTarihi.Text = "Kiralama Başlangıcı:";
            // 
            // lblSozAracTeslim
            // 
            this.lblSozAracTeslim.AutoSize = true;
            this.lblSozAracTeslim.Location = new System.Drawing.Point(31, 252);
            this.lblSozAracTeslim.Name = "lblSozAracTeslim";
            this.lblSozAracTeslim.Size = new System.Drawing.Size(146, 20);
            this.lblSozAracTeslim.TabIndex = 8;
            this.lblSozAracTeslim.Text = "Araç TeslimTarihi:";
            // 
            // dtpTeslim
            // 
            this.dtpTeslim.Location = new System.Drawing.Point(216, 247);
            this.dtpTeslim.Name = "dtpTeslim";
            this.dtpTeslim.Size = new System.Drawing.Size(297, 26);
            this.dtpTeslim.TabIndex = 9;
            this.dtpTeslim.ValueChanged += new System.EventHandler(this.dtpTeslim_ValueChanged);
            // 
            // lblSozPlaka
            // 
            this.lblSozPlaka.AutoSize = true;
            this.lblSozPlaka.Location = new System.Drawing.Point(40, 346);
            this.lblSozPlaka.Name = "lblSozPlaka";
            this.lblSozPlaka.Size = new System.Drawing.Size(121, 20);
            this.lblSozPlaka.TabIndex = 10;
            this.lblSozPlaka.Text = "Aracın Plakası:";
            // 
            // txtSozPlaka
            // 
            this.txtSozPlaka.Location = new System.Drawing.Point(183, 346);
            this.txtSozPlaka.Name = "txtSozPlaka";
            this.txtSozPlaka.ReadOnly = true;
            this.txtSozPlaka.Size = new System.Drawing.Size(271, 26);
            this.txtSozPlaka.TabIndex = 11;
            // 
            // lblSozTutar
            // 
            this.lblSozTutar.AutoSize = true;
            this.lblSozTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSozTutar.Location = new System.Drawing.Point(56, 433);
            this.lblSozTutar.Name = "lblSozTutar";
            this.lblSozTutar.Size = new System.Drawing.Size(552, 39);
            this.lblSozTutar.TabIndex = 12;
            this.lblSozTutar.Text = "Hesaplanan \"Toplam Tutar: 0 TL\"\r\n";
            // 
            // btnSozKirala
            // 
            this.btnSozKirala.Location = new System.Drawing.Point(733, 418);
            this.btnSozKirala.Name = "btnSozKirala";
            this.btnSozKirala.Size = new System.Drawing.Size(213, 81);
            this.btnSozKirala.TabIndex = 13;
            this.btnSozKirala.Text = "Kirala";
            this.btnSozKirala.UseVisualStyleBackColor = true;
            this.btnSozKirala.Click += new System.EventHandler(this.btnSozKirala_Click);
            // 
            // chkSozlesme
            // 
            this.chkSozlesme.AutoSize = true;
            this.chkSozlesme.Location = new System.Drawing.Point(679, 137);
            this.chkSozlesme.Name = "chkSozlesme";
            this.chkSozlesme.Size = new System.Drawing.Size(183, 24);
            this.chkSozlesme.TabIndex = 14;
            this.chkSozlesme.Text = "Onaylıyor musunuz?";
            this.chkSozlesme.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(634, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(283, 96);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // SozlesmeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 563);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.chkSozlesme);
            this.Controls.Add(this.btnSozKirala);
            this.Controls.Add(this.lblSozTutar);
            this.Controls.Add(this.txtSozPlaka);
            this.Controls.Add(this.lblSozPlaka);
            this.Controls.Add(this.dtpTeslim);
            this.Controls.Add(this.lblSozAracTeslim);
            this.Controls.Add(this.lblSozAracAlisTarihi);
            this.Controls.Add(this.dtpAlis);
            this.Controls.Add(this.txtSozTelefon);
            this.Controls.Add(this.txtSozTc);
            this.Controls.Add(this.lblSozTelefon);
            this.Controls.Add(this.lblSozTc);
            this.Controls.Add(this.txtSozAdSoyad);
            this.Controls.Add(this.lblSozAdSoyad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SozlesmeForm1";
            this.Text = "SozlesmeForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSozAdSoyad;
        private System.Windows.Forms.TextBox txtSozAdSoyad;
        private System.Windows.Forms.Label lblSozTc;
        private System.Windows.Forms.Label lblSozTelefon;
        private System.Windows.Forms.TextBox txtSozTc;
        private System.Windows.Forms.TextBox txtSozTelefon;
        private System.Windows.Forms.DateTimePicker dtpAlis;
        private System.Windows.Forms.Label lblSozAracAlisTarihi;
        private System.Windows.Forms.Label lblSozAracTeslim;
        private System.Windows.Forms.DateTimePicker dtpTeslim;
        private System.Windows.Forms.Label lblSozPlaka;
        private System.Windows.Forms.TextBox txtSozPlaka;
        private System.Windows.Forms.Label lblSozTutar;
        private System.Windows.Forms.Button btnSozKirala;
        private System.Windows.Forms.CheckBox chkSozlesme;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}