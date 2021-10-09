using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skola.Entiteti
{
    public class Roditelji
    {
        public virtual int IdRoditelja { get; set; }
        public virtual string ImeRod { get; set; }
        public virtual string PrezimeRod { get; set; }

        public virtual IList<Ucenik> Ucenici { get; set; }
        public virtual IList<ImaClanoveVeca> ImaClanoveRod { get; set; }

        public virtual IList<Telefon> Telefoni { get; set; }

        public Roditelji()
        {
            Telefoni = new List<Telefon>();
            Ucenici = new List<Ucenik>();
            ImaClanoveRod = new List<ImaClanoveVeca>();
        }
    }
}
