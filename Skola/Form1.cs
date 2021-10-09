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
using Skola.Mapiranje;
using System.Globalization;
using System.Collections;

namespace Skola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void dodaj_ucenka_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajUcenika forma_dodaj_ucenika = new DodajUcenika();
            forma_dodaj_ucenika.Show();
        }

        private void dodaj_ocenu_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajOcenu forma_dodaj_ocenu = new DodajOcenu();
            forma_dodaj_ocenu.Show();
        }

        private void dodaj_zaposlenog_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajZaposlenog forma_dodaj_zaposlenog = new DodajZaposlenog();
            forma_dodaj_zaposlenog.Show();
        }

        private void button14_Zaposlen_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaZaposlen forma_zaposlen = new FormaZaposlen();
            forma_zaposlen.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaPredmet forma_predmet = new FormaPredmet();
            forma_predmet.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaSmer forma_smer = new FormaSmer();
            forma_smer.Show();
        }

        private void button24_Ucenik_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaUcenik forma_ucenik = new FormaUcenik();
            forma_ucenik.Show();
        }

        private void button24_Roditelji_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormaRoditelj forma_roditelj = new FormaRoditelj();
            forma_roditelj.Show();
        }

        private void button24_OCENA_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajOcenu forma_dodaj_ocenu = new DodajOcenu();
            forma_dodaj_ocenu.Show();
        }
    }
}
