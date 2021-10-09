namespace Skola
{
    partial class FormaPredmet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPredmet));
            this.textBox1_NazivPredmeta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1_Azuriraj = new System.Windows.Forms.Button();
            this.textBox2_NAzivPredmetaGodine = new System.Windows.Forms.TextBox();
            this.textBox1_Godine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1_DodajGodine = new System.Windows.Forms.Button();
            this.button2_ObrisiGodine = new System.Windows.Forms.Button();
            this.dataGridView1_Godine = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1_Predmet = new System.Windows.Forms.DataGridView();
            this.button2_DODAj = new System.Windows.Forms.Button();
            this.button1_Brisi = new System.Windows.Forms.Button();
            this.button1_Nazad = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Godine)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Predmet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1_NazivPredmeta
            // 
            this.textBox1_NazivPredmeta.Location = new System.Drawing.Point(116, 267);
            this.textBox1_NazivPredmeta.Name = "textBox1_NazivPredmeta";
            this.textBox1_NazivPredmeta.Size = new System.Drawing.Size(154, 22);
            this.textBox1_NazivPredmeta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv predmeta\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 405);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Predmet";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1_Azuriraj);
            this.groupBox3.Controls.Add(this.textBox2_NAzivPredmetaGodine);
            this.groupBox3.Controls.Add(this.textBox1_Godine);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button1_DodajGodine);
            this.groupBox3.Controls.Add(this.button2_ObrisiGodine);
            this.groupBox3.Controls.Add(this.dataGridView1_Godine);
            this.groupBox3.Location = new System.Drawing.Point(290, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 378);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Godine";
            // 
            // button1_Azuriraj
            // 
            this.button1_Azuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button1_Azuriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Azuriraj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button1_Azuriraj.Location = new System.Drawing.Point(265, 332);
            this.button1_Azuriraj.Name = "button1_Azuriraj";
            this.button1_Azuriraj.Size = new System.Drawing.Size(100, 40);
            this.button1_Azuriraj.TabIndex = 17;
            this.button1_Azuriraj.Text = "Ažuriraj";
            this.button1_Azuriraj.UseVisualStyleBackColor = false;
            this.button1_Azuriraj.Click += new System.EventHandler(this.button1_Azuriraj_Click);
            // 
            // textBox2_NAzivPredmetaGodine
            // 
            this.textBox2_NAzivPredmetaGodine.Location = new System.Drawing.Point(158, 267);
            this.textBox2_NAzivPredmetaGodine.Name = "textBox2_NAzivPredmetaGodine";
            this.textBox2_NAzivPredmetaGodine.Size = new System.Drawing.Size(207, 22);
            this.textBox2_NAzivPredmetaGodine.TabIndex = 16;
            // 
            // textBox1_Godine
            // 
            this.textBox1_Godine.Location = new System.Drawing.Point(159, 301);
            this.textBox1_Godine.Name = "textBox1_Godine";
            this.textBox1_Godine.Size = new System.Drawing.Size(206, 22);
            this.textBox1_Godine.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Naziv Predmeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Godina";
            // 
            // button1_DodajGodine
            // 
            this.button1_DodajGodine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button1_DodajGodine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_DodajGodine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button1_DodajGodine.Location = new System.Drawing.Point(159, 332);
            this.button1_DodajGodine.Name = "button1_DodajGodine";
            this.button1_DodajGodine.Size = new System.Drawing.Size(100, 40);
            this.button1_DodajGodine.TabIndex = 11;
            this.button1_DodajGodine.Text = "Dodaj";
            this.button1_DodajGodine.UseVisualStyleBackColor = false;
            this.button1_DodajGodine.Click += new System.EventHandler(this.button1_DodajGodine_Click);
            // 
            // button2_ObrisiGodine
            // 
            this.button2_ObrisiGodine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button2_ObrisiGodine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_ObrisiGodine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button2_ObrisiGodine.Location = new System.Drawing.Point(265, 202);
            this.button2_ObrisiGodine.Name = "button2_ObrisiGodine";
            this.button2_ObrisiGodine.Size = new System.Drawing.Size(100, 40);
            this.button2_ObrisiGodine.TabIndex = 12;
            this.button2_ObrisiGodine.Text = "Obriši";
            this.button2_ObrisiGodine.UseVisualStyleBackColor = false;
            this.button2_ObrisiGodine.Click += new System.EventHandler(this.button2_ObrisiGodine_Click);
            // 
            // dataGridView1_Godine
            // 
            this.dataGridView1_Godine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dataGridView1_Godine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Godine.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1_Godine.Name = "dataGridView1_Godine";
            this.dataGridView1_Godine.Size = new System.Drawing.Size(359, 175);
            this.dataGridView1_Godine.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1_Predmet);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1_NazivPredmeta);
            this.groupBox2.Controls.Add(this.button2_DODAj);
            this.groupBox2.Controls.Add(this.button1_Brisi);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 378);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Predmeti";
            // 
            // dataGridView1_Predmet
            // 
            this.dataGridView1_Predmet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dataGridView1_Predmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Predmet.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1_Predmet.Name = "dataGridView1_Predmet";
            this.dataGridView1_Predmet.Size = new System.Drawing.Size(264, 175);
            this.dataGridView1_Predmet.TabIndex = 7;
            // 
            // button2_DODAj
            // 
            this.button2_DODAj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button2_DODAj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_DODAj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button2_DODAj.Location = new System.Drawing.Point(170, 332);
            this.button2_DODAj.Name = "button2_DODAj";
            this.button2_DODAj.Size = new System.Drawing.Size(100, 40);
            this.button2_DODAj.TabIndex = 5;
            this.button2_DODAj.Text = "Dodaj";
            this.button2_DODAj.UseVisualStyleBackColor = false;
            this.button2_DODAj.Click += new System.EventHandler(this.button2_DODAj_Click);
            // 
            // button1_Brisi
            // 
            this.button1_Brisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button1_Brisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_Brisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button1_Brisi.Location = new System.Drawing.Point(170, 202);
            this.button1_Brisi.Name = "button1_Brisi";
            this.button1_Brisi.Size = new System.Drawing.Size(100, 40);
            this.button1_Brisi.TabIndex = 6;
            this.button1_Brisi.Text = "Obriši";
            this.button1_Brisi.UseVisualStyleBackColor = false;
            this.button1_Brisi.Click += new System.EventHandler(this.button1_Brisi_Click);
            // 
            // button1_Nazad
            // 
            this.button1_Nazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button1_Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1_Nazad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button1_Nazad.Location = new System.Drawing.Point(12, 15);
            this.button1_Nazad.Name = "button1_Nazad";
            this.button1_Nazad.Size = new System.Drawing.Size(100, 40);
            this.button1_Nazad.TabIndex = 8;
            this.button1_Nazad.Text = "Nazad";
            this.button1_Nazad.UseVisualStyleBackColor = false;
            this.button1_Nazad.Click += new System.EventHandler(this.button1_Nazad_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.groupBox4.Controls.Add(this.button1_Nazad);
            this.groupBox4.Location = new System.Drawing.Point(12, 423);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(667, 66);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // FormaPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(692, 499);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaPredmet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Predmet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Godine)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Predmet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_NazivPredmeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2_DODAj;
        private System.Windows.Forms.Button button1_Brisi;
        private System.Windows.Forms.DataGridView dataGridView1_Predmet;
        private System.Windows.Forms.Button button1_Nazad;
        private System.Windows.Forms.DataGridView dataGridView1_Godine;
        private System.Windows.Forms.Button button2_ObrisiGodine;
        private System.Windows.Forms.Button button1_DodajGodine;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2_NAzivPredmetaGodine;
        private System.Windows.Forms.TextBox textBox1_Godine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1_Azuriraj;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}