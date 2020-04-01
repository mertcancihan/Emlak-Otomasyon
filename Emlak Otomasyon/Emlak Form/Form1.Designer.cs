namespace Emlak_Form
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_fiyat = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_ilce = new System.Windows.Forms.ComboBox();
            this.comboBox_il = new System.Windows.Forms.ComboBox();
            this.comboBox_tur = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_kat = new System.Windows.Forms.TextBox();
            this.textBox_alan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_oda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EvinDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.il = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmlakNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KatSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvinAlani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BinaYasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MuhtemelKira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_list = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rBtn_rent = new System.Windows.Forms.RadioButton();
            this.rBtn_sale = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rBtn_all = new System.Windows.Forms.RadioButton();
            this.rBtn_deactive = new System.Windows.Forms.RadioButton();
            this.rBtn_active = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox2_ilce = new System.Windows.Forms.ComboBox();
            this.comboBox2_il = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.textBox_kira = new System.Windows.Forms.TextBox();
            this.textBox_deposit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(900, 600);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.btn_kayit);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kayıt Ekranı";
            // 
            // btn_kayit
            // 
            this.btn_kayit.BackColor = System.Drawing.Color.White;
            this.btn_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_kayit.Location = new System.Drawing.Point(386, 202);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(178, 81);
            this.btn_kayit.TabIndex = 10;
            this.btn_kayit.Text = "Kayıt Ekle";
            this.btn_kayit.UseVisualStyleBackColor = false;
            this.btn_kayit.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox_fiyat);
            this.groupBox3.Location = new System.Drawing.Point(129, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 87);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(15, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fiyat :";
            // 
            // textBox_fiyat
            // 
            this.textBox_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_fiyat.Location = new System.Drawing.Point(72, 19);
            this.textBox_fiyat.Name = "textBox_fiyat";
            this.textBox_fiyat.Size = new System.Drawing.Size(100, 23);
            this.textBox_fiyat.TabIndex = 3;
            this.textBox_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(28, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 87);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton1.Location = new System.Drawing.Point(7, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Satılık";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton2.Location = new System.Drawing.Point(6, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kiralık";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_ilce);
            this.groupBox1.Controls.Add(this.comboBox_il);
            this.groupBox1.Controls.Add(this.comboBox_tur);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_kat);
            this.groupBox1.Controls.Add(this.textBox_alan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_oda);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(28, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 148);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // comboBox_ilce
            // 
            this.comboBox_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ilce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_ilce.FormattingEnabled = true;
            this.comboBox_ilce.Location = new System.Drawing.Point(68, 63);
            this.comboBox_ilce.Name = "comboBox_ilce";
            this.comboBox_ilce.Size = new System.Drawing.Size(121, 24);
            this.comboBox_ilce.TabIndex = 1;
            // 
            // comboBox_il
            // 
            this.comboBox_il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_il.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_il.FormattingEnabled = true;
            this.comboBox_il.Location = new System.Drawing.Point(68, 33);
            this.comboBox_il.Name = "comboBox_il";
            this.comboBox_il.Size = new System.Drawing.Size(121, 24);
            this.comboBox_il.TabIndex = 0;
            this.comboBox_il.SelectedValueChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // comboBox_tur
            // 
            this.comboBox_tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_tur.FormattingEnabled = true;
            this.comboBox_tur.Location = new System.Drawing.Point(554, 29);
            this.comboBox_tur.Name = "comboBox_tur";
            this.comboBox_tur.Size = new System.Drawing.Size(110, 24);
            this.comboBox_tur.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(554, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 23);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(1998, 2, 18, 10, 46, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "İl :";
            // 
            // textBox_kat
            // 
            this.textBox_kat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_kat.Location = new System.Drawing.Point(317, 95);
            this.textBox_kat.Name = "textBox_kat";
            this.textBox_kat.Size = new System.Drawing.Size(100, 23);
            this.textBox_kat.TabIndex = 3;
            this.textBox_kat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox_alan
            // 
            this.textBox_alan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_alan.Location = new System.Drawing.Point(317, 63);
            this.textBox_alan.Name = "textBox_alan";
            this.textBox_alan.Size = new System.Drawing.Size(100, 23);
            this.textBox_alan.TabIndex = 3;
            this.textBox_alan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(219, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Oda Sayısı :";
            // 
            // textBox_oda
            // 
            this.textBox_oda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_oda.Location = new System.Drawing.Point(317, 31);
            this.textBox_oda.Name = "textBox_oda";
            this.textBox_oda.Size = new System.Drawing.Size(100, 23);
            this.textBox_oda.TabIndex = 3;
            this.textBox_oda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "İlçe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(444, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Yapım Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(444, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Türü :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(219, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Kat Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(219, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Alan(m2) :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btn_guncelle);
            this.tabPage2.Controls.Add(this.btn_sil);
            this.tabPage2.Controls.Add(this.btn_list);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sorgulama Ekranı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EvinDurumu,
            this.il,
            this.ilce,
            this.EmlakNo,
            this.OdaSayisi,
            this.KatSayisi,
            this.EvinAlani,
            this.Turu,
            this.BinaYasi,
            this.MuhtemelKira});
            this.dataGridView1.Location = new System.Drawing.Point(42, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(809, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // EvinDurumu
            // 
            this.EvinDurumu.HeaderText = "Evin Durumu";
            this.EvinDurumu.Name = "EvinDurumu";
            this.EvinDurumu.Width = 60;
            // 
            // il
            // 
            this.il.HeaderText = "İl";
            this.il.Name = "il";
            this.il.Width = 110;
            // 
            // ilce
            // 
            this.ilce.HeaderText = "İlçe";
            this.ilce.Name = "ilce";
            this.ilce.Width = 110;
            // 
            // EmlakNo
            // 
            this.EmlakNo.HeaderText = "Emlak No";
            this.EmlakNo.Name = "EmlakNo";
            this.EmlakNo.Width = 60;
            // 
            // OdaSayisi
            // 
            this.OdaSayisi.HeaderText = "Oda Sayısı";
            this.OdaSayisi.Name = "OdaSayisi";
            this.OdaSayisi.Width = 60;
            // 
            // KatSayisi
            // 
            this.KatSayisi.HeaderText = "Kat Sayısı";
            this.KatSayisi.Name = "KatSayisi";
            this.KatSayisi.Width = 60;
            // 
            // EvinAlani
            // 
            this.EvinAlani.HeaderText = "Evin Alanı";
            this.EvinAlani.Name = "EvinAlani";
            this.EvinAlani.Width = 60;
            // 
            // Turu
            // 
            this.Turu.HeaderText = "Türü";
            this.Turu.Name = "Turu";
            this.Turu.Width = 80;
            // 
            // BinaYasi
            // 
            this.BinaYasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BinaYasi.HeaderText = "Bina Yaşı";
            this.BinaYasi.Name = "BinaYasi";
            this.BinaYasi.Width = 76;
            // 
            // MuhtemelKira
            // 
            this.MuhtemelKira.HeaderText = "Muhtemel Kira";
            this.MuhtemelKira.Name = "MuhtemelKira";
            this.MuhtemelKira.Width = 60;
            // 
            // btn_list
            // 
            this.btn_list.BackColor = System.Drawing.Color.White;
            this.btn_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_list.Location = new System.Drawing.Point(494, 60);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(115, 115);
            this.btn_list.TabIndex = 11;
            this.btn_list.Text = "Listele";
            this.btn_list.UseVisualStyleBackColor = false;
            this.btn_list.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rBtn_rent);
            this.groupBox7.Controls.Add(this.rBtn_sale);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox7.Location = new System.Drawing.Point(372, 60);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(98, 115);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ev Tercihi";
            // 
            // rBtn_rent
            // 
            this.rBtn_rent.AutoSize = true;
            this.rBtn_rent.Location = new System.Drawing.Point(15, 57);
            this.rBtn_rent.Name = "rBtn_rent";
            this.rBtn_rent.Size = new System.Drawing.Size(64, 21);
            this.rBtn_rent.TabIndex = 0;
            this.rBtn_rent.TabStop = true;
            this.rBtn_rent.Text = "Kiralık";
            this.rBtn_rent.UseVisualStyleBackColor = true;
            // 
            // rBtn_sale
            // 
            this.rBtn_sale.AutoSize = true;
            this.rBtn_sale.Location = new System.Drawing.Point(16, 30);
            this.rBtn_sale.Name = "rBtn_sale";
            this.rBtn_sale.Size = new System.Drawing.Size(63, 21);
            this.rBtn_sale.TabIndex = 0;
            this.rBtn_sale.TabStop = true;
            this.rBtn_sale.Text = "Satılık";
            this.rBtn_sale.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rBtn_all);
            this.groupBox6.Controls.Add(this.rBtn_deactive);
            this.groupBox6.Controls.Add(this.rBtn_active);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox6.Location = new System.Drawing.Point(264, 60);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(102, 115);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ev Durumu";
            // 
            // rBtn_all
            // 
            this.rBtn_all.AutoSize = true;
            this.rBtn_all.Checked = true;
            this.rBtn_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rBtn_all.Location = new System.Drawing.Point(16, 84);
            this.rBtn_all.Name = "rBtn_all";
            this.rBtn_all.Size = new System.Drawing.Size(62, 21);
            this.rBtn_all.TabIndex = 0;
            this.rBtn_all.TabStop = true;
            this.rBtn_all.Text = "Tümü";
            this.rBtn_all.UseVisualStyleBackColor = true;
            // 
            // rBtn_deactive
            // 
            this.rBtn_deactive.AutoSize = true;
            this.rBtn_deactive.Location = new System.Drawing.Point(16, 57);
            this.rBtn_deactive.Name = "rBtn_deactive";
            this.rBtn_deactive.Size = new System.Drawing.Size(57, 21);
            this.rBtn_deactive.TabIndex = 0;
            this.rBtn_deactive.TabStop = true;
            this.rBtn_deactive.Text = "Pasif";
            this.rBtn_deactive.UseVisualStyleBackColor = true;
            // 
            // rBtn_active
            // 
            this.rBtn_active.AutoSize = true;
            this.rBtn_active.Location = new System.Drawing.Point(16, 30);
            this.rBtn_active.Name = "rBtn_active";
            this.rBtn_active.Size = new System.Drawing.Size(53, 21);
            this.rBtn_active.TabIndex = 0;
            this.rBtn_active.TabStop = true;
            this.rBtn_active.Text = "Aktif";
            this.rBtn_active.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox2_ilce);
            this.groupBox5.Controls.Add(this.comboBox2_il);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox5.Location = new System.Drawing.Point(42, 60);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(216, 115);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ev Adres Bilgileri";
            // 
            // comboBox2_ilce
            // 
            this.comboBox2_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2_ilce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox2_ilce.FormattingEnabled = true;
            this.comboBox2_ilce.Location = new System.Drawing.Point(64, 60);
            this.comboBox2_ilce.Name = "comboBox2_ilce";
            this.comboBox2_ilce.Size = new System.Drawing.Size(121, 24);
            this.comboBox2_ilce.TabIndex = 4;
            // 
            // comboBox2_il
            // 
            this.comboBox2_il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2_il.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox2_il.FormattingEnabled = true;
            this.comboBox2_il.Location = new System.Drawing.Point(64, 30);
            this.comboBox2_il.Name = "comboBox2_il";
            this.comboBox2_il.Size = new System.Drawing.Size(121, 24);
            this.comboBox2_il.TabIndex = 3;
            this.comboBox2_il.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(16, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "İl :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(16, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "İlçe :";
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.White;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_sil.Location = new System.Drawing.Point(615, 60);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(115, 115);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.button_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.White;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_guncelle.Location = new System.Drawing.Point(736, 60);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(115, 115);
            this.btn_guncelle.TabIndex = 11;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox_kira
            // 
            this.textBox_kira.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_kira.Location = new System.Drawing.Point(102, 19);
            this.textBox_kira.Name = "textBox_kira";
            this.textBox_kira.Size = new System.Drawing.Size(100, 23);
            this.textBox_kira.TabIndex = 3;
            this.textBox_kira.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox_deposit
            // 
            this.textBox_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_deposit.Location = new System.Drawing.Point(102, 48);
            this.textBox_deposit.Name = "textBox_deposit";
            this.textBox_deposit.Size = new System.Drawing.Size(100, 23);
            this.textBox_deposit.TabIndex = 3;
            this.textBox_deposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(15, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kira :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(15, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Depozito :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox_deposit);
            this.groupBox4.Controls.Add(this.textBox_kira);
            this.groupBox4.Location = new System.Drawing.Point(129, 196);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 87);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 596);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_oda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ilce;
        private System.Windows.Forms.ComboBox comboBox_il;
        private System.Windows.Forms.TextBox textBox_alan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_tur;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_fiyat;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.TextBox textBox_kat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rBtn_rent;
        private System.Windows.Forms.RadioButton rBtn_sale;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rBtn_all;
        private System.Windows.Forms.RadioButton rBtn_deactive;
        private System.Windows.Forms.RadioButton rBtn_active;
        private System.Windows.Forms.ComboBox comboBox2_ilce;
        private System.Windows.Forms.ComboBox comboBox2_il;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvinDurumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn il;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilce;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmlakNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KatSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvinAlani;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn BinaYasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MuhtemelKira;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_deposit;
        private System.Windows.Forms.TextBox textBox_kira;
    }
}