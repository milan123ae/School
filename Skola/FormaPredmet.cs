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
using FluentNHibernate;

namespace Skola
{
    public partial class FormaPredmet : Form
    {
        public FormaPredmet()
        {
            this.MaximizeBox = false;
            InitializeComponent();
            ISession s = DataLayer.GetSession();
            IList<Predmet> lista = s.QueryOver<Predmet>().List<Predmet>();
            IList<Godine> listaa = s.QueryOver<Godine>().List<Godine>();
            dataGridView1_Godine.DataSource = listaa.Select(t => new GodineModel(t)).ToList();
            dataGridView1_Predmet.DataSource = lista.Select(t => new PredmetModel(t)).ToList();
            s.Close();
        }
        public class GodineModel
        {
            public Int32 Id { get; set; }
            public String NazivPredmeta { get; set; }
            public String Godina { get; set; }

            public GodineModel(Godine g)
            {
                Id = g.IdGodine;
                NazivPredmeta = g.Predmeti1.NazivPredmeta;
                Godina = g.Godina;
            }
        }
        public class PredmetModel
        {
            public Int32 Id { get; set; }
            public String NazivPredmeta { get; set; }

            public PredmetModel(Predmet p)
            {
                Id = p.Id_Predmeta;
                NazivPredmeta = p.NazivPredmeta;
            }
        }

        private void button2_DODAj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Predmet o1 = new Predmet()
                {
                    NazivPredmeta = textBox1_NazivPredmeta.Text.ToString()
                };

                s.Save(o1);
                s.Flush();
                s.Close();
                this.Hide();
                FormaPredmet forma_predmet = new FormaPredmet();
                forma_predmet.Show();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Doslo je do greske u dodavanju");
                this.Hide();
                FormaPredmet forma_predmet = new FormaPredmet();
                forma_predmet.Show();
               // MessageBox.Show(ec.Message);

            }
      
        }

        private void button1_Brisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1_Predmet.SelectedRows.Count == 1)
            {

                Int32 id = (Int32)dataGridView1_Predmet.SelectedRows[0].Cells[0].Value;

                ISession s2 = DataLayer.GetSession();
                Predmet p = s2.Load<Predmet>(id);
                s2.Delete(p);
                s2.Flush();
                s2.Close();
                this.Hide();
                FormaPredmet forma_predmet = new FormaPredmet();
                forma_predmet.Show();
            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }

        private void button1_Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 forma1 = new Form1();
            forma1.Show();
        }

        private void button2_ObrisiGodine_Click(object sender, EventArgs e)
        {
            if (dataGridView1_Godine.SelectedRows.Count == 1)
            {
                ISession s = DataLayer.GetSession();

                Int32 id = (Int32)dataGridView1_Godine.SelectedRows[0].Cells[0].Value;

                Godine o = s.Load<Godine>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
                this.Hide();
                FormaPredmet forma_predmet = new FormaPredmet();
                forma_predmet.Show();
            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }

        private void button1_DodajGodine_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                String z = textBox2_NAzivPredmetaGodine.Text.ToString();
                Int32 k = 0;
                IQuery q = s.CreateQuery("from Predmet");
                IEnumerable<Predmet> predmeti = q.Enumerable<Predmet>();

                foreach (Predmet o in predmeti)
                {
                    if (o.NazivPredmeta == z)
                    {
                        k = o.Id_Predmeta;

                    }
                }
                if (k == 0)
                {
                    MessageBox.Show("Naziv predmeta ne postoji u bazi");
                    this.Hide();
                    FormaPredmet forma_predmet = new FormaPredmet();
                    forma_predmet.Show();
                }
                else
                {
                    Entiteti.Predmet p = s.Load<Entiteti.Predmet>(k);
                    Godine o1 = new Godine()
                    {
                        Godina = textBox1_Godine.Text.ToString(),
                        Predmeti1 = p
                    };
                    s.Save(o1);
                    s.Flush();
                    s.Close();
                    this.Hide();
                    FormaPredmet forma_predmet = new FormaPredmet();
                    forma_predmet.Show();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Doslo je do greske prilikom dodavanja");
                this.Hide();
                FormaPredmet forma_predmet = new FormaPredmet();
                forma_predmet.Show();
             //   MessageBox.Show(ec.Message);

            }
        }

        private void button1_Azuriraj_Click(object sender, EventArgs e)
        {
            if (dataGridView1_Godine.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1_Godine.SelectedRows[0].Cells[0].Value;
                try
                {
                    ISession s = DataLayer.GetSession();

                    Godine o = s.Load<Godine>(id);
                    String z = textBox2_NAzivPredmetaGodine.Text.ToString();
                    IQuery q = s.CreateQuery("from Predmet");
                    IEnumerable<Predmet> predmeti = q.Enumerable<Predmet>();
                    foreach (Predmet h in predmeti)
                    {
                        if (h.NazivPredmeta == z)
                        {
                            o.Predmeti1.Id_Predmeta = h.Id_Predmeta;
                        }
                    }
                    o.Predmeti1.NazivPredmeta = textBox2_NAzivPredmetaGodine.Text.ToString();
                    o.Godina = textBox1_Godine.Text.ToString();
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
                    FormaPredmet forma_predmet = new FormaPredmet();
                    forma_predmet.Show();

                }
                catch (Exception ec)
                {
                    MessageBox.Show("Doslo je do greske!");
                    this.Hide();
                    FormaPredmet forma_predmet = new FormaPredmet();
                    forma_predmet.Show();
                  //  MessageBox.Show(ec.Message);
                }

            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }


    }
}
