using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skola.Entiteti;

namespace Skola
{
    public partial class DodajZaposlenog : Form
    {
        public DodajZaposlenog()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 forma1 = new Form1();
            forma1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
          
  
                if (radioButton1_Nastavno.Checked)
                {
                    try
                    {
                        ISession s = DataLayer.GetSession();
                        Skola.Entiteti.NastavnoOsoblje p = new Entiteti.NastavnoOsoblje();
                        p.Jmbg = Int32.Parse(textBox1_JMBG.Text);
                        p.Lime = textBox2_Ime.Text.ToString();
                        p.ImeRoditelja = textBox3_ImeRoditelja.Text.ToString();
                        p.Prezime = textBox4_prezime.Text.ToString();
                        p.Ulica = textBox5_Ulica.Text.ToString();
                        p.Broj = Int32.Parse(textBox6_Broj.Text);
                        p.DatumRodjenja = Convert.ToDateTime(dateTimePicker1_DatumRodjenja.Text);
                        if (radioButton1_PunaNorma.Checked)
                        {
                            p.TipNorme = "Puna";
                            p.NazivSkole = "null";
                            p.BrojCasovaNedeljno = 0;
                        }
                        else
                        {
                            p.TipNorme = "Neophodna";
                            p.NazivSkole = textBox2_NazivSkole.Text.ToString();
                            p.BrojCasovaNedeljno = Int32.Parse(textBox1_BrojCasovaNedeljno.Text);
                        }
                        s.Save(p);
                        s.Flush();
                        s.Close();
                        MessageBox.Show("Uspesno dodavanje");
                        this.Hide();
                        DodajZaposlenog forma_dodaj_zaposlenog = new DodajZaposlenog();
                        forma_dodaj_zaposlenog.Show();
                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show("Neuspesno dodavanje!");
                        this.Hide();
                        DodajZaposlenog forma_dodaj_zaposlenog = new DodajZaposlenog();
                        forma_dodaj_zaposlenog.Show();
                       // MessageBox.Show(ec.InnerException.Message);

                    }
                    
                }
                else 
                {
                     try
                        {
            
                             ISession s = DataLayer.GetSession();
                             Skola.Entiteti.NenastavnoOsoblje p = new Entiteti.NenastavnoOsoblje();
                             p.Jmbg = Int32.Parse(textBox1_JMBG.Text);
                             p.Lime = textBox2_Ime.Text.ToString();
                             p.ImeRoditelja = textBox3_ImeRoditelja.Text.ToString();
                             p.Prezime = textBox4_prezime.Text.ToString();
                             p.Ulica = textBox5_Ulica.Text.ToString();
                             p.Broj = Int32.Parse(textBox6_Broj.Text);
                             p.DatumRodjenja = Convert.ToDateTime(dateTimePicker1_DatumRodjenja.Text);
                             p.StrucnaSprema = textBox2_Strucna_sprema.Text.ToString();
                             p.NazivSektora = textBox1_NazivSektora.Text.ToString();
                             
                             s.Save(p);
                             s.Flush();
                             s.Close();
                             MessageBox.Show("Uspesno dodavanje");
                             this.Hide();
                             DodajZaposlenog forma_dodaj_zaposlenog = new DodajZaposlenog();
                             forma_dodaj_zaposlenog.Show();
                         }
                         catch (Exception ec)
                             {
                                 MessageBox.Show("Neuspesno dodavanje");
                                 this.Hide();
                                 DodajZaposlenog forma_dodaj_zaposlenog = new DodajZaposlenog();
                                 forma_dodaj_zaposlenog.Show();
                               //  MessageBox.Show(ec.InnerException.Message);
                             }
            }

        }

        private void radioButton1_Nastavno_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1_Nastavno.Checked)
            {
                groupBox2_Nastavno.Visible = true;
                groupBox3_Nenastavno.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox2_Nastavno.Visible = false;
                groupBox3_Nenastavno.Visible = true;
            }
        }

        private void radioButton1_PunaNorma_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1_PunaNorma.Checked)
            {
                textBox2_NazivSkole.Visible = false;
                textBox1_BrojCasovaNedeljno.Visible = false;
            }
        }

        private void radioButton3_Neophodna_Norma_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3_Neophodna_Norma.Checked)
            {
                textBox2_NazivSkole.Visible = true;
                textBox1_BrojCasovaNedeljno.Visible = true;
            }
        }
 
    }
}
