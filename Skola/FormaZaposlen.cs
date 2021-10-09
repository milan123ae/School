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
using Skola.Mapiranje;
using System.Globalization;
using System.Collections;
using NHibernate.Linq;
namespace Skola
{
    public partial class FormaZaposlen : Form
    {
        public FormaZaposlen()
        {
            this.MaximizeBox = false;
            InitializeComponent();
            ISession s = DataLayer.GetSession();
            IList<AngazovanNa> lista = s.QueryOver<AngazovanNa>().List<AngazovanNa>();

            dataGridView1Azuriraj.DataSource = lista.Select(t => new AngazovanModel(t)).ToList();
            s.Close();
           
        }
       

        private void button1_doddajZaposlenog_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajZaposlenog forma_dodaj_zaposlenog = new DodajZaposlenog();
            forma_dodaj_zaposlenog.Show();
        }


        private void button1_Azuriraj_Click(object sender, EventArgs e)
        {
            Int32 m = Int32.Parse(textBox1_JMBG.Text);
            if (radioButton1_Nastavno.Checked)
            {

                try
                {
                    ISession s = DataLayer.GetSession();

                    NastavnoOsoblje o = s.Load<NastavnoOsoblje>(m);

                    //originalna sesija se zatvara i raskida se veza izmedju objekta i sesije

                    //objekat se modifikuje potpuno nezavisno od sesije
                    o.Lime = textBox1_Ime.Text.ToString();
                    o.ImeRoditelja = textBox2_Ime_roditelja.Text.ToString();
                    o.Prezime = textBox3_Prezime.Text.ToString();
                    o.DatumRodjenja = Convert.ToDateTime(dateTimePicker1_DATUM.Text);
                    o.Ulica = textBox5_Ulica.Text.ToString();
                    o.Broj = Int32.Parse(textBox7_Broj.Text);
                    if (radioButton1_Puna.Checked)
                    {
                        o.NazivSkole = "null";
                        o.BrojCasovaNedeljno = 0;
                    }
                    else
                    {
                        o.NazivSkole = textBox6_NazivSkole.Text.ToString();
                        o.BrojCasovaNedeljno = Int32.Parse(textBox8_BrojCasova.Text);
                    }
                    s.Close();
                    //otvara se nova sesija
                    ISession s1 = DataLayer.GetSession();

                    //poziva se Update i objekat se povezuje sa novom sesijom
                    s1.Update(o);

                    s1.Flush();
                    s1.Close();
                    MessageBox.Show("Uspesno azuriranje");
                    this.Hide();
                    FormaZaposlen forma_zaposlen = new FormaZaposlen();
                    forma_zaposlen.Show();

                }
                catch (Exception ec)
                {
                    MessageBox.Show("Neuspesno azuriranje");
                    this.Hide();
                    FormaZaposlen forma_zaposlen = new FormaZaposlen();
                    forma_zaposlen.Show();
                 //   MessageBox.Show(ec.Message);
                }
            }
            else
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    NenastavnoOsoblje o = s.Load<NenastavnoOsoblje>(m);

                    //originalna sesija se zatvara i raskida se veza izmedju objekta i sesije

                    //objekat se modifikuje potpuno nezavisno od sesije
                    o.Lime = textBox1_Ime.Text.ToString();
                    o.ImeRoditelja = textBox2_Ime_roditelja.Text.ToString();
                    o.Prezime = textBox3_Prezime.Text.ToString();
                    o.DatumRodjenja = Convert.ToDateTime(dateTimePicker1_DATUM.Text);
                    o.Ulica = textBox5_Ulica.Text.ToString();
                    o.Broj = Int32.Parse(textBox7_Broj.Text);
                    o.StrucnaSprema = textBox1_StrucnaSprema.Text.ToString();
                    o.NazivSektora = textBox2_NazivSektora.Text.ToString();
                    s.Close();
                    //otvara se nova sesija
                    ISession s1 = DataLayer.GetSession();

                    //poziva se Update i objekat se povezuje sa novom sesijom
                    s1.Update(o);

                    s1.Flush();
                    s1.Close();
                    this.Hide();
                    FormaZaposlen forma_zaposlen = new FormaZaposlen();
                    forma_zaposlen.Show();

                }
                catch (Exception ec)
                {
                    MessageBox.Show("Neuspesno azuriranje");
                    this.Hide();
                    FormaZaposlen forma_zaposlen = new FormaZaposlen();
                    forma_zaposlen.Show();
                //    MessageBox.Show(ec.Message);
                }
 
            }
            
            
            
        }

        private void button1_Obrisi_Click(object sender, EventArgs e)
        {
            if (radioButton2_Nenastavno.Checked)
            {
                try
                {
                    Int32 l = Int32.Parse(textBox1_JMBG.Text);
                    ISession s = DataLayer.GetSession();
                    NenastavnoOsoblje o = s.Load<NenastavnoOsoblje>(l);
                   
                    //brise se objekat iz baze ali ne i instanca objekta u memroiji
                    s.Delete(o);
                    //s.Delete("from Odeljenje");
                    s.Flush();
                    s.Close();
                    this.Hide();
                    FormaZaposlen forma_zaposlen = new FormaZaposlen();
                    forma_zaposlen.Show();

                }
                catch (Exception ec)
                {
                    MessageBox.Show("JMBG i selektovani tip osoblja ne postoje u bazi!");
                    this.Hide();
                    FormaZaposlen forma_zaposlen = new FormaZaposlen();
                    forma_zaposlen.Show();
                 //   MessageBox.Show(ec.InnerException.Message);
                }
            }
            else 
            {
                try
                {
                    Int32 l = Int32.Parse(textBox1_JMBG.Text);
                    ISession s = DataLayer.GetSession();

                    NastavnoOsoblje o = s.Load<NastavnoOsoblje>(l);
                   
                    s.Delete(o);
                    s.Flush();
                    s.Close();
                    this.Hide();
                    FormaZaposlen forma_zaposlen = new FormaZaposlen();
                    forma_zaposlen.Show();

                }
                catch (Exception ec)
                {
                    MessageBox.Show("JMBG i selektovani tip osoblja ne postoje u bazi!");
                    this.Hide();
                    FormaZaposlen forma_zaposlen = new FormaZaposlen();
                    forma_zaposlen.Show();
                 //   MessageBox.Show(ec.InnerException.Message);

                }
            }
            
        }

        private void button1_Prikazi_Click(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.GetSession();
                Int32 m = Int32.Parse(textBox1_JMBG.Text);
                if (radioButton1_Nastavno.Checked)
                {
                    Skola.Entiteti.NastavnoOsoblje p = s.Load<Skola.Entiteti.NastavnoOsoblje>(m);
                    textBox1_Ime.Text = p.Lime.ToString();
                    textBox2_Ime_roditelja.Text = p.ImeRoditelja.ToString();
                    textBox3_Prezime.Text = p.Prezime.ToString();
                    dateTimePicker1_DATUM.Text = p.DatumRodjenja.ToString();
                     textBox5_Ulica.Text = p.Ulica.ToString();
                     textBox7_Broj.Text = p.Broj.ToString();

                     if (p.TipNorme.ToString() == "Puna" || p.TipNorme == "PUNA")
                     {
 
                         textBox1_StrucnaSprema.Visible = false;
                         textBox2_NazivSektora.Visible = false;
                         textBox6_NazivSkole.Visible = false;
                         textBox8_BrojCasova.Visible = false;
                         radioButton1_Puna.Select();

                     }
                     else if (p.TipNorme.ToString() == "Neophodna" || p.TipNorme == "NEOPHODNA")
                     {
                         textBox1_StrucnaSprema.Visible = false;
                         textBox2_NazivSektora.Visible = false;
                         textBox6_NazivSkole.Text = p.NazivSkole.ToString();
                         textBox8_BrojCasova.Text = p.BrojCasovaNedeljno.ToString();
                         radioButton2_Neophodna.Select();
                     }
                     else
                     {
                         MessageBox.Show("Tip Norme je lose upisan u bazu!");
                         this.Hide();
                         FormaZaposlen forma_zaposlen = new FormaZaposlen();
                         forma_zaposlen.Show();
                     }
                }
                else
                {
                    Skola.Entiteti.NenastavnoOsoblje p = s.Load<Skola.Entiteti.NenastavnoOsoblje>(m);
                    textBox1_Ime.Text = p.Lime.ToString();
                    textBox2_Ime_roditelja.Text = p.ImeRoditelja.ToString();
                    textBox3_Prezime.Text = p.Prezime.ToString();
                    dateTimePicker1_DATUM.Text = p.DatumRodjenja.ToString();
                    textBox5_Ulica.Text = p.Ulica.ToString();
                    textBox7_Broj.Text = p.Broj.ToString();
                    textBox2_NazivSektora.Text = p.NazivSektora.ToString();
                    textBox1_StrucnaSprema.Text = p.StrucnaSprema.ToString();
                    textBox6_NazivSkole.Visible = false;
                    textBox8_BrojCasova.Visible = false;
                    radioButton1_Puna.Visible = false;
                    radioButton2_Neophodna.Visible = false;
                }


                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("JMBG ne postoji u bazi za selektovani tip osoblja!");
                this.Hide();
                FormaZaposlen forma_zaposlen = new FormaZaposlen();
                forma_zaposlen.Show();
               // MessageBox.Show(ec.InnerException.Message);

            }

        }

        private void radioButton1_Puna_CheckedChanged(object sender, EventArgs e)
        {
            textBox6_NazivSkole.Visible = false;
            textBox8_BrojCasova.Visible = false;
        }

        private void radioButton2_Neophodna_CheckedChanged(object sender, EventArgs e)
        {
            textBox6_NazivSkole.Visible = true;
            textBox8_BrojCasova.Visible = true;
        }

        private void button1_Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 forma1 = new Form1();
            forma1.Show();
        }

        public class AngazovanModel
        {
            public Int32 Id { get; set; }
            public Int32 JMBG { get; set; }
            public String NazivPredmeta { get; set; }
            public String Datum { get; set; }

            public AngazovanModel(AngazovanNa p)
            {
                Id = p.Id;
                JMBG = p.Angazovanje.Jmbg;
                NazivPredmeta = p.Angazovan.NazivPredmeta;
                Datum = p.DatumAngazovanja.ToString();
            }
        }

        private void Azurirajj_Click(object sender, EventArgs e)
        {
            if (dataGridView1Azuriraj.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1Azuriraj.SelectedRows[0].Cells[0].Value;
                try
                {
                    ISession s = DataLayer.GetSession();

                    AngazovanNa o = s.Load<AngazovanNa>(id);
                    String z = texIDprEDMETA.Text.ToString();
                    IQuery q = s.CreateQuery("from Predmet");
                    IEnumerable<Predmet> predmeti = q.Enumerable<Predmet>();
                    foreach (Predmet h in predmeti)
                    {
                        if (h.NazivPredmeta == z)
                        {
                            o.Angazovan.Id_Predmeta = h.Id_Predmeta;
                        }
                    }
                   // o.Angazovan.Id_Predmeta =Int32.Parse(texIDprEDMETA.Text);
                    o.Angazovanje.Jmbg = Int32.Parse(texJMBG.Text);
                    o.DatumAngazovanja = Convert.ToDateTime(dateTimePicker111.Text);
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
                    FormaZaposlen forma_zaposlen = new FormaZaposlen();
                    forma_zaposlen.Show();

                }
                catch (Exception ec)
                {
                    MessageBox.Show("Azuriranje nije moguce!");
                    this.Hide();
                    FormaZaposlen forma_zaposlen = new FormaZaposlen();
                    forma_zaposlen.Show();
                  //  MessageBox.Show(ec.Message);
                }

            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }

        private void Obrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1Azuriraj.SelectedRows.Count == 1)
            {
                ISession s = DataLayer.GetSession();

                Int32 id = (Int32)dataGridView1Azuriraj.SelectedRows[0].Cells[0].Value;

                AngazovanNa o = s.Load<AngazovanNa>(id);


                s.Delete(o);
                s.Flush();
                s.Close();
                this.Hide();
                FormaZaposlen forma_zaposlen = new FormaZaposlen();
                forma_zaposlen.Show();
            }
            else
                MessageBox.Show("Morate selektovati neku vrsu!", "Upozorenje!");
        }

        private void Doodaj_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.NastavnoOsoblje p = s.Load<Entiteti.NastavnoOsoblje>(Int32.Parse(texJMBG.Text));
                String z = texIDprEDMETA.Text.ToString();
                IQuery q = s.CreateQuery("from Predmet");
                IEnumerable<Predmet> predmeti = q.Enumerable<Predmet>();
                Int32 k = 0;
                foreach (Predmet h in predmeti)
                {
                    if (h.NazivPredmeta == z)
                    {
                       k= h.Id_Predmeta;
                    }
                }
                if (k == 0)
                {
                    MessageBox.Show("Predmet ne postoji u bazi!");
                    this.Hide();
                    FormaZaposlen forma_zaposlen = new FormaZaposlen();
                    forma_zaposlen.Show();
                }
                else
                {

                    Entiteti.Predmet r = s.Load<Entiteti.Predmet>(k);
                    AngazovanNa o1 = new AngazovanNa()
                    {
                        DatumAngazovanja = Convert.ToDateTime(dateTimePicker111.Text),

                        Angazovanje = p,
                        Angazovan = r
                    };

                    s.Save(o1);
                    s.Flush();
                    s.Close();
                    this.Hide();
                    FormaZaposlen forma_zaposlen = new FormaZaposlen();
                    forma_zaposlen.Show();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("Podaci nisu odgovarajuci");
                this.Hide();
                FormaZaposlen forma_zaposlen = new FormaZaposlen();
                forma_zaposlen.Show();
            //    MessageBox.Show(ec.Message);

            }
        }

        private void FormaZaposlen_Load(object sender, EventArgs e)
        {
            
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void JMBG_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
