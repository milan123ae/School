using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Entiteti
{
    public class Smer
    {
        public virtual int IdSmera { get; set; }
        public virtual string NazivSmera { get; set; }
        public virtual int BrojUcenika { get; set; }
        public virtual IList<Ucenik> Ucenici { get; set; }
        public virtual IList<Predmet> Predmeti { get; set; }
        public virtual IList<UciNa> UceNa { get; set; }

        public Smer()
        {
            Ucenici = new List<Ucenik>();
            Predmeti = new List<Predmet>();
            UceNa = new List<UciNa>();
        }
    }
}
