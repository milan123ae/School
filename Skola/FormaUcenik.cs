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
using FluentNHibernate;
using NHibernate;


namespace Skola
{
    public partial class FormaUcenik : Form
    {
        public FormaUcenik()
        {
            this.MaximizeBox = false;
            InitializeComponent();
            ISession s = DataLayer.GetSession();
            IList<Ucenik> lista = s.QueryOver<Ucenik>().List<Ucenik>();
            dataGridView1_Ucenik.DataSource = lista.Select(t => new UcenikModel(t)).ToList();
        }
        public class UcenikModel
        {
            public Int32 Id { get; set; }
            public String Ime { get; set; }
            public String Prezime { get; set; }
            public Int32 Razred { get; set; }
            public String Ulica { get; set; }
            public Int32 Broj{get; set;}
            public String UpisaoSmer{get;set;}
            public String Datum{get;set;}

            public UcenikModel(Ucenik u)
            {
                Id = u.IdUcenika;
                Ime = u.Ime;
                Prezime = u.Prezime;
                Razred = u.Razred;
                Ulica = u.Ulica;
                Broj = u.Broj;
                UpisaoSmer = u.UpisaoSmer.NazivSmera;
                Datum = u.DatumUpisa.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajUcenika forma_dodaj_ucenika = new DodajUcenika();
            forma_dodaj_ucenika.Show();
        }

        private void button2_Ucitaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Int32 k = Int32.Parse(textBox1_IDUcenika.Text);
                Skola.Entiteti.Ucenik p = s.Load<Skola.Entiteti.Ucenik>(k);
                textBox1_Ime.Text = p.Ime.ToString();
                textBox2_Prezime.Text = p.Prezime.ToString();
                textBox4_Razred.Text = p.Razred.ToString();
                textBox3_Ulica.Text = p.Ulica.ToString();
                textBox5_Broj.Text = p.Broj.ToString();
                textBox1_UpisaoSmer.Text = p.UpisaoSmer.NazivSmera.ToString();
                dateTimePicker1.Text = p.DatumUpisa.ToString();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Pogresno ucitavanje");
                this.Hide();
                FormaUcenik forma_ucenik = new FormaUcenik();
                forma_ucenik.Show();
            //    MessageBox.Show(ec.InnerException.Message);

            }
        }

        private void button2_Azuriraj_Click(object sender, EventArgs e)
        {
            Int32 m = Int32.Parse(textBox1_IDUcenika.Text);
            try
            {
                ISession s = DataLayer.GetSession();

                Ucenik o = s.Load<Ucenik>(m);

                //originalna sesija se zatvara i raskida se veza izmedju objekta i sesije

                //objekat se modifikuje potpuno nezavisno od sesije
                o.Ime = textBox1_Ime.Text.ToString();
                o.Prezime = textBox2_Prezime.Text.ToString();
                o.Razred = Int32.Parse(textBox4_Razred.Text);
                o.Ulica = textBox3_Ulica.Text.ToString();
                o.Broj = Int32.Parse(textBox5_Broj.Text);
                o.DatumUpisa = Convert.ToDateTime(dateTimePicker1.Text);
                String z = textBox1_UpisaoSmer.Text.ToString();
                IQuery q = s.CreateQuery("from Smer");
                IEnumerable<Smer> smerovi = q.Enumerable<Smer>();
                Int32 r = 0;
                foreach (Smer h in smerovi)
                {
                    if (h.NazivSmera == z)
                    {
                        r = h.IdSmera;
                    }
                }
                if (r == 0)
                {
                    MessageBox.Show("Smer ne postoji u bazi!");
                    this.Hide();
                    FormaUcenik forma_ucenik = new FormaUcenik();
                    forma_ucenik.Show();

                }
                else
                {
                    o.UpisaoSmer.IdSmera= r;
                    s.Close();
                    //otvara se nova sesija
                    ISession s1 = DataLayer.GetSession();

                    //poziva se Update i objekat se povezuje sa novom sesijom
                    s1.Update(o);

                    s1.Flush();
                    s1.Close();
                    MessageBox.Show("Uspesno azuriranje");
                    this.Hide();
                    FormaUcenik forma_ucenik = new FormaUcenik();
                    forma_ucenik.Show();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Pogresno unosenje");
                this.Hide();
                FormaUcenik forma_ucenik = new FormaUcenik();
                forma_ucenik.Show();
            //    MessageBox.Show(ec.InnerException.Message);

            }
        }

        private void button3_Obrisi_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 l = Int32.Parse(textBox1_IDUcenika.Text);
                ISession s = DataLayer.GetSession();
                Ucenik o = s.Load<Ucenik>(l);

                //brise se objekat iz baze ali ne i instanca objekta u memroiji
                s.Delete(o);
                //s.Delete("from Odeljenje");
                s.Flush();
                s.Close();
                this.Hide();
                FormaUcenik forma_ucenik = new FormaUcenik();
                forma_ucenik.Show();

            }
            catch (Exception ec)
            {
                MessageBox.Show("ID Ucenika ne postoji!");
                this.Hide();
                FormaUcenik forma_ucenik = new FormaUcenik();
                forma_ucenik.Show();
             //   MessageBox.Show(ec.InnerException.Message);

            }
        }

        private void button2_Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 forma1 = new Form1();
            forma1.Show();
        }
    }
}
