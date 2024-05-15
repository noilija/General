namespace OOPrL4v2
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
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.pickerDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.pickerVaziDo = new System.Windows.Forms.DateTimePicker();
            this.pickerVaziOd = new System.Windows.Forms.DateTimePicker();
            this.tbBrojVozacke = new System.Windows.Forms.TextBox();
            this.tbMestoIzdavanja = new System.Windows.Forms.TextBox();
            this.comboPol = new System.Windows.Forms.ComboBox();
            this.slikaVozaca = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btDodajSliku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnPrikaziListu = new System.Windows.Forms.Button();
            this.dgListaVozaca = new System.Windows.Forms.DataGridView();
            this.dgKateg = new System.Windows.Forms.DataGridView();
            this.cKategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDatumOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDatumDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgZabrane = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBrojVozacke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.slikaVozaca)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaVozaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKateg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgZabrane)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(144, 36);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(100, 22);
            this.tbIme.TabIndex = 0;
            this.tbIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIme_KeyPress);
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(144, 64);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(100, 22);
            this.tbPrezime.TabIndex = 1;
            this.tbPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIme_KeyPress);
            // 
            // pickerDatumRodjenja
            // 
            this.pickerDatumRodjenja.Location = new System.Drawing.Point(144, 92);
            this.pickerDatumRodjenja.Name = "pickerDatumRodjenja";
            this.pickerDatumRodjenja.Size = new System.Drawing.Size(100, 22);
            this.pickerDatumRodjenja.TabIndex = 2;
            // 
            // pickerVaziDo
            // 
            this.pickerVaziDo.Location = new System.Drawing.Point(144, 150);
            this.pickerVaziDo.Name = "pickerVaziDo";
            this.pickerVaziDo.Size = new System.Drawing.Size(100, 22);
            this.pickerVaziDo.TabIndex = 3;
            // 
            // pickerVaziOd
            // 
            this.pickerVaziOd.Location = new System.Drawing.Point(144, 122);
            this.pickerVaziOd.Name = "pickerVaziOd";
            this.pickerVaziOd.Size = new System.Drawing.Size(100, 22);
            this.pickerVaziOd.TabIndex = 4;
            // 
            // tbBrojVozacke
            // 
            this.tbBrojVozacke.Location = new System.Drawing.Point(144, 178);
            this.tbBrojVozacke.Name = "tbBrojVozacke";
            this.tbBrojVozacke.Size = new System.Drawing.Size(100, 22);
            this.tbBrojVozacke.TabIndex = 5;
            this.tbBrojVozacke.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBrojVozacke_KeyPress);
            // 
            // tbMestoIzdavanja
            // 
            this.tbMestoIzdavanja.Location = new System.Drawing.Point(144, 206);
            this.tbMestoIzdavanja.Name = "tbMestoIzdavanja";
            this.tbMestoIzdavanja.Size = new System.Drawing.Size(100, 22);
            this.tbMestoIzdavanja.TabIndex = 6;
            this.tbMestoIzdavanja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIme_KeyPress);
            // 
            // comboPol
            // 
            this.comboPol.FormattingEnabled = true;
            this.comboPol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.comboPol.Location = new System.Drawing.Point(144, 234);
            this.comboPol.Name = "comboPol";
            this.comboPol.Size = new System.Drawing.Size(100, 24);
            this.comboPol.TabIndex = 7;
            // 
            // slikaVozaca
            // 
            this.slikaVozaca.Location = new System.Drawing.Point(295, 36);
            this.slikaVozaca.Name = "slikaVozaca";
            this.slikaVozaca.Size = new System.Drawing.Size(182, 162);
            this.slikaVozaca.TabIndex = 8;
            this.slikaVozaca.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btDodajSliku
            // 
            this.btDodajSliku.Location = new System.Drawing.Point(320, 216);
            this.btDodajSliku.Name = "btDodajSliku";
            this.btDodajSliku.Size = new System.Drawing.Size(132, 42);
            this.btDodajSliku.TabIndex = 9;
            this.btDodajSliku.Text = "Dodaj sliku";
            this.btDodajSliku.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ime";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbIme);
            this.groupBox1.Controls.Add(this.btDodajSliku);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.slikaVozaca);
            this.groupBox1.Controls.Add(this.tbPrezime);
            this.groupBox1.Controls.Add(this.pickerDatumRodjenja);
            this.groupBox1.Controls.Add(this.comboPol);
            this.groupBox1.Controls.Add(this.pickerVaziDo);
            this.groupBox1.Controls.Add(this.tbMestoIzdavanja);
            this.groupBox1.Controls.Add(this.pickerVaziOd);
            this.groupBox1.Controls.Add(this.tbBrojVozacke);
            this.groupBox1.Location = new System.Drawing.Point(28, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 269);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pol";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mesto izdavanja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Broj vozacke";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dozvola vazi od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Datum rodjenja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prezime";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgKateg);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(28, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 216);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategorije";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Obrisi kategoriju";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj novu kategoriju";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgZabrane);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(28, 534);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 206);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zabrana upravljanja";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "Obrisi kategoriju";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Dodaj novu kategoriju";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(203, 746);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(102, 36);
            this.btnProsledi.TabIndex = 5;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(321, 746);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(102, 36);
            this.btnZatvori.TabIndex = 14;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnPrikaziListu
            // 
            this.btnPrikaziListu.Location = new System.Drawing.Point(505, 747);
            this.btnPrikaziListu.Name = "btnPrikaziListu";
            this.btnPrikaziListu.Size = new System.Drawing.Size(102, 36);
            this.btnPrikaziListu.TabIndex = 15;
            this.btnPrikaziListu.Text = "Priikazi Listu";
            this.btnPrikaziListu.UseVisualStyleBackColor = true;
            this.btnPrikaziListu.Click += new System.EventHandler(this.btnPrikaziListu_Click);
            // 
            // dgListaVozaca
            // 
            this.dgListaVozaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaVozaca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIme,
            this.cPrezime,
            this.cBrojVozacke});
            this.dgListaVozaca.Location = new System.Drawing.Point(662, 253);
            this.dgListaVozaca.Name = "dgListaVozaca";
            this.dgListaVozaca.RowHeadersWidth = 51;
            this.dgListaVozaca.RowTemplate.Height = 24;
            this.dgListaVozaca.Size = new System.Drawing.Size(541, 117);
            this.dgListaVozaca.TabIndex = 3;
            // 
            // dgKateg
            // 
            this.dgKateg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKateg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cKategorija,
            this.cDatumOd,
            this.cDatumDo});
            this.dgKateg.Location = new System.Drawing.Point(18, 31);
            this.dgKateg.Name = "dgKateg";
            this.dgKateg.RowHeadersWidth = 51;
            this.dgKateg.RowTemplate.Height = 24;
            this.dgKateg.Size = new System.Drawing.Size(541, 117);
            this.dgKateg.TabIndex = 16;
            // 
            // cKategorija
            // 
            this.cKategorija.HeaderText = "Kategorija";
            this.cKategorija.MinimumWidth = 6;
            this.cKategorija.Name = "cKategorija";
            this.cKategorija.Width = 125;
            // 
            // cDatumOd
            // 
            this.cDatumOd.HeaderText = "DatumOd";
            this.cDatumOd.MinimumWidth = 6;
            this.cDatumOd.Name = "cDatumOd";
            this.cDatumOd.Width = 125;
            // 
            // cDatumDo
            // 
            this.cDatumDo.HeaderText = "DatumDo";
            this.cDatumDo.MinimumWidth = 6;
            this.cDatumDo.Name = "cDatumDo";
            this.cDatumDo.Width = 125;
            // 
            // dgZabrane
            // 
            this.dgZabrane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgZabrane.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgZabrane.Location = new System.Drawing.Point(18, 21);
            this.dgZabrane.Name = "dgZabrane";
            this.dgZabrane.RowHeadersWidth = 51;
            this.dgZabrane.RowTemplate.Height = 24;
            this.dgZabrane.Size = new System.Drawing.Size(541, 110);
            this.dgZabrane.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Kategorija";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "DatumOd";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "DatumDo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // cIme
            // 
            this.cIme.HeaderText = "Ime";
            this.cIme.MinimumWidth = 6;
            this.cIme.Name = "cIme";
            this.cIme.Width = 125;
            // 
            // cPrezime
            // 
            this.cPrezime.HeaderText = "Prezime";
            this.cPrezime.MinimumWidth = 6;
            this.cPrezime.Name = "cPrezime";
            this.cPrezime.Width = 125;
            // 
            // cBrojVozacke
            // 
            this.cBrojVozacke.HeaderText = "BrojVozacke";
            this.cBrojVozacke.MinimumWidth = 6;
            this.cBrojVozacke.Name = "cBrojVozacke";
            this.cBrojVozacke.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 795);
            this.Controls.Add(this.dgListaVozaca);
            this.Controls.Add(this.btnPrikaziListu);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slikaVozaca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaVozaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKateg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgZabrane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.DateTimePicker pickerDatumRodjenja;
        private System.Windows.Forms.DateTimePicker pickerVaziDo;
        private System.Windows.Forms.DateTimePicker pickerVaziOd;
        private System.Windows.Forms.TextBox tbBrojVozacke;
        private System.Windows.Forms.TextBox tbMestoIzdavanja;
        private System.Windows.Forms.ComboBox comboPol;
        private System.Windows.Forms.PictureBox slikaVozaca;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btDodajSliku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnPrikaziListu;
        private System.Windows.Forms.DataGridView dgListaVozaca;
        private System.Windows.Forms.DataGridView dgKateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDatumOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDatumDo;
        private System.Windows.Forms.DataGridView dgZabrane;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBrojVozacke;
    }
}

