using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Entiteti
{
    public class Ucenik
    {
        public virtual int IdUcenika { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual int Razred { get; set; }
        public virtual string Ulica { get; set; }
        public virtual int Broj { get; set; }
        public virtual DateTime DatumUpisa { get; set; }
        public virtual IList<Ocena> Ocenee { get; set; }

        public virtual Smer UpisaoSmer { get; set; }
        public virtual IList<Roditelji> Roditelj { get; set; }
        public virtual IList<ImaClanoveVeca> ImaClanove { get; set; }

        public Ucenik()
        {
            Ocenee = new List<Ocena>();

            Roditelj = new List<Roditelji>();

            ImaClanove = new List<ImaClanoveVeca>();

        }
    }
}
