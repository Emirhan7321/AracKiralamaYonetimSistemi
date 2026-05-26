namespace AracKiralamaYonetimSistemi
{
    partial class AnaMenuForm
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
            this.tabAracDüzenle = new System.Windows.Forms.TabControl();
            this.tabAracSecimi = new System.Windows.Forms.TabPage();
            this.tabAracGiris = new System.Windows.Forms.TabPage();
            this.btnKaydetAracBilgi = new System.Windows.Forms.Button();
            this.btnResmiSec = new System.Windows.Forms.Button();
            this.pictBxAracResmi = new System.Windows.Forms.PictureBox();
            this.lblAracResim = new System.Windows.Forms.Label();
            this.YeniAracBilgi = new System.Windows.Forms.GroupBox();
            this.rbtnManuel = new System.Windows.Forms.RadioButton();
            this.rbtnOtomatik = new System.Windows.Forms.RadioButton();
            this.lblVites = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.lblUcret = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.tabAracDuzenle = new System.Windows.Forms.TabPage();
            this.btnResimGuncelle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.chkGuncelUygunluk = new System.Windows.Forms.CheckBox();
            this.pictBxGuncelResim = new System.Windows.Forms.PictureBox();
            this.txtGuncelUcret = new System.Windows.Forms.TextBox();
            this.txtGuncelModel = new System.Windows.Forms.TextBox();
            this.txtGuncelMarka = new System.Windows.Forms.TextBox();
            this.txtGuncelPlaka = new System.Windows.Forms.TextBox();
            this.lblGuncelUcret = new System.Windows.Forms.Label();
            this.lblGuncelModel = new System.Windows.Forms.Label();
            this.lblGuncelMarka = new System.Windows.Forms.Label();
            this.lblGuncelPlaka = new System.Windows.Forms.Label();
            this.lblAraclar = new System.Windows.Forms.Label();
            this.cmbAraclar = new System.Windows.Forms.ComboBox();
            this.dgvVitrin = new System.Windows.Forms.DataGridView();
            this.dgvChkSecim = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvImgResim = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvTxtMarka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtPlaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtUcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtVites = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtUygunluk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAracDüzenle.SuspendLayout();
            this.tabAracSecimi.SuspendLayout();
            this.tabAracGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBxAracResmi)).BeginInit();
            this.YeniAracBilgi.SuspendLayout();
            this.tabAracDuzenle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBxGuncelResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVitrin)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAracDüzenle
            // 
            this.tabAracDüzenle.Controls.Add(this.tabAracSecimi);
            this.tabAracDüzenle.Controls.Add(this.tabAracGiris);
            this.tabAracDüzenle.Controls.Add(this.tabAracDuzenle);
            this.tabAracDüzenle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAracDüzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabAracDüzenle.Location = new System.Drawing.Point(0, 0);
            this.tabAracDüzenle.Margin = new System.Windows.Forms.Padding(4);
            this.tabAracDüzenle.Name = "tabAracDüzenle";
            this.tabAracDüzenle.SelectedIndex = 0;
            this.tabAracDüzenle.Size = new System.Drawing.Size(1092, 572);
            this.tabAracDüzenle.TabIndex = 0;
            // 
            // tabAracSecimi
            // 
            this.tabAracSecimi.Controls.Add(this.dgvVitrin);
            this.tabAracSecimi.Location = new System.Drawing.Point(4, 31);
            this.tabAracSecimi.Margin = new System.Windows.Forms.Padding(4);
            this.tabAracSecimi.Name = "tabAracSecimi";
            this.tabAracSecimi.Padding = new System.Windows.Forms.Padding(4);
            this.tabAracSecimi.Size = new System.Drawing.Size(1084, 537);
            this.tabAracSecimi.TabIndex = 0;
            this.tabAracSecimi.Text = "Araç Seçim Ekranı";
            this.tabAracSecimi.UseVisualStyleBackColor = true;
            // 
            // tabAracGiris
            // 
            this.tabAracGiris.Controls.Add(this.btnKaydetAracBilgi);
            this.tabAracGiris.Controls.Add(this.btnResmiSec);
            this.tabAracGiris.Controls.Add(this.pictBxAracResmi);
            this.tabAracGiris.Controls.Add(this.lblAracResim);
            this.tabAracGiris.Controls.Add(this.YeniAracBilgi);
            this.tabAracGiris.Location = new System.Drawing.Point(4, 31);
            this.tabAracGiris.Margin = new System.Windows.Forms.Padding(4);
            this.tabAracGiris.Name = "tabAracGiris";
            this.tabAracGiris.Padding = new System.Windows.Forms.Padding(4);
            this.tabAracGiris.Size = new System.Drawing.Size(927, 537);
            this.tabAracGiris.TabIndex = 1;
            this.tabAracGiris.Text = "Araç Giriş Ekranı";
            this.tabAracGiris.UseVisualStyleBackColor = true;
            // 
            // btnKaydetAracBilgi
            // 
            this.btnKaydetAracBilgi.Location = new System.Drawing.Point(296, 428);
            this.btnKaydetAracBilgi.Name = "btnKaydetAracBilgi";
            this.btnKaydetAracBilgi.Size = new System.Drawing.Size(323, 75);
            this.btnKaydetAracBilgi.TabIndex = 4;
            this.btnKaydetAracBilgi.Text = "Kaydet";
            this.btnKaydetAracBilgi.UseVisualStyleBackColor = true;
            this.btnKaydetAracBilgi.Click += new System.EventHandler(this.btnKaydetAracBilgi_Click);
            // 
            // btnResmiSec
            // 
            this.btnResmiSec.Location = new System.Drawing.Point(569, 342);
            this.btnResmiSec.Name = "btnResmiSec";
            this.btnResmiSec.Size = new System.Drawing.Size(260, 36);
            this.btnResmiSec.TabIndex = 3;
            this.btnResmiSec.Text = "Resmi Seç";
            this.btnResmiSec.UseVisualStyleBackColor = true;
            this.btnResmiSec.Click += new System.EventHandler(this.btnResmiSec_Click);
            // 
            // pictBxAracResmi
            // 
            this.pictBxAracResmi.Location = new System.Drawing.Point(569, 48);
            this.pictBxAracResmi.Name = "pictBxAracResmi";
            this.pictBxAracResmi.Size = new System.Drawing.Size(260, 260);
            this.pictBxAracResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBxAracResmi.TabIndex = 2;
            this.pictBxAracResmi.TabStop = false;
            // 
            // lblAracResim
            // 
            this.lblAracResim.AutoSize = true;
            this.lblAracResim.Location = new System.Drawing.Point(565, 17);
            this.lblAracResim.Name = "lblAracResim";
            this.lblAracResim.Size = new System.Drawing.Size(107, 24);
            this.lblAracResim.TabIndex = 1;
            this.lblAracResim.Text = "Araç Resmi";
            // 
            // YeniAracBilgi
            // 
            this.YeniAracBilgi.Controls.Add(this.rbtnManuel);
            this.YeniAracBilgi.Controls.Add(this.rbtnOtomatik);
            this.YeniAracBilgi.Controls.Add(this.lblVites);
            this.YeniAracBilgi.Controls.Add(this.txtUcret);
            this.YeniAracBilgi.Controls.Add(this.lblUcret);
            this.YeniAracBilgi.Controls.Add(this.txtModel);
            this.YeniAracBilgi.Controls.Add(this.lblModel);
            this.YeniAracBilgi.Controls.Add(this.txtMarka);
            this.YeniAracBilgi.Controls.Add(this.lblMarka);
            this.YeniAracBilgi.Controls.Add(this.txtPlaka);
            this.YeniAracBilgi.Controls.Add(this.lblPlaka);
            this.YeniAracBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YeniAracBilgi.Location = new System.Drawing.Point(10, 8);
            this.YeniAracBilgi.Margin = new System.Windows.Forms.Padding(4);
            this.YeniAracBilgi.Name = "YeniAracBilgi";
            this.YeniAracBilgi.Padding = new System.Windows.Forms.Padding(4);
            this.YeniAracBilgi.Size = new System.Drawing.Size(392, 370);
            this.YeniAracBilgi.TabIndex = 0;
            this.YeniAracBilgi.TabStop = false;
            this.YeniAracBilgi.Text = "Yeni Araç Bilgileri";
            // 
            // rbtnManuel
            // 
            this.rbtnManuel.AutoSize = true;
            this.rbtnManuel.Location = new System.Drawing.Point(234, 304);
            this.rbtnManuel.Name = "rbtnManuel";
            this.rbtnManuel.Size = new System.Drawing.Size(84, 24);
            this.rbtnManuel.TabIndex = 10;
            this.rbtnManuel.TabStop = true;
            this.rbtnManuel.Text = "Manuel";
            this.rbtnManuel.UseVisualStyleBackColor = true;
            // 
            // rbtnOtomatik
            // 
            this.rbtnOtomatik.AutoSize = true;
            this.rbtnOtomatik.Location = new System.Drawing.Point(119, 302);
            this.rbtnOtomatik.Name = "rbtnOtomatik";
            this.rbtnOtomatik.Size = new System.Drawing.Size(97, 24);
            this.rbtnOtomatik.TabIndex = 9;
            this.rbtnOtomatik.TabStop = true;
            this.rbtnOtomatik.Text = "Otomatik";
            this.rbtnOtomatik.UseVisualStyleBackColor = true;
            // 
            // lblVites
            // 
            this.lblVites.AutoSize = true;
            this.lblVites.Location = new System.Drawing.Point(8, 304);
            this.lblVites.Name = "lblVites";
            this.lblVites.Size = new System.Drawing.Size(91, 20);
            this.lblVites.TabIndex = 8;
            this.lblVites.Text = "Vites Türü:";
            // 
            // txtUcret
            // 
            this.txtUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUcret.Location = new System.Drawing.Point(75, 231);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(262, 26);
            this.txtUcret.TabIndex = 7;
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(8, 234);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(55, 20);
            this.lblUcret.TabIndex = 6;
            this.lblUcret.Text = "Ücret:";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Location = new System.Drawing.Point(75, 158);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(262, 26);
            this.txtModel.TabIndex = 5;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(8, 161);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(59, 20);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model:";
            // 
            // txtMarka
            // 
            this.txtMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarka.Location = new System.Drawing.Point(75, 93);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(262, 26);
            this.txtMarka.TabIndex = 3;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(8, 99);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(60, 20);
            this.lblMarka.TabIndex = 2;
            this.lblMarka.Text = "Marka:";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlaka.Location = new System.Drawing.Point(75, 40);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(262, 26);
            this.txtPlaka.TabIndex = 1;
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(8, 43);
            this.lblPlaka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(55, 20);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "Plaka:";
            // 
            // tabAracDuzenle
            // 
            this.tabAracDuzenle.Controls.Add(this.btnResimGuncelle);
            this.tabAracDuzenle.Controls.Add(this.btnGüncelle);
            this.tabAracDuzenle.Controls.Add(this.btnSil);
            this.tabAracDuzenle.Controls.Add(this.chkGuncelUygunluk);
            this.tabAracDuzenle.Controls.Add(this.pictBxGuncelResim);
            this.tabAracDuzenle.Controls.Add(this.txtGuncelUcret);
            this.tabAracDuzenle.Controls.Add(this.txtGuncelModel);
            this.tabAracDuzenle.Controls.Add(this.txtGuncelMarka);
            this.tabAracDuzenle.Controls.Add(this.txtGuncelPlaka);
            this.tabAracDuzenle.Controls.Add(this.lblGuncelUcret);
            this.tabAracDuzenle.Controls.Add(this.lblGuncelModel);
            this.tabAracDuzenle.Controls.Add(this.lblGuncelMarka);
            this.tabAracDuzenle.Controls.Add(this.lblGuncelPlaka);
            this.tabAracDuzenle.Controls.Add(this.lblAraclar);
            this.tabAracDuzenle.Controls.Add(this.cmbAraclar);
            this.tabAracDuzenle.Location = new System.Drawing.Point(4, 31);
            this.tabAracDuzenle.Name = "tabAracDuzenle";
            this.tabAracDuzenle.Size = new System.Drawing.Size(927, 537);
            this.tabAracDuzenle.TabIndex = 2;
            this.tabAracDuzenle.Text = "Bilgileri Düzenle";
            this.tabAracDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnResimGuncelle
            // 
            this.btnResimGuncelle.Location = new System.Drawing.Point(707, 22);
            this.btnResimGuncelle.Name = "btnResimGuncelle";
            this.btnResimGuncelle.Size = new System.Drawing.Size(123, 60);
            this.btnResimGuncelle.TabIndex = 15;
            this.btnResimGuncelle.Text = "Resmi Güncelle";
            this.btnResimGuncelle.UseVisualStyleBackColor = true;
            this.btnResimGuncelle.Click += new System.EventHandler(this.btnResimGuncelle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(597, 393);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(191, 66);
            this.btnGüncelle.TabIndex = 14;
            this.btnGüncelle.Text = "Seçili Arabayı Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(597, 276);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(192, 66);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Seçili Arabayı sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // chkGuncelUygunluk
            // 
            this.chkGuncelUygunluk.AutoSize = true;
            this.chkGuncelUygunluk.Checked = true;
            this.chkGuncelUygunluk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGuncelUygunluk.Location = new System.Drawing.Point(12, 354);
            this.chkGuncelUygunluk.Name = "chkGuncelUygunluk";
            this.chkGuncelUygunluk.Size = new System.Drawing.Size(167, 28);
            this.chkGuncelUygunluk.TabIndex = 12;
            this.chkGuncelUygunluk.Text = "Kullanıma Hazır!";
            this.chkGuncelUygunluk.UseVisualStyleBackColor = true;
            // 
            // pictBxGuncelResim
            // 
            this.pictBxGuncelResim.Location = new System.Drawing.Point(467, 22);
            this.pictBxGuncelResim.Name = "pictBxGuncelResim";
            this.pictBxGuncelResim.Size = new System.Drawing.Size(200, 200);
            this.pictBxGuncelResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBxGuncelResim.TabIndex = 10;
            this.pictBxGuncelResim.TabStop = false;
            // 
            // txtGuncelUcret
            // 
            this.txtGuncelUcret.Location = new System.Drawing.Point(183, 295);
            this.txtGuncelUcret.Name = "txtGuncelUcret";
            this.txtGuncelUcret.Size = new System.Drawing.Size(161, 28);
            this.txtGuncelUcret.TabIndex = 9;
            // 
            // txtGuncelModel
            // 
            this.txtGuncelModel.Location = new System.Drawing.Point(86, 234);
            this.txtGuncelModel.Name = "txtGuncelModel";
            this.txtGuncelModel.Size = new System.Drawing.Size(258, 28);
            this.txtGuncelModel.TabIndex = 8;
            // 
            // txtGuncelMarka
            // 
            this.txtGuncelMarka.Location = new System.Drawing.Point(86, 166);
            this.txtGuncelMarka.Name = "txtGuncelMarka";
            this.txtGuncelMarka.Size = new System.Drawing.Size(258, 28);
            this.txtGuncelMarka.TabIndex = 7;
            // 
            // txtGuncelPlaka
            // 
            this.txtGuncelPlaka.Location = new System.Drawing.Point(86, 107);
            this.txtGuncelPlaka.Name = "txtGuncelPlaka";
            this.txtGuncelPlaka.Size = new System.Drawing.Size(258, 28);
            this.txtGuncelPlaka.TabIndex = 6;
            // 
            // lblGuncelUcret
            // 
            this.lblGuncelUcret.AutoSize = true;
            this.lblGuncelUcret.Location = new System.Drawing.Point(8, 295);
            this.lblGuncelUcret.Name = "lblGuncelUcret";
            this.lblGuncelUcret.Size = new System.Drawing.Size(160, 24);
            this.lblGuncelUcret.TabIndex = 5;
            this.lblGuncelUcret.Text = "Günlük Kira Fiyatı:";
            // 
            // lblGuncelModel
            // 
            this.lblGuncelModel.AutoSize = true;
            this.lblGuncelModel.Location = new System.Drawing.Point(8, 237);
            this.lblGuncelModel.Name = "lblGuncelModel";
            this.lblGuncelModel.Size = new System.Drawing.Size(68, 24);
            this.lblGuncelModel.TabIndex = 4;
            this.lblGuncelModel.Text = "Model:";
            // 
            // lblGuncelMarka
            // 
            this.lblGuncelMarka.AutoSize = true;
            this.lblGuncelMarka.Location = new System.Drawing.Point(8, 169);
            this.lblGuncelMarka.Name = "lblGuncelMarka";
            this.lblGuncelMarka.Size = new System.Drawing.Size(71, 24);
            this.lblGuncelMarka.TabIndex = 3;
            this.lblGuncelMarka.Text = "Marka: ";
            // 
            // lblGuncelPlaka
            // 
            this.lblGuncelPlaka.AutoSize = true;
            this.lblGuncelPlaka.Location = new System.Drawing.Point(8, 110);
            this.lblGuncelPlaka.Name = "lblGuncelPlaka";
            this.lblGuncelPlaka.Size = new System.Drawing.Size(60, 24);
            this.lblGuncelPlaka.TabIndex = 2;
            this.lblGuncelPlaka.Text = "Plaka:";
            // 
            // lblAraclar
            // 
            this.lblAraclar.AutoSize = true;
            this.lblAraclar.Location = new System.Drawing.Point(25, 25);
            this.lblAraclar.Name = "lblAraclar";
            this.lblAraclar.Size = new System.Drawing.Size(74, 24);
            this.lblAraclar.TabIndex = 1;
            this.lblAraclar.Text = "Araçlar:";
            // 
            // cmbAraclar
            // 
            this.cmbAraclar.FormattingEnabled = true;
            this.cmbAraclar.Location = new System.Drawing.Point(115, 22);
            this.cmbAraclar.Name = "cmbAraclar";
            this.cmbAraclar.Size = new System.Drawing.Size(229, 30);
            this.cmbAraclar.TabIndex = 0;
            this.cmbAraclar.SelectedIndexChanged += new System.EventHandler(this.cmbAraclar_SelectedIndexChanged);
            // 
            // dgvVitrin
            // 
            this.dgvVitrin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVitrin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvChkSecim,
            this.dgvImgResim,
            this.dgvTxtMarka,
            this.dgvTxtModel,
            this.dgvTxtPlaka,
            this.dgvTxtUcret,
            this.dgvTxtVites,
            this.dgvTxtUygunluk});
            this.dgvVitrin.Location = new System.Drawing.Point(3, 7);
            this.dgvVitrin.Name = "dgvVitrin";
            this.dgvVitrin.RowHeadersWidth = 51;
            this.dgvVitrin.RowTemplate.Height = 24;
            this.dgvVitrin.Size = new System.Drawing.Size(1073, 477);
            this.dgvVitrin.TabIndex = 0;
            // 
            // dgvChkSecim
            // 
            this.dgvChkSecim.HeaderText = "Seç";
            this.dgvChkSecim.MinimumWidth = 6;
            this.dgvChkSecim.Name = "dgvChkSecim";
            this.dgvChkSecim.Width = 125;
            // 
            // dgvImgResim
            // 
            this.dgvImgResim.HeaderText = "Araç Resmi";
            this.dgvImgResim.MinimumWidth = 6;
            this.dgvImgResim.Name = "dgvImgResim";
            this.dgvImgResim.Width = 125;
            // 
            // dgvTxtMarka
            // 
            this.dgvTxtMarka.HeaderText = "Marka";
            this.dgvTxtMarka.MinimumWidth = 6;
            this.dgvTxtMarka.Name = "dgvTxtMarka";
            this.dgvTxtMarka.Width = 125;
            // 
            // dgvTxtModel
            // 
            this.dgvTxtModel.HeaderText = "Model";
            this.dgvTxtModel.MinimumWidth = 6;
            this.dgvTxtModel.Name = "dgvTxtModel";
            this.dgvTxtModel.Width = 125;
            // 
            // dgvTxtPlaka
            // 
            this.dgvTxtPlaka.HeaderText = "Plaka";
            this.dgvTxtPlaka.MinimumWidth = 6;
            this.dgvTxtPlaka.Name = "dgvTxtPlaka";
            this.dgvTxtPlaka.Width = 125;
            // 
            // dgvTxtUcret
            // 
            this.dgvTxtUcret.HeaderText = "Günlük Ücret (TL)";
            this.dgvTxtUcret.MinimumWidth = 6;
            this.dgvTxtUcret.Name = "dgvTxtUcret";
            this.dgvTxtUcret.Width = 125;
            // 
            // dgvTxtVites
            // 
            this.dgvTxtVites.HeaderText = "Vites Türü";
            this.dgvTxtVites.MinimumWidth = 6;
            this.dgvTxtVites.Name = "dgvTxtVites";
            this.dgvTxtVites.Width = 125;
            // 
            // dgvTxtUygunluk
            // 
            this.dgvTxtUygunluk.HeaderText = "Durum";
            this.dgvTxtUygunluk.MinimumWidth = 6;
            this.dgvTxtUygunluk.Name = "dgvTxtUygunluk";
            this.dgvTxtUygunluk.Width = 125;
            // 
            // AnaMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 572);
            this.Controls.Add(this.tabAracDüzenle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaMenuForm";
            this.Text = "Ana Menü ";
            this.Load += new System.EventHandler(this.AnaMenuForm_Load);
            this.tabAracDüzenle.ResumeLayout(false);
            this.tabAracSecimi.ResumeLayout(false);
            this.tabAracGiris.ResumeLayout(false);
            this.tabAracGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBxAracResmi)).EndInit();
            this.YeniAracBilgi.ResumeLayout(false);
            this.YeniAracBilgi.PerformLayout();
            this.tabAracDuzenle.ResumeLayout(false);
            this.tabAracDuzenle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBxGuncelResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVitrin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAracDüzenle;
        private System.Windows.Forms.TabPage tabAracSecimi;
        private System.Windows.Forms.TabPage tabAracGiris;
        private System.Windows.Forms.GroupBox YeniAracBilgi;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblVites;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.RadioButton rbtnManuel;
        private System.Windows.Forms.RadioButton rbtnOtomatik;
        private System.Windows.Forms.Label lblAracResim;
        private System.Windows.Forms.Button btnKaydetAracBilgi;
        private System.Windows.Forms.Button btnResmiSec;
        private System.Windows.Forms.PictureBox pictBxAracResmi;
        private System.Windows.Forms.TabPage tabAracDuzenle;
        private System.Windows.Forms.Label lblAraclar;
        private System.Windows.Forms.ComboBox cmbAraclar;
        private System.Windows.Forms.Label lblGuncelUcret;
        private System.Windows.Forms.Label lblGuncelModel;
        private System.Windows.Forms.Label lblGuncelMarka;
        private System.Windows.Forms.Label lblGuncelPlaka;
        private System.Windows.Forms.TextBox txtGuncelUcret;
        private System.Windows.Forms.TextBox txtGuncelModel;
        private System.Windows.Forms.TextBox txtGuncelMarka;
        private System.Windows.Forms.TextBox txtGuncelPlaka;
        private System.Windows.Forms.PictureBox pictBxGuncelResim;
        private System.Windows.Forms.CheckBox chkGuncelUygunluk;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnResimGuncelle;
        private System.Windows.Forms.DataGridView dgvVitrin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkSecim;
        private System.Windows.Forms.DataGridViewImageColumn dgvImgResim;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtMarka;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtPlaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtUcret;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtVites;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTxtUygunluk;
    }
}