using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Entiteti
{
    public class Zaposlen
    {
        public virtual int Jmbg { get; set; }
        public virtual string Lime { get; set; }
        public virtual string ImeRoditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string Ulica { get; set; }
        public virtual int Broj { get; set; }
        public virtual string TipOsoblja { get; set; }
    }
    public class NastavnoOsoblje : Zaposlen
    {
        public virtual string TipNorme { get; set; }
        public virtual string NazivSkole { get; set; }
        public virtual int BrojCasovaNedeljno { get; set; }
        public virtual IList<Predmet> Predmetii { get; set; }
        public virtual IList<AngazovanNa> Angazovanje { get; set; }
        public NastavnoOsoblje()
        {
            Predmetii = new List<Predmet>();
            Angazovanje = new List<AngazovanNa>();
        }
    }
    public class NenastavnoOsoblje : Zaposlen
    {
        public virtual string StrucnaSprema { get; set; }
        public virtual string NazivSektora { get; set; }

    }
}
