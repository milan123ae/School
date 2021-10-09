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
    public partial class DodajOcenu : Form
    {
        public DodajOcenu()
        {
            this.MaximizeBox = false;
            InitializeComponent();
            ocena_combobox.SelectedIndex = 0;

            ISession s = DataLayer.GetSession();
            IList<Ocena> lista = s.QueryOver<Ocena>().List<Ocena>();

            lista_ucenika_data_grid_view.DataSource = lista.Select(t => new OcenaModel(t)).ToList();
            s.Close();
        }

        public class OcenaModel
        {
            public int IdOcena { get; set; }
            public int IdUcenika { get; set; }
            public string DatumDobijanja { get; set; }
            public String Opis { get; set; }
            public int Vrednost { get; set; }
            public String NazivPredmeta { get; set; }

            public OcenaModel(Ocena p)
            {
                IdOcena = p.Id_Ocena;
                IdUcenika = p.UpisaoUcenik.IdUcenika;
                DatumDobijanja  = p.DatumDobijanjaOcene.ToString();
                Opis = p.Opis;
                Vrednost  = p.Vrednost;
                NazivPredmeta = p.UpisaoPredmet.NazivPredmeta;
            }
        }

        private void DodajOcenu_Load(object sender, EventArgs e)
        {

        }

        private void lista_ucenika_data_grid_view_SelectionChanged(object sender, EventArgs e)
        {
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lista_ucenika_data_grid_view_CellContentClick(object sender, EventArgs e)
        {

        }

        private void id_ucenika_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lista_ucenika_data_grid_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Obrisi_Click(object sender, EventArgs e)
        {
            if (lista_ucenika_data_grid_view.SelectedRows.Count == 1)
            {
                ISession s = DataLayer.GetSession();

                Int32 id = (Int32)lista_ucenika_data_grid_view.SelectedRows[0].Cells[0].Value;

                Ocena o = s.Load<Ocena>(id);
                s.Delete(o);
                s.Flush();
                s.Close();
                this.Hide();
                DodajOcenu forma_dodaj_ocenu = new DodajOcenu();
                forma_dodaj_ocenu.Show();
            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }

        private void button2_Dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                String z = textBox1_NazivPredmeta.Text.ToString();
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
                    DodajOcenu forma_dodaj_ocenu = new DodajOcenu();
                    forma_dodaj_ocenu.Show();
                }
                else
                {
                    Entiteti.Predmet p = s.Load<Entiteti.Predmet>(k);
                    Entiteti.Ucenik u = s.Load<Entiteti.Ucenik>(Int32.Parse(id_ucenika_txt.Text));
                    Ocena o1 = new Ocena()
                    {
                        Vrednost = Int32.Parse(ocena_combobox.Text),
                        Opis =opis_ocene_txt.Text.ToString(),
                        DatumDobijanjaOcene = Convert.ToDateTime(datum_dobijanja_box.Text),
                        UpisaoPredmet = p,
                        UpisaoUcenik = u
                    };
                    s.Save(o1);
                    s.Flush();
                    s.Close();
                    this.Hide();
                    DodajOcenu forma_dodaj_ocenu = new DodajOcenu();
                    forma_dodaj_ocenu.Show(); ;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Doslo je do greske prilikom dodavanja");
                this.Hide();
                DodajOcenu forma_dodaj_ocenu = new DodajOcenu();
                forma_dodaj_ocenu.Show();
               // MessageBox.Show(ec.Message);
            }
        }

        private void button1_Azuriraj_Click(object sender, EventArgs e)
        {
            if (lista_ucenika_data_grid_view.SelectedRows.Count == 1)
            {
                int id = (int)lista_ucenika_data_grid_view.SelectedRows[0].Cells[0].Value;
                try
                {
                    ISession s = DataLayer.GetSession();

                    Ocena o = s.Load<Ocena>(id);
                    String z = textBox1_NazivPredmeta.Text.ToString();
                    IQuery q = s.CreateQuery("from Predmet");
                    IEnumerable<Predmet> predmeti = q.Enumerable<Predmet>();
                    foreach (Predmet h in predmeti)
                    {
                        if (h.NazivPredmeta == z)
                        {
                            o.UpisaoPredmet.Id_Predmeta = h.Id_Predmeta;
                        }
                    }
                    o.UpisaoPredmet.NazivPredmeta = textBox1_NazivPredmeta.Text.ToString();
                    o.UpisaoUcenik.IdUcenika = Int32.Parse(id_ucenika_txt.Text);
                    o.Opis = opis_ocene_txt.Text.ToString();
                    o.Vrednost =Int32.Parse(ocena_combobox.Text);
                    o.DatumDobijanjaOcene = Convert.ToDateTime(datum_dobijanja_box.Text);
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
                    DodajOcenu forma_dodaj_ocenu = new DodajOcenu();
                    forma_dodaj_ocenu.Show();

                }
                catch (Exception ec)
                {
                    MessageBox.Show("Doslo je do greske!");
                    this.Hide();
                    DodajOcenu forma_dodaj_ocenu = new DodajOcenu();
                    forma_dodaj_ocenu.Show();
                   // MessageBox.Show(ec.Message);
                }

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
    }
}
