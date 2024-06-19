namespace OgrenciKayitFormu
{
    partial class OgrencGirisFormu
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
            txtTCKimlik = new TextBox();
            label1 = new Label();
            txtAdSoyad = new TextBox();
            label2 = new Label();
            txtNo = new MaskedTextBox();
            label3 = new Label();
            rbErkek = new RadioButton();
            rbKadin = new RadioButton();
            label4 = new Label();
            cmbIller = new ComboBox();
            label5 = new Label();
            dtpDogumTar = new DateTimePicker();
            label6 = new Label();
            rbVeri = new CheckBox();
            btnKaydet = new Button();
            btnKapat = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtTCKimlik
            // 
            txtTCKimlik.AccessibleName = "";
            txtTCKimlik.Location = new Point(213, 133);
            txtTCKimlik.Name = "txtTCKimlik";
            txtTCKimlik.Size = new Size(193, 27);
            txtTCKimlik.TabIndex = 0;
            // 
            // label1
            // 
            label1.AccessibleName = "";
            label1.AutoSize = true;
            label1.Location = new Point(128, 107);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Ad-Soyad:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.AccessibleName = "";
            txtAdSoyad.Location = new Point(213, 100);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(193, 27);
            txtAdSoyad.TabIndex = 2;
            // 
            // label2
            // 
            label2.AccessibleName = "";
            label2.AutoSize = true;
            label2.Location = new Point(133, 140);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "TC Kimlik:";
            // 
            // txtNo
            // 
            txtNo.AccessibleName = "";
            txtNo.Location = new Point(213, 165);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(193, 27);
            txtNo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AccessibleName = "";
            label3.AutoSize = true;
            label3.Location = new Point(107, 173);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 5;
            label3.Text = "Cep Telefonu:";
            // 
            // rbErkek
            // 
            rbErkek.AccessibleName = "";
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(225, 199);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(65, 24);
            rbErkek.TabIndex = 6;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            rbKadin.AccessibleName = "";
            rbKadin.AutoSize = true;
            rbKadin.Location = new Point(326, 199);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(68, 24);
            rbKadin.TabIndex = 7;
            rbKadin.TabStop = true;
            rbKadin.Text = "Kadın";
            rbKadin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AccessibleName = "";
            label4.AutoSize = true;
            label4.Location = new Point(143, 203);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 8;
            label4.Text = "Cinsiyet:";
            // 
            // cmbIller
            // 
            cmbIller.AccessibleName = "";
            cmbIller.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIller.FormattingEnabled = true;
            cmbIller.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" });
            cmbIller.Location = new Point(213, 229);
            cmbIller.Name = "cmbIller";
            cmbIller.Size = new Size(193, 28);
            cmbIller.TabIndex = 9;
            // 
            // label5
            // 
            label5.AccessibleName = "";
            label5.AutoSize = true;
            label5.Location = new Point(107, 237);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 10;
            label5.Text = "Yaşadığınız İl:";
            // 
            // dtpDogumTar
            // 
            dtpDogumTar.Format = DateTimePickerFormat.Short;
            dtpDogumTar.Location = new Point(213, 263);
            dtpDogumTar.Name = "dtpDogumTar";
            dtpDogumTar.Size = new Size(193, 27);
            dtpDogumTar.TabIndex = 11;
            dtpDogumTar.Value = new DateTime(2023, 7, 26, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AccessibleName = "";
            label6.AutoSize = true;
            label6.Location = new Point(105, 268);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 12;
            label6.Text = "Doğum Tarihi:";
            // 
            // rbVeri
            // 
            rbVeri.AccessibleName = "";
            rbVeri.AutoSize = true;
            rbVeri.ForeColor = Color.FromArgb(128, 128, 255);
            rbVeri.Location = new Point(37, 349);
            rbVeri.Name = "rbVeri";
            rbVeri.Size = new Size(400, 24);
            rbVeri.TabIndex = 13;
            rbVeri.Text = "Bilgilerimin Veri Tabanına aktarılmasına onay veriyorum.";
            rbVeri.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.AccessibleName = "";
            btnKaydet.BackColor = Color.FromArgb(128, 255, 128);
            btnKaydet.Location = new Point(87, 397);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 14;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnKapat
            // 
            btnKapat.AccessibleName = "";
            btnKapat.BackColor = Color.FromArgb(255, 128, 128);
            btnKapat.Location = new Point(309, 397);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(94, 29);
            btnKapat.TabIndex = 15;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(119, 19);
            label7.Name = "label7";
            label7.Size = new Size(286, 35);
            label7.TabIndex = 16;
            label7.Text = "Öğrenci Kayıt Formu";
            // 
            // OgrencGirisFormu
            // 
            AccessibleName = "OgrenciGirisFormu";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 464);
            Controls.Add(label7);
            Controls.Add(btnKapat);
            Controls.Add(btnKaydet);
            Controls.Add(rbVeri);
            Controls.Add(label6);
            Controls.Add(dtpDogumTar);
            Controls.Add(label5);
            Controls.Add(cmbIller);
            Controls.Add(label4);
            Controls.Add(rbKadin);
            Controls.Add(rbErkek);
            Controls.Add(label3);
            Controls.Add(txtNo);
            Controls.Add(label2);
            Controls.Add(txtAdSoyad);
            Controls.Add(label1);
            Controls.Add(txtTCKimlik);
            Name = "OgrencGirisFormu";
            Text = "OgrenciGirisFormu";
            Load += OgrencGirisFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTCKimlik;
        private Label label1;
        private TextBox txtAdSoyad;
        private Label label2;
        private MaskedTextBox txtNo;
        private Label label3;
        private RadioButton rbErkek;
        private RadioButton rbKadin;
        private Label label4;
        private ComboBox cmbIller;
        private Label label5;
        private DateTimePicker dtpDogumTar;
        private Label label6;
        private CheckBox rbVeri;
        private Button btnKaydet;
        private Button btnKapat;
        private Label label7;
    }
}