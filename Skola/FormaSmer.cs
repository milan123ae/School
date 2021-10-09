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
    public partial class FormaSmer : Form
    {
        public FormaSmer()
        {
            this.MaximizeBox = false;
            InitializeComponent();
            ISession s = DataLayer.GetSession();
            IList<Smer> lista = s.QueryOver<Smer>().List<Smer>();
            IList<UciNa> listaa = s.QueryOver<UciNa>().List<UciNa>();
            dataGridView1Smer.DataSource = lista.Select(t => new SmerModel(t)).ToList();
            dataGridView1_UciNa.DataSource = listaa.Select(t => new UciNaModel(t)).ToList();
            s.Close();
        }
        public class SmerModel
        {
            public Int32 Id { get; set; }
            public String NazivSmera { get; set; }
            public Int32 BrojUcenika { get; set; }

            public SmerModel(Smer s)
            {
                Id = s.IdSmera;
                NazivSmera = s.NazivSmera;
                BrojUcenika = s.BrojUcenika;
            }
        }
        public class UciNaModel
        {
            public Int32 Id { get; set; }
            public String NazivSmera { get; set; }
            public String NazivPredmeta { get; set; }

            public UciNaModel(UciNa u)
            {
                Id = u.UciNaId;
                NazivSmera = u.UceNa.NazivSmera;
                NazivPredmeta = u.Uci.NazivPredmeta;
            }
        }

        private void button1_Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 forma1 = new Form1();
            forma1.Show();
        }

        private void button1_ObrisiSmer_Click(object sender, EventArgs e)
        {
            if (dataGridView1Smer.SelectedRows.Count == 1)
            {
                ISession s = DataLayer.GetSession();

                Int32 id = (Int32)dataGridView1Smer.SelectedRows[0].Cells[0].Value;

                Smer o = s.Load<Smer>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
                this.Hide();
                FormaSmer forma_smer = new FormaSmer();
                forma_smer.Show();
            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }

        private void button6_ObrisiUciNa_Click(object sender, EventArgs e)
        {
            if (dataGridView1_UciNa.SelectedRows.Count == 1)
            {
                ISession s = DataLayer.GetSession();

                Int32 id = (Int32)dataGridView1_UciNa.SelectedRows[0].Cells[0].Value;

                UciNa o = s.Load<UciNa>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
                this.Hide();
                FormaSmer forma_smer = new FormaSmer();
                forma_smer.Show();
            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }

        private void button2_DodajSmer_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                Smer o1 = new Smer()
                {
                    NazivSmera = texNazivSmer.Text.ToString(),
                    BrojUcenika = Int32.Parse(textBrojUcen.Text)
                };

                s.Save(o1);
                s.Flush();
                s.Close();
                this.Hide();
                FormaSmer forma_Smer = new FormaSmer();
                forma_Smer.Show();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Doslo je do greske u dodavanju");
                this.Hide();
                FormaSmer forma_Smer = new FormaSmer();
                forma_Smer.Show();
              //  MessageBox.Show(ec.Message);
            }
        }

        private void button4_DodajUciNa_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                String z = texPredUci.Text.ToString();
                IQuery q = s.CreateQuery("from Predmet");
                IEnumerable<Predmet> predmeti = q.Enumerable<Predmet>();
                Int32 k = 0;

                String w = textSmerUci.Text.ToString();
                IQuery i = s.CreateQuery("from Smer");
                IEnumerable<Smer> smerovi = i.Enumerable<Smer>();
                Int32 r = 0;

                foreach (Smer j in smerovi)
                {
                    if (j.NazivSmera == w)
                    {
                        r = j.IdSmera;
                    }
                }
                foreach (Predmet h in predmeti)
                {
                    if (h.NazivPredmeta == z)
                    {
                        k = h.Id_Predmeta;
                    }
                }


                if ((k == 0) || (r == 0))
                {
                    MessageBox.Show("Predmet ili Smer ne postoji u bazi!");
                    this.Hide();
                    FormaSmer forma_Smer = new FormaSmer();
                    forma_Smer.Show();
                }
                else
                {

                    Entiteti.Predmet g = s.Load<Entiteti.Predmet>(k);
                    Entiteti.Smer x = s.Load<Entiteti.Smer>(r);
                    UciNa o1 = new UciNa()
                    {
                        Uci = g,
                        UceNa = x
                    };

                    s.Save(o1);
                    s.Flush();
                    s.Close();
                    this.Hide();
                    FormaSmer forma_Smer = new FormaSmer();
                    forma_Smer.Show();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Doslo je do greske u dodavanju");
                this.Hide();
                FormaSmer forma_Smer = new FormaSmer();
                forma_Smer.Show();
           //     MessageBox.Show(ec.Message);

            }
        }

        private void button3_AzurirajSmer_Click(object sender, EventArgs e)
        {
            if (dataGridView1Smer.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1Smer.SelectedRows[0].Cells[0].Value;
                try
                {
                    ISession s = DataLayer.GetSession();

                    Smer o = s.Load<Smer>(id);
                    String z = texNazivSmer.Text.ToString();
                    IQuery q = s.CreateQuery("from Smer");
                    IEnumerable<Smer> smerovi = q.Enumerable<Smer>();
                    foreach (Smer h in smerovi)
                    {
                        if (h.NazivSmera == z)
                        {
                            o.IdSmera = h.IdSmera;
                        }
                    }
                    o.NazivSmera = texNazivSmer.Text.ToString();
                    o.BrojUcenika = Int32.Parse(textBrojUcen.Text);
                    //originalna sesija se zatvara i raskida se veza izmedju objekta i sesije
                    s.Close();

                    //objekat se modifikuje potpuno nezavisno od sesije
                    // o.Prezime = "Mikic";

                    //otvara se nova sesija
                    ISession s1 = DataLayer.GetSession();

                    //poziva se Update i objekat se povezuje sa novom sesijom
                    s1.Update(o);

                    s1.Flush();
                    s1.Close();
                    this.Hide();
                    FormaSmer forma_smer = new FormaSmer();
                    forma_smer.Show();

                }
                catch (Exception ec)
                {
                    MessageBox.Show("Doslo je do greske!");
                    this.Hide();
                    FormaSmer forma_smer = new FormaSmer();
                    forma_smer.Show();
                 //   MessageBox.Show(ec.Message);

                }

            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }

        private void Azuriraj_UciNa_Click(object sender, EventArgs e)
        {
            if (dataGridView1_UciNa.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1_UciNa.SelectedRows[0].Cells[0].Value;
                try
                {
                    ISession s = DataLayer.GetSession();

                    UciNa o = s.Load<UciNa>(id);
                    String z = textSmerUci.Text.ToString();
                    IQuery q = s.CreateQuery("from Smer");
                    IEnumerable<Smer> smerovi = q.Enumerable<Smer>();
                    foreach (Smer h in smerovi)
                    {
                        if (h.NazivSmera == z)
                        {
                            o.UceNa.IdSmera = h.IdSmera;
                        }
                    }
                    String w = texPredUci.Text.ToString();
                    IQuery a = s.CreateQuery("from Predmet");
                    IEnumerable<Predmet> predmeti = a.Enumerable<Predmet>();
                    foreach (Predmet j in predmeti)
                    {
                        if (j.NazivPredmeta == w)
                        {
                            o.Uci.Id_Predmeta = j.Id_Predmeta;
                        }
                    }
                    o.Uci.NazivPredmeta = texPredUci.Text.ToString();
                    o.UceNa.NazivSmera = textSmerUci.Text.ToString();
                    //originalna sesija se zatvara i raskida se veza izmedju objekta i sesije
                    s.Close();

                    //objekat se modifikuje potpuno nezavisno od sesije
                    // o.Prezime = "Mikic";

                    //otvara se nova sesija
                    ISession s1 = DataLayer.GetSession();

                    //poziva se Update i objekat se povezuje sa novom sesijom
                    s1.Update(o);

                    s1.Flush();
                    s1.Close();
                    this.Hide();
                    FormaSmer forma_smer = new FormaSmer();
                    forma_smer.Show();

                }
                catch (Exception ec)
                {
                    MessageBox.Show("Doslo je do greske!");
                    this.Hide();
                    FormaSmer forma_smer = new FormaSmer();
                    forma_smer.Show();
                  //  MessageBox.Show(ec.Message);

                }

            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }
    }
}
