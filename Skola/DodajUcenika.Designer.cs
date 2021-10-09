namespace Skola
{
    partial class DodajUcenika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajUcenika));
            this.ime_ucenika_txt = new System.Windows.Forms.TextBox();
            this.prezime_ucenika_txt = new System.Windows.Forms.TextBox();
            this.ulica_ucenika_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.broj_ulice_ucenika_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.smerID = new System.Windows.Forms.TextBox();
            this.dodaj_ucenika_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.razred_combobox = new System.Windows.Forms.ComboBox();
            this.datum_upisa_ucenika = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nazad_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ime_ucenika_txt
            // 
            this.ime_ucenika_txt.Location = new System.Drawing.Point(120, 30);
            this.ime_ucenika_txt.Name = "ime_ucenika_txt";
            this.ime_ucenika_txt.Size = new System.Drawing.Size(260, 22);
            this.ime_ucenika_txt.TabIndex = 0;
            this.ime_ucenika_txt.TextChanged += new System.EventHandler(this.ime_ucenika_txt_TextChanged);
            // 
            // prezime_ucenika_txt
            // 
            this.prezime_ucenika_txt.Location = new System.Drawing.Point(120, 58);
            this.prezime_ucenika_txt.Name = "prezime_ucenika_txt";
            this.prezime_ucenika_txt.Size = new System.Drawing.Size(260, 22);
            this.prezime_ucenika_txt.TabIndex = 1;
            this.prezime_ucenika_txt.TextChanged += new System.EventHandler(this.prezime_ucenika_txt_TextChanged);
            // 
            // ulica_ucenika_txt
            // 
            this.ulica_ucenika_txt.Location = new System.Drawing.Point(120, 113);
            this.ulica_ucenika_txt.Name = "ulica_ucenika_txt";
            this.ulica_ucenika_txt.Size = new System.Drawing.Size(162, 22);
            this.ulica_ucenika_txt.TabIndex = 2;
            this.ulica_ucenika_txt.TextChanged += new System.EventHandler(this.ulica_ucenika_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ulica";
            // 
            // broj_ulice_ucenika_txt
            // 
            this.broj_ulice_ucenika_txt.Location = new System.Drawing.Point(306, 113);
            this.broj_ulice_ucenika_txt.Name = "broj_ulice_ucenika_txt";
            this.broj_ulice_ucenika_txt.Size = new System.Drawing.Size(74, 22);
            this.broj_ulice_ucenika_txt.TabIndex = 6;
            this.broj_ulice_ucenika_txt.TextChanged += new System.EventHandler(this.broj_ulice_ucenika_txt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.smerID);
            this.groupBox1.Controls.Add(this.dodaj_ucenika_btn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.razred_combobox);
            this.groupBox1.Controls.Add(this.datum_upisa_ucenika);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ime_ucenika_txt);
            this.groupBox1.Controls.Add(this.broj_ulice_ucenika_txt);
            this.groupBox1.Controls.Add(this.prezime_ucenika_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ulica_ucenika_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 252);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije učenika";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(75, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Brown;
            this.label12.Location = new System.Drawing.Point(101, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Brown;
            this.label11.Location = new System.Drawing.Point(101, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "*";
            // 
            // smerID
            // 
            this.smerID.Location = new System.Drawing.Point(120, 138);
            this.smerID.Name = "smerID";
            this.smerID.Size = new System.Drawing.Size(260, 22);
            this.smerID.TabIndex = 18;
            this.smerID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dodaj_ucenika_btn
            // 
            this.dodaj_ucenika_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dodaj_ucenika_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dodaj_ucenika_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.dodaj_ucenika_btn.Location = new System.Drawing.Point(280, 205);
            this.dodaj_ucenika_btn.Name = "dodaj_ucenika_btn";
            this.dodaj_ucenika_btn.Size = new System.Drawing.Size(100, 40);
            this.dodaj_ucenika_btn.TabIndex = 16;
            this.dodaj_ucenika_btn.Text = "Dodaj";
            this.dodaj_ucenika_btn.UseVisualStyleBackColor = false;
            this.dodaj_ucenika_btn.Click += new System.EventHandler(this.dodaj_ucenika_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Razred";
            // 
            // razred_combobox
            // 
            this.razred_combobox.FormattingEnabled = true;
            this.razred_combobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.razred_combobox.Location = new System.Drawing.Point(120, 84);
            this.razred_combobox.Name = "razred_combobox";
            this.razred_combobox.Size = new System.Drawing.Size(260, 24);
            this.razred_combobox.TabIndex = 12;
            this.razred_combobox.SelectedIndexChanged += new System.EventHandler(this.razred_combobox_SelectedIndexChanged);
            // 
            // datum_upisa_ucenika
            // 
            this.datum_upisa_ucenika.Location = new System.Drawing.Point(120, 171);
            this.datum_upisa_ucenika.Name = "datum_upisa_ucenika";
            this.datum_upisa_ucenika.Size = new System.Drawing.Size(260, 22);
            this.datum_upisa_ucenika.TabIndex = 8;
            this.datum_upisa_ucenika.ValueChanged += new System.EventHandler(this.datum_upisa_ucenika_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Datum upisa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Naziv Smera";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(75, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(43, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "*";
            // 
            // nazad_btn
            // 
            this.nazad_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.nazad_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.nazad_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.nazad_btn.Location = new System.Drawing.Point(9, 15);
            this.nazad_btn.Name = "nazad_btn";
            this.nazad_btn.Size = new System.Drawing.Size(100, 40);
            this.nazad_btn.TabIndex = 17;
            this.nazad_btn.Text = "Nazad";
            this.nazad_btn.UseVisualStyleBackColor = false;
            this.nazad_btn.Click += new System.EventHandler(this.nazad_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.groupBox2.Controls.Add(this.nazad_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 66);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // DodajUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(432, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajUcenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj učenika";
            this.Load += new System.EventHandler(this.DodajUcenika_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ime_ucenika_txt;
        private System.Windows.Forms.TextBox prezime_ucenika_txt;
        private System.Windows.Forms.TextBox ulica_ucenika_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox broj_ulice_ucenika_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datum_upisa_ucenika;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox razred_combobox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button dodaj_ucenika_btn;
        private System.Windows.Forms.Button nazad_btn;
        private System.Windows.Forms.TextBox smerID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}