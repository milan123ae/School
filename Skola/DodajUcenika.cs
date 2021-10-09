using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Skola.Entiteti;

namespace Skola
{
    public partial class DodajUcenika : Form
    {

        public DodajUcenika()
        {
            this.MaximizeBox = false;
            InitializeComponent();
            razred_combobox.SelectedIndex = 0;
        }

       private void DodajUcenika_Load(object sender, EventArgs e)
        {

        }

        private void ime_ucenika_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void prezime_ucenika_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void razred_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ulica_ucenika_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void broj_ulice_ucenika_txt_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void datum_upisa_ucenika_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dodaj_ucenika_btn_Click(object sender, EventArgs e)
        {
            String Ime1 = this.ime_ucenika_txt.Text.ToString();
            String Prezime1 = this.prezime_ucenika_txt.Text.ToString();
            String Ulica1 = this.ulica_ucenika_txt.Text.ToString();
            Int32 Razred1 = Int32.Parse(this.razred_combobox.Text);
            Int32 Broj1 = Int32.Parse(this.broj_ulice_ucenika_txt.Text);
            DateTime aa = Convert.ToDateTime(this.datum_upisa_ucenika.Text);
            try
            {
                ISession s = DataLayer.GetSession();
                String z = smerID.Text.ToString();
                Int32 k = 0;
                IQuery q = s.CreateQuery("from Smer");
                IEnumerable<Smer> smerovi = q.Enumerable<Smer>();
                foreach (Smer h in smerovi)
                {
                    if (h.NazivSmera == z)
                    {
                        k = h.IdSmera;
                    }
                }
                if (k == 0)
                {
                    MessageBox.Show("Smer ne postoji u bazi!");
                    this.Hide();
                    DodajUcenika forma_dodaj_ucenika = new DodajUcenika();
                    forma_dodaj_ucenika.Show();
                }
                else
                {
                    Entiteti.Smer p = s.Load<Entiteti.Smer>(k);

                    Ucenik o1 = new Ucenik()
                    {

                        Ime = Convert.ToString(Ime1),
                        Prezime = Convert.ToString(Prezime1),
                        Razred = Convert.ToInt32(Razred1),
                        Ulica = Convert.ToString(Ulica1),
                        Broj = Convert.ToInt32(Broj1),
                        DatumUpisa = Convert.ToDateTime(aa),
                        UpisaoSmer = p
                    };
                    s.Save(o1);
                    s.Flush();
                    s.Close();
                    MessageBox.Show("Uspesno dodavanje");

                    this.Hide();
                    DodajUcenika forma_dodaj_ucenika = new DodajUcenika();
                    forma_dodaj_ucenika.Show();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje!");
                this.Hide();
                DodajUcenika forma_dodaj_ucenika = new DodajUcenika();
                forma_dodaj_ucenika.Show();
               // MessageBox.Show(ec.InnerException.Message);
            }
        }

        private void nazad_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 forma1 = new Form1();
            forma1.Show();
        }


    }
}
