namespace Skola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button23 = new System.Windows.Forms.Button();
            this.button24_Roditelji = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button24_OCENA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dodaj_zaposlenog_btn = new System.Windows.Forms.Button();
            this.dodaj_ucenka_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button14_Zaposlen = new System.Windows.Forms.Button();
            this.button24_Ucenik = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button23.Image = ((System.Drawing.Image)(resources.GetObject("button23.Image")));
            this.button23.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button23.Location = new System.Drawing.Point(6, 171);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(130, 70);
            this.button23.TabIndex = 32;
            this.button23.Text = "Smerovi";
            this.button23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24_Roditelji
            // 
            this.button24_Roditelji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button24_Roditelji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button24_Roditelji.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button24_Roditelji.Image = ((System.Drawing.Image)(resources.GetObject("button24_Roditelji.Image")));
            this.button24_Roditelji.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button24_Roditelji.Location = new System.Drawing.Point(142, 171);
            this.button24_Roditelji.Name = "button24_Roditelji";
            this.button24_Roditelji.Size = new System.Drawing.Size(130, 70);
            this.button24_Roditelji.TabIndex = 34;
            this.button24_Roditelji.Text = "Roditelji";
            this.button24_Roditelji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button24_Roditelji.UseVisualStyleBackColor = false;
            this.button24_Roditelji.Click += new System.EventHandler(this.button24_Roditelji_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button14.Location = new System.Drawing.Point(6, 95);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(130, 70);
            this.button14.TabIndex = 31;
            this.button14.Text = "Predmeti";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button24_OCENA
            // 
            this.button24_OCENA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button24_OCENA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button24_OCENA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button24_OCENA.Image = ((System.Drawing.Image)(resources.GetObject("button24_OCENA.Image")));
            this.button24_OCENA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button24_OCENA.Location = new System.Drawing.Point(142, 94);
            this.button24_OCENA.Name = "button24_OCENA";
            this.button24_OCENA.Size = new System.Drawing.Size(130, 70);
            this.button24_OCENA.TabIndex = 35;
            this.button24_OCENA.Text = "Ocene";
            this.button24_OCENA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button24_OCENA.UseVisualStyleBackColor = false;
            this.button24_OCENA.Click += new System.EventHandler(this.button24_OCENA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.groupBox1.Controls.Add(this.dodaj_zaposlenog_btn);
            this.groupBox1.Controls.Add(this.dodaj_ucenka_btn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(316, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 108);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brzi linkovi";
            // 
            // dodaj_zaposlenog_btn
            // 
            this.dodaj_zaposlenog_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.dodaj_zaposlenog_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodaj_zaposlenog_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.dodaj_zaposlenog_btn.Location = new System.Drawing.Point(6, 61);
            this.dodaj_zaposlenog_btn.Name = "dodaj_zaposlenog_btn";
            this.dodaj_zaposlenog_btn.Size = new System.Drawing.Size(188, 36);
            this.dodaj_zaposlenog_btn.TabIndex = 1;
            this.dodaj_zaposlenog_btn.Text = "Dodaj zaposlenog";
            this.dodaj_zaposlenog_btn.UseVisualStyleBackColor = false;
            this.dodaj_zaposlenog_btn.Click += new System.EventHandler(this.dodaj_zaposlenog_btn_Click);
            // 
            // dodaj_ucenka_btn
            // 
            this.dodaj_ucenka_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dodaj_ucenka_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dodaj_ucenka_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.dodaj_ucenka_btn.Location = new System.Drawing.Point(6, 19);
            this.dodaj_ucenka_btn.Name = "dodaj_ucenka_btn";
            this.dodaj_ucenka_btn.Size = new System.Drawing.Size(188, 36);
            this.dodaj_ucenka_btn.TabIndex = 0;
            this.dodaj_ucenka_btn.Text = "Dodaj učenika";
            this.dodaj_ucenka_btn.UseVisualStyleBackColor = false;
            this.dodaj_ucenka_btn.Click += new System.EventHandler(this.dodaj_ucenka_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.groupBox2.Controls.Add(this.button14_Zaposlen);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.button24_OCENA);
            this.groupBox2.Controls.Add(this.button14);
            this.groupBox2.Controls.Add(this.button24_Roditelji);
            this.groupBox2.Controls.Add(this.button24_Ucenik);
            this.groupBox2.Controls.Add(this.button23);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 287);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // button14_Zaposlen
            // 
            this.button14_Zaposlen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button14_Zaposlen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14_Zaposlen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button14_Zaposlen.Image = ((System.Drawing.Image)(resources.GetObject("button14_Zaposlen.Image")));
            this.button14_Zaposlen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button14_Zaposlen.Location = new System.Drawing.Point(6, 19);
            this.button14_Zaposlen.Name = "button14_Zaposlen";
            this.button14_Zaposlen.Size = new System.Drawing.Size(130, 70);
            this.button14_Zaposlen.TabIndex = 30;
            this.button14_Zaposlen.Text = "Zaposleni";
            this.button14_Zaposlen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14_Zaposlen.UseVisualStyleBackColor = false;
            this.button14_Zaposlen.Click += new System.EventHandler(this.button14_Zaposlen_Click);
            // 
            // button24_Ucenik
            // 
            this.button24_Ucenik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button24_Ucenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24_Ucenik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button24_Ucenik.Image = ((System.Drawing.Image)(resources.GetObject("button24_Ucenik.Image")));
            this.button24_Ucenik.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button24_Ucenik.Location = new System.Drawing.Point(142, 18);
            this.button24_Ucenik.Name = "button24_Ucenik";
            this.button24_Ucenik.Size = new System.Drawing.Size(130, 70);
            this.button24_Ucenik.TabIndex = 33;
            this.button24_Ucenik.Text = "Učenici";
            this.button24_Ucenik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button24_Ucenik.UseVisualStyleBackColor = false;
            this.button24_Ucenik.Click += new System.EventHandler(this.button24_Ucenik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(546, 311);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Škola";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24_Ucenik;
        private System.Windows.Forms.Button button24_Roditelji;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button24_OCENA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dodaj_zaposlenog_btn;
        private System.Windows.Forms.Button dodaj_ucenka_btn;
        private System.Windows.Forms.Button button14_Zaposlen;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

