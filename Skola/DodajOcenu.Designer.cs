namespace Skola
{
    partial class DodajOcenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajOcenu));
            this.ocena_combobox = new System.Windows.Forms.ComboBox();
            this.ocena_label = new System.Windows.Forms.Label();
            this.opis_ocene_txt = new System.Windows.Forms.TextBox();
            this.opis_label = new System.Windows.Forms.Label();
            this.datum_dobijanja = new System.Windows.Forms.Label();
            this.datum_dobijanja_box = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1_NazivPredmeta = new System.Windows.Forms.TextBox();
            this.id_ucenika_txt = new System.Windows.Forms.TextBox();
            this.id_ucenika_label = new System.Windows.Forms.Label();
            this.lista_ucenika_data_grid_view = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1_Obrisi = new System.Windows.Forms.Button();
            this.button1_Azuriraj = new System.Windows.Forms.Button();
            this.button2_Dodaj = new System.Windows.Forms.Button();
            this.button1_Nazad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_ucenika_data_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // ocena_combobox
            // 
            this.ocena_combobox.FormattingEnabled = true;
            this.ocena_combobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ocena_combobox.Location = new System.Drawing.Point(106, 37);
            this.ocena_combobox.Name = "ocena_combobox";
            this.ocena_combobox.Size = new System.Drawing.Size(219, 23);
            this.ocena_combobox.TabIndex = 0;
            // 
            // ocena_label
            // 
            this.ocena_label.AutoSize = true;
            this.ocena_label.Location = new System.Drawing.Point(4, 40);
            this.ocena_label.Name = "ocena_label";
            this.ocena_label.Size = new System.Drawing.Size(43, 15);
            this.ocena_label.TabIndex = 1;
            this.ocena_label.Text = "Ocena";
            // 
            // opis_ocene_txt
            // 
            this.opis_ocene_txt.Location = new System.Drawing.Point(106, 64);
            this.opis_ocene_txt.Name = "opis_ocene_txt";
            this.opis_ocene_txt.Size = new System.Drawing.Size(219, 21);
            this.opis_ocene_txt.TabIndex = 2;
            // 
            // opis_label
            // 
            this.opis_label.AutoSize = true;
            this.opis_label.Location = new System.Drawing.Point(4, 67);
            this.opis_label.Name = "opis_label";
            this.opis_label.Size = new System.Drawing.Size(32, 15);
            this.opis_label.TabIndex = 3;
            this.opis_label.Text = "Opis";
            // 
            // datum_dobijanja
            // 
            this.datum_dobijanja.AutoSize = true;
            this.datum_dobijanja.Location = new System.Drawing.Point(4, 96);
            this.datum_dobijanja.Name = "datum_dobijanja";
            this.datum_dobijanja.Size = new System.Drawing.Size(98, 15);
            this.datum_dobijanja.TabIndex = 4;
            this.datum_dobijanja.Text = "Datum dobijanja";
            // 
            // datum_dobijanja_box
            // 
            this.datum_dobijanja_box.Location = new System.Drawing.Point(106, 90);
            this.datum_dobijanja_box.Name = "datum_dobijanja_box";
            this.datum_dobijanja_box.Size = new System.Drawing.Size(219, 21);
            this.datum_dobijanja_box.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID učenika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Naziv predmeta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1_NazivPredmeta);
            this.groupBox1.Controls.Add(this.id_ucenika_txt);
            this.groupBox1.Controls.Add(this.id_ucenika_label);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ocena_combobox);
            this.groupBox1.Controls.Add(this.ocena_label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.opis_ocene_txt);
            this.groupBox1.Controls.Add(this.datum_dobijanja_box);
            this.groupBox1.Controls.Add(this.opis_label);
            this.groupBox1.Controls.Add(this.datum_dobijanja);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(693, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 208);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj ocenu učenika";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1_NazivPredmeta
            // 
            this.textBox1_NazivPredmeta.Location = new System.Drawing.Point(120, 178);
            this.textBox1_NazivPredmeta.Name = "textBox1_NazivPredmeta";
            this.textBox1_NazivPredmeta.Size = new System.Drawing.Size(112, 21);
            this.textBox1_NazivPredmeta.TabIndex = 10;
            // 
            // id_ucenika_txt
            // 
            this.id_ucenika_txt.Location = new System.Drawing.Point(120, 147);
            this.id_ucenika_txt.Name = "id_ucenika_txt";
            this.id_ucenika_txt.Size = new System.Drawing.Size(112, 21);
            this.id_ucenika_txt.TabIndex = 9;
            this.id_ucenika_txt.TextChanged += new System.EventHandler(this.id_ucenika_txt_TextChanged);
            // 
            // id_ucenika_label
            // 
            this.id_ucenika_label.AutoSize = true;
            this.id_ucenika_label.Location = new System.Drawing.Point(103, 167);
            this.id_ucenika_label.Name = "id_ucenika_label";
            this.id_ucenika_label.Size = new System.Drawing.Size(0, 15);
            this.id_ucenika_label.TabIndex = 8;
            // 
            // lista_ucenika_data_grid_view
            // 
            this.lista_ucenika_data_grid_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lista_ucenika_data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_ucenika_data_grid_view.Location = new System.Drawing.Point(12, 12);
            this.lista_ucenika_data_grid_view.Name = "lista_ucenika_data_grid_view";
            this.lista_ucenika_data_grid_view.Size = new System.Drawing.Size(675, 389);
            this.lista_ucenika_data_grid_view.TabIndex = 9;
            this.lista_ucenika_data_grid_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lista_ucenika_data_grid_view_CellContentClick);
            // 
            // button1_Obrisi
            // 
            this.button1_Obrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button1_Obrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1_Obrisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button1_Obrisi.Location = new System.Drawing.Point(587, 407);
            this.button1_Obrisi.Name = "button1_Obrisi";
            this.button1_Obrisi.Size = new System.Drawing.Size(100, 40);
            this.button1_Obrisi.TabIndex = 10;
            this.button1_Obrisi.Text = "Obriši";
            this.button1_Obrisi.UseVisualStyleBackColor = false;
            this.button1_Obrisi.Click += new System.EventHandler(this.button1_Obrisi_Click);
            // 
            // button1_Azuriraj
            // 
            this.button1_Azuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button1_Azuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1_Azuriraj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button1_Azuriraj.Location = new System.Drawing.Point(823, 226);
            this.button1_Azuriraj.Name = "button1_Azuriraj";
            this.button1_Azuriraj.Size = new System.Drawing.Size(100, 40);
            this.button1_Azuriraj.TabIndex = 11;
            this.button1_Azuriraj.Text = "Ažuriraj";
            this.button1_Azuriraj.UseVisualStyleBackColor = false;
            this.button1_Azuriraj.Click += new System.EventHandler(this.button1_Azuriraj_Click);
            // 
            // button2_Dodaj
            // 
            this.button2_Dodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button2_Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2_Dodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button2_Dodaj.Location = new System.Drawing.Point(929, 226);
            this.button2_Dodaj.Name = "button2_Dodaj";
            this.button2_Dodaj.Size = new System.Drawing.Size(100, 40);
            this.button2_Dodaj.TabIndex = 12;
            this.button2_Dodaj.Text = "Dodaj";
            this.button2_Dodaj.UseVisualStyleBackColor = false;
            this.button2_Dodaj.Click += new System.EventHandler(this.button2_Dodaj_Click);
            // 
            // button1_Nazad
            // 
            this.button1_Nazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button1_Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1_Nazad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button1_Nazad.Location = new System.Drawing.Point(12, 407);
            this.button1_Nazad.Name = "button1_Nazad";
            this.button1_Nazad.Size = new System.Drawing.Size(100, 40);
            this.button1_Nazad.TabIndex = 13;
            this.button1_Nazad.Text = "Nazad";
            this.button1_Nazad.UseVisualStyleBackColor = false;
            this.button1_Nazad.Click += new System.EventHandler(this.button1_Nazad_Click);
            // 
            // DodajOcenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1044, 457);
            this.Controls.Add(this.button1_Nazad);
            this.Controls.Add(this.button2_Dodaj);
            this.Controls.Add(this.button1_Azuriraj);
            this.Controls.Add(this.button1_Obrisi);
            this.Controls.Add(this.lista_ucenika_data_grid_view);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajOcenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj ocenu";
            this.Load += new System.EventHandler(this.DodajOcenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_ucenika_data_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ocena_combobox;
        private System.Windows.Forms.Label ocena_label;
        private System.Windows.Forms.TextBox opis_ocene_txt;
        private System.Windows.Forms.Label opis_label;
        private System.Windows.Forms.Label datum_dobijanja;
        private System.Windows.Forms.DateTimePicker datum_dobijanja_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView lista_ucenika_data_grid_view;
        private System.Windows.Forms.Label id_ucenika_label;
        private System.Windows.Forms.TextBox id_ucenika_txt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1_NazivPredmeta;
        private System.Windows.Forms.Button button1_Obrisi;
        private System.Windows.Forms.Button button1_Azuriraj;
        private System.Windows.Forms.Button button2_Dodaj;
        private System.Windows.Forms.Button button1_Nazad;
    }
}