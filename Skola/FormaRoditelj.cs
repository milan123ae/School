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
    public partial class FormaRoditelj : Form
    {
        public FormaRoditelj()
        {
            this.MaximizeBox = false;
            InitializeComponent();
            ISession s = DataLayer.GetSession();
            IList<Roditelji> lista = s.QueryOver<Roditelji>().List<Roditelji>();
            IList<ImaClanoveVeca> listaa = s.QueryOver<ImaClanoveVeca>().List<ImaClanoveVeca>();
            IList<Telefon> listaaa = s.QueryOver<Telefon>().List<Telefon>();
            dataGridView1_Roditelj.DataSource = lista.Select(t => new RoditeljModel(t)).ToList();
            dataGridView2_ImaClanove.DataSource = listaa.Select(t => new ImaClanoveModel(t)).ToList();
            dataGridView3_Telefon.DataSource = listaaa.Select(t => new TelefonModel(t)).ToList();

            s.Close();
        }
        public class RoditeljModel
        {
            public Int32 Id { get; set; }
            public String Ime { get; set; }
            public String Prezime { get; set; }

            public RoditeljModel(Roditelji r)
            {
                Id = r.IdRoditelja;
                Ime = r.ImeRod;
                Prezime = r.PrezimeRod;
            }
        }
        public class ImaClanoveModel
        {
            public Int32 Id { get; set; }
            public int IdRoditelja { get; set; }
            public int IdUcenika { get; set; }


            public ImaClanoveModel(ImaClanoveVeca p)
            {
                Id = p.ImaClanoveVecaId;
                IdRoditelja = p.Roditelj.IdRoditelja;
                IdUcenika = p.ImaClanove.IdUcenika;
            }
        }
        public class TelefonModel
        {
            public Int32 Id { get; set; }
            public int IdRoditelja { get; set; }
            public int Telefon { get; set; }

            public TelefonModel(Telefon p)
            {
                Id = p.IdTelefona;
                IdRoditelja = p.Roditeljifon.IdRoditelja;
                Telefon = p.Telefonn;
            }
        }

        private void button1_ObrisiRod_Click(object sender, EventArgs e)
        {
            if (dataGridView1_Roditelj.SelectedRows.Count == 1)
            {
                ISession s = DataLayer.GetSession();

                Int32 id = (Int32)dataGridView1_Roditelj.SelectedRows[0].Cells[0].Value;

                Roditelji o = s.Load<Roditelji>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
                this.Hide();
                FormaRoditelj forma_roditelj = new FormaRoditelj();
                forma_roditelj.Show();
            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }

        private void button2_ObrisiImaCl_Click(object sender, EventArgs e)
        {
            if (dataGridView2_ImaClanove.SelectedRows.Count == 1)
            {
                ISession s = DataLayer.GetSession();

                Int32 id = (Int32)dataGridView2_ImaClanove.SelectedRows[0].Cells[0].Value;

                ImaClanoveVeca o = s.Load<ImaClanoveVeca>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
                this.Hide();
                FormaRoditelj forma_roditelj = new FormaRoditelj();
                forma_roditelj.Show();
            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }

        private void button3_Fon_Click(object sender, EventArgs e)
        {
            if (dataGridView3_Telefon.SelectedRows.Count == 1)
            {
                ISession s = DataLayer.GetSession();

                Int32 id = (Int32)dataGridView3_Telefon.SelectedRows[0].Cells[0].Value;

                Telefon o = s.Load<Telefon>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
                this.Hide();
                FormaRoditelj forma_roditelj = new FormaRoditelj();
                forma_roditelj.Show();
            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }

        private void button1_DodajRod_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Roditelji o1 = new Roditelji()
                {
                    ImeRod = textBox1_Ime.Text.ToString(),
                    PrezimeRod = textBox6_Prezime.Text.ToString(),
                };
                s.Save(o1);
                s.Flush();
                s.Close();
                this.Hide();
                FormaRoditelj forma_roditelj = new FormaRoditelj();
                forma_roditelj.Show();
            }

            catch (Exception ec)
            {
                MessageBox.Show("Doslo je do greske u dodavanju");
                this.Hide();
                FormaRoditelj forma_roditelj = new FormaRoditelj();
                forma_roditelj.Show();
              //  MessageBox.Show(ec.Message);
            }

        }

        private void button2_DodajCl_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Ucenik p = s.Load<Entiteti.Ucenik>(Int32.Parse(textBox4_IDUCEN.Text));
                Entiteti.Roditelji r = s.Load<Entiteti.Roditelji>(Int32.Parse(textBox2_IdRod.Text));
                    ImaClanoveVeca o1 = new ImaClanoveVeca()
                    {

                         ImaClanove = p,
                         Roditelj = r
                    };

                    s.Save(o1);
                    s.Flush();
                    s.Close();
                    this.Hide();
                    FormaRoditelj forma_roditelj = new FormaRoditelj();
                    forma_roditelj.Show();
                }
            
            catch (Exception ec)
            {
                MessageBox.Show("Podaci nisu odgovarajuci");
                this.Hide();
                FormaRoditelj forma_roditelj = new FormaRoditelj();
                forma_roditelj.Show();
             //   MessageBox.Show(ec.Message);

            }
        }

        private void button1_DodajFon_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Int32 z = Int32.Parse(textBox3_IdRodit.Text);
                Int32 k = 0;
                IQuery q = s.CreateQuery("from Roditelji");
                IEnumerable<Roditelji> roditelji = q.Enumerable<Roditelji>();

                foreach (Roditelji o in roditelji)
                {
                    if (o.IdRoditelja == z)
                    {
                        k = o.IdRoditelja;

                    }
                }
                if (k == 0)
                {
                    MessageBox.Show("Roditelj ne postoji u bazi");
                    this.Hide();
                    FormaRoditelj forma_roditelj = new FormaRoditelj();
                    forma_roditelj.Show();
                }
                else
                {
                    Entiteti.Roditelji p = s.Load<Entiteti.Roditelji>(k);
                    Telefon o1 = new Telefon()
                    {
                        Telefonn =Int32.Parse(textBox5_Telefon.Text),
                        Roditeljifon = p
                    };
                    s.Save(o1);
                    s.Flush();
                    s.Close();
                    this.Hide();
                    FormaRoditelj forma_roditelj = new FormaRoditelj();
                    forma_roditelj.Show();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Doslo je do greske prilikom dodavanja");
                this.Hide();
                FormaRoditelj forma_roditelj = new FormaRoditelj();
                forma_roditelj.Show();
            //    MessageBox.Show(ec.Message);
            }
        }

        private void button2_AzurirajRod_Click(object sender, EventArgs e)
        {
            if (dataGridView1_Roditelj.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1_Roditelj.SelectedRows[0].Cells[0].Value;
                try
                {
                    ISession s = DataLayer.GetSession();

                    Roditelji o = s.Load<Roditelji>(id);
                    o.ImeRod = textBox1_Ime.Text.ToString();
                    o.PrezimeRod = textBox6_Prezime.Text.ToString();
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
                    FormaRoditelj forma_roditelj = new FormaRoditelj();
                    forma_roditelj.Show();
                }
                catch (Exception ec)
                {
                    MessageBox.Show("Doslo je do greske!");
                    this.Hide();
                    FormaRoditelj forma_roditelj = new FormaRoditelj();
                    forma_roditelj.Show();
                  //  MessageBox.Show(ec.Message);
                }

            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }

        private void button1_AzurirajCl_Click(object sender, EventArgs e)
        {
            if (dataGridView2_ImaClanove.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView2_ImaClanove.SelectedRows[0].Cells[0].Value;
                try
                {
                    ISession s = DataLayer.GetSession();

                    ImaClanoveVeca o = s.Load<ImaClanoveVeca>(id);
                    Int32 z = Int32.Parse(textBox2_IdRod.Text);
                    IQuery q = s.CreateQuery("from Roditelji");
                    IEnumerable<Roditelji> roditelji = q.Enumerable<Roditelji>();
                    foreach (Roditelji h in roditelji)
                    {
                        if (h.IdRoditelja == z)
                        {
                            o.Roditelj.IdRoditelja = h.IdRoditelja;
                        }
                    }
                    Int32 y = Int32.Parse(textBox4_IDUCEN.Text);
                    IQuery w = s.CreateQuery("from Ucenik");
                    IEnumerable<Ucenik> ucenici = w.Enumerable<Ucenik>();
                    foreach (Ucenik j in ucenici)
                    {
                        if (j.IdUcenika == y)
                        {
                            o.ImaClanove.IdUcenika = j.IdUcenika;
                        }
                    }

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
                    FormaRoditelj forma_roditelj = new FormaRoditelj();
                    forma_roditelj.Show();

                }
                catch (Exception ec)
                {
                    MessageBox.Show("Doslo je do greske");
                    this.Hide();
                    FormaRoditelj forma_roditelj = new FormaRoditelj();
                    forma_roditelj.Show();
                 //   MessageBox.Show(ec.Message);

                }

            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }

        private void button2_AzurirajFon_Click(object sender, EventArgs e)
        {
            if (dataGridView3_Telefon.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView3_Telefon.SelectedRows[0].Cells[0].Value;
                try
                {
                    ISession s = DataLayer.GetSession();

                    Telefon o = s.Load<Telefon>(id);
                    Int32 z =Int32.Parse(textBox3_IdRodit.Text);
                    IQuery q = s.CreateQuery("from Roditelji");
                    IEnumerable<Roditelji> roditelji = q.Enumerable<Roditelji>();
                    foreach (Roditelji h in roditelji)
                    {
                        if (h.IdRoditelja == z)
                        {
                            o.Roditeljifon.IdRoditelja = h.IdRoditelja;
                        }
                    }
                    o.Telefonn = Int32.Parse(textBox5_Telefon.Text);
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
                    FormaRoditelj forma_roditelj = new FormaRoditelj();
                    forma_roditelj.Show();

                }
                catch (Exception ec)
                {
                    MessageBox.Show("Doslo je do greske!");
                    this.Hide();
                    FormaRoditelj forma_roditelj = new FormaRoditelj();
                    forma_roditelj.Show();
               //     MessageBox.Show(ec.Message);

                }

            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }

        private void button3_Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 forma1 = new Form1();
            forma1.Show();
        }
    }
}
